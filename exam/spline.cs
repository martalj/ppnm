using System;
using static System.Console;
using static System.Math;

public class subspline{
	public double[] x,y,p,b,c,d;
	public static double[] inner(double[] x, double[] y){
		int n = x.Length;
		double[] p = new double[n];

		for(int i=1;i<n-1;i++){
			double[] x_inner = new double[3];
			double[] y_inner = new double[3];

			x_inner[0] = x[i-1];
			x_inner[1] = x[i];
			x_inner[2] = x[i+1];
			y_inner[0] = y[i-1];
			y_inner[1] = y[i];
			y_inner[2] = y[i+1];
			
			
			qspline spline_inner = new qspline(x_inner,y_inner);

			if(i == 1){
				p[i-1] = spline_inner.derivative(i-1);
			}

			p[i] = spline_inner.derivative(i);

			if(i == n-2){
				p[i+1] = spline_inner.derivative(i+1);
			}

		} //for i

	return p;
	} //inner

}//class
