using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		int n = 10;
		double[] x = new double[n];
		double[] y = new double[n];

		// x^2
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
		plainqspline pqspline = new plainqspline(x,y);
		plaincspline pcspline = new plaincspline(x,y);
		for(double k=0;k<x[n-1];k+=0.1){
			WriteLine($"{k} {spline.eval(k)} {spline.derivative(k)} {spline.integral(k)} {pqspline.eval(k)} {pcspline.eval(k)}");
		}

		WriteLine();
		WriteLine();

		// Line with bump
		double[] x2 = {0,1,2,3,4,5,6,7,8,9,10};
		double[] y2 = {1,1,1,1,2,4,8,4,2,1,1};
		for(int i=0;i<x2.Length;i++){
			WriteLine($"{x2[i]} {y2[i]}");
		}

		WriteLine();
		WriteLine();
		
		double[] p2 = subspline.inner(x2,y2);
		cspline spline2 = new cspline(x2,y2,p2);
		plainqspline pqspline2 = new plainqspline(x2,y2);
		plaincspline pcspline2 = new plaincspline(x2,y2);
		for(double k=0;k<x2[x2.Length-1];k+=0.1){
			WriteLine($"{k} {spline2.eval(k)} {spline2.derivative(k)} {spline2.integral(k)} {pqspline2.eval(k)} {pcspline2.eval(k)}");	
		}

		WriteLine();
		WriteLine();

		// Line with jump
		double[] x3 = {0,1,2,3,4,5,6,7,8,9,10};
		double[] y3 = {1,1,1,1,1,6,6,6,6,6,6};
		for(int i=0;i<x3.Length;i++){
			WriteLine($"{x3[i]} {y3[i]}");
		}
		
		WriteLine();
		WriteLine();

		double[] p3 = subspline.inner(x3,y3);
		cspline spline3 = new cspline(x3,y3,p3);
		plainqspline pqspline3 = new plainqspline(x3,y3);
		plaincspline pcspline3 = new plaincspline(x3,y3);
		for(double k=0;k<x3[x3.Length-1];k+=0.1){
			WriteLine($"{k} {spline3.eval(k)} {spline3.derivative(k)} {spline3.integral(k)} {pqspline3.eval(k)} {pcspline3.eval(k)}");	
		}
		WriteLine();
		WriteLine();

		//Line with a couple of bumps
		double[] x4 = {0,1,2,3,4,5,6,7,8,9,10};
		double[] y4 = {1,1,6,1,2,4,8,4,2,1,7};
		for(int i=0;i<x4.Length;i++){
			WriteLine($"{x4[i]} {y4[i]}");
		}

		WriteLine();
		WriteLine();
		
		double[] p4 = subspline.inner(x4,y4);
		cspline spline4 = new cspline(x4,y4,p4);
		plainqspline pqspline4 = new plainqspline(x4,y4);
		plaincspline pcspline4 = new plaincspline(x4,y4);
		for(double k=0;k<x4[x4.Length-1];k+=0.1){
			WriteLine($"{k} {spline4.eval(k)} {spline4.derivative(k)} {spline4.integral(k)} {pqspline4.eval(k)} {pcspline4.eval(k)}");	
		}

	}//Main
}//class
