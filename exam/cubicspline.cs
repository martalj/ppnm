using static System.Console;
using static System.Math;
using System;

public class cspline{
	public double[] x,y,b,c,d,p;

	public cspline(double[] xs, double[] ys, double[] ps){
		x = xs;
		y = ys;
		p = ps;
		int n = x.Length;
		double[] dx = new double[n-1]; 
		double[] dy = new double[n-1];
		double[] dp = new double[n-1];
		b = new double[n];
		c = new double[n];
		d = new double[n];

		for(int i=0;i<n-1;i++){
			dx[i] = x[i+1]-x[i]; if(!(dx[i]>0)) throw new Exception("linterp: dx[i]<0");
			dy[i] = y[i+1]-y[i];
			dp[i] = p[i+1]-p[i];

			b[i] = p[i];
			c[i] = 3*dy[i]/(dx[i]*dx[i]) - 3*p[i]/dx[i] - dp[i]/dx[i]; 
			d[i] = dp[i]/(dx[i]*dx[i]) - 2*dy[i]/(dx[i]*dx[i]*dx[i]) + 2*p[i]/(dx[i]*dx[i]);
		}//for

	}//cspline

	public double eval(double z){
		int i = binsearch(x,z);
		double S = y[i] + (z-x[i])*(b[i] + (z-x[i])*(c[i] + (z-x[i])*d[i]));
	return S;
	}//eval

	public static int binsearch(double[] x, double z){
		if(!(x[0]<=z && z<=x[x.Length-1])) throw new Exception("binsearch: bad z");
		int i=0, j=x.Length-1;
		while(j-i>1){
			int mid=(i+j)/2;
			if(z>x[mid]) i=mid; else j=mid;
			}
	return i;
	}//binsearch		
	

	public double derivative(double z){
		int i = binsearch(x,z);
	return b[i] + 2*c[i]*(z-x[i])+3*d[i]*(z-x[i])*(z-x[i]);
	}

	public double integral(double z){
		int n = binsearch(x,z);
		double integral = 0;
		for(int i=0;i<n;i++){
			integral += y[i]*(x[i+1]-x[i])+b[i]*(x[i+1]-x[i])*(x[i+1]-x[i])/2+c[i]*(x[i+1]-x[i])*(x[i+1]-x[i])*(x[i+1]-x[i])/3+d[i]*(x[i+1]-x[i])*(x[i+1]-x[i])*(x[i+1]-x[i])*(x[i+1]-x[i])/4;
		}
		integral += y[n]*(z-x[n])+b[n]*(z-x[n])*(z-x[n])/2+c[n]*(z-x[n])*(z-x[n])*(z-x[n])/3+d[n]*(z-x[n])*(z-x[n])*(z-x[n])*(z-x[n])/4;
	return integral;
	}

}//class
