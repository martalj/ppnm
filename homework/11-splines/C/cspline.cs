using static System.Console;
using static System.Math;
using System;

public class cspline{
	public double[] x,y,b,c,d;
	public cspline(double[] xs, double[] ys){
		x = xs;
		y = ys;
		int n = xs.Length;
		double[] dx = new double[n-1]; 
		double[] dy = new double[n-1];
		double[] p = new double[n-1];
		b = new double[n];
		c = new double[n-1];
		d = new double[n-1];

		for(int i=0;i<n-1;i++){
			dx[i] = x[i+1]-x[i]; if(!(dx[i]>0)) throw new Exception("linterp: dx[i]<0");
			dy[i] = y[i+1]-y[i];
			p[i] = dy[i]/dx[i];
		}

		double[] D = new double[n];
		double[] Q = new double[n-1];
		double[] B = new double[n];

		D[0] = 2;

		for(int i=0;i<n-2;i++){
			D[i+1]=2*dx[i]/dx[i+1]+2;
		}

		D[n-1] = 2;
		Q[0] = 1;

		for(int i=0;i<n-2;i++){
			Q[i+1]=dx[i]/dx[i+1];
		}

		for(int i=0;i<n-2;i++){
			B[i+1]=3*(p[i]+p[i+1]*dx[i]/dx[i+1]);
		}

		B[0] = 3*p[0];
		B[n-1] = 3*p[n-2];

		for(int i=1;i<n;i++){
			D[i] -= Q[i-1]/D[i-1];
			B[i] -= B[i-1]/D[i-1];
		}

		b[n-1] = B[n-1]/D[n-1];

		for(int i=0;i<n-1;i++){
			b[i] = (B[i]-Q[i]*b[i+1])/D[i];
		}

		for(int i=0;i<n-1;i++){
			c[i] = (-2*b[i]-b[i+1]+3*p[i]/dx[i]);
			d[i] = (b[i]+b[i+1]-2*p[i])/dx[i]/dx[i];
		}

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
