using System;
using static System.Console;
using static System.Math;

public class main{
	public static void Main(){
	        var list = new genlist<double[]>();
	        char[] delimiters = {' ','\t',','};
	        var options = StringSplitOptions.RemoveEmptyEntries;
		for(string line = ReadLine();line != null; line = ReadLine()){
			var data = line.Split(delimiters, options);
			int n = data.Length;
			var numbers = new double[n];
			for(int i=0;i<n;i++){
				numbers[i]=double.Parse(data[i]);
				}
			list.push(numbers);
			}
		var xs = list.data[0];
		var ys = list.data[1];
		var dy = list.data[2];
		
		for(int i=0;i<xs.Length;i++){
			ys[i] = Log(ys[i]);
			dy[i] = dy[i]/ys[i];
			WriteLine($"{xs[i]} {ys[i]} {dy[i]}");
			}

		var fs = new Func<double,double>[] {z=>1.0, z=>z};

		vector c = leastsquares.lsfit(fs,xs,ys,dy);
		
		WriteLine();		
		WriteLine();

		for(double x=0;x<15;x+=0.2){
			WriteLine($"{x} {c[0]+c[1]*x}");
			}

	}//Main function
}//class
