using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		int n = 10;
		double[] x = new double[n];
		double[] y = new double[n];
		for(int i=0;i<n;i++){
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
		for(double k=0;k<x[n-1];k+=0.1){
			WriteLine($"{k} {spline.eval(k)} {spline.derivative(k)} {spline.integral(k)}");
		}

		WriteLine();
		WriteLine();

		double[] x2 = {0,1,2,3,4,5,6,7,8,9,10};
		double[] y2 = {1,1,1,1,2,4,8,4,2,1,1};
		for(int i=0;i<x2.Length;i++){
			WriteLine($"{x2[i]} {y2[i]}");
		}

		WriteLine();
		WriteLine();
		
		double[] p2 = subspline.inner(x2,y2);
		cspline spline2 = new cspline(x2,y2,p2);
		for(double k=0;k<x2[x2.Length-1];k+=0.1){
			WriteLine($"{k} {spline2.eval(k)} {spline2.derivative(k)} {spline2.integral(k)}");		
		}
	}//Main
}//class
