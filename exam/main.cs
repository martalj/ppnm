using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		var x = new double[10];
		var y = new double[10];
		for(int i=0;i<x.Length;i++){
			x[i] = i;
			y[i] = i*i;
		}
		
		double[] p;
		p = subspline.inner(x,y);
		for(int j=0;j<p.Length;j++){
			WriteLine($"{x[j]} {y[j]} {p[j]}");
		}

		WriteLine();
		WriteLine();

		cspline spline = new cspline(x,y,p);
		for(double k=1;k<x[x.Length-1];k+=0.1){
			WriteLine($"{k} {spline.eval(k)}");
		}

	}//Main
}//class
