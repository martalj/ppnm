using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		var rnd=new System.Random();
		int n=5,N=10*n;
		var x=new double[n];
		var y=new double[n];
		for(int i=0;i<n;i++){
			x[i]=i;
			y[i]=rnd.NextDouble()*5;
			WriteLine($"{x[i]} {y[i]}");
			}

		WriteLine();
	
		for(int j=0;j<N;j++){
			double z=x[0]+j*(x[n-1]-x[0]/(N-1));
			WriteLine($"{z} {linterp(x,y,z)}");
			}
	}

	public static double linterp(double[] x, double[] y, double z){
		int i = binsearch(x,z);
		double dx=x[i+1]-x[i]; if(!(dx>0)) throw new Exception("linterp: dx<0");
		double dy=y[i+1]-y[i];
	return y[i]+dy/dx*(z-x[i]);
	}

	public static int binsearch(double[] x, double z){
		if(!(x[0]<=z && z<=x[x.Length-1])) throw new Exception("binsearch: bad z");
		int i=0, j=x.Length-1;
		while(j-i>1){
			int mid=(i+j)/2;
			if(z>x[mid]) i=mid; else j=mid;
			}
	return i;
	}
}
