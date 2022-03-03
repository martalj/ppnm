using System;
using System.Threading;
using static System.Console;

public class data{ public int a,b; public double sum;
	public static void harm(object obj){
		data d = (data)obj;
		WriteLine($"Summing from {(float)d.a} to {(float)d.b}...");
		d.sum=0; for(int i=d.a;i<d.b;i++)d.sum+=1.0/i;
		WriteLine($"Summing from {(float)d.a} to {(float)d.b} gives {d.sum}.");
		}

	public static void Main(string[] args){
		int N = (int)1e8;
		if(args.Length>0) N = (int)double.Parse(args[0]);
		WriteLine($"Two threads: harmonic sum over N = {(float)N}.");
		data x = new data();
		x.a=1; x.b=N/2;
		data y = new data();
		y.a=N/2; y.b=N;
		Thread t1 = new Thread(harm);
		Thread t2 = new Thread(harm);
		t1.Start(x);
		t2.Start(y);
		t1.Join();
		t2.Join();
		WriteLine($"Two threads: harmonic sum from {1} to {(float)N} = {x.sum+y.sum}");
	}
}
