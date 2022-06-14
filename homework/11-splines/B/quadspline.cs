using static System.Console;
using static System.Math;
using System;

public class qspline{
	public double[] x,y,b,c;
	public qspline(double[] xs, double[] ys){
		x=xs;
		y=ys;
		int n = xs.Length;
		double[] dx = new double[n-1]; 
		double[] dy = new double[n-1];
		double[] p = new double[n-1];
		b = new double[n-1];
		c = new double[n-1];

		for(int i=0;i<n-1;i++){
			dx[i] = x[i+1]-x[i]; if(!(dx[i]>0)) throw new Exception("linterp: dx[i]<0");
			dy[i] = y[i+1]-y[i];
			p[i] = dy[i]/dx[i];
		}

		for(int i=0;i<n-2;i++){
			c[i+1] = (p[i+1] - p[i] - c[i]*dx[i+1])/dx[i+1];
		}
		
		c[n-2]/=2;
		for(int i=n-3;i>=0;i--){
			c[i] = (p[i+1]-p[i]-c[i+1]*dx[i+1])/dx[i];
		}

		for(int i=0;i<n-1;i++){
			b[i]=p[i]-c[i]*dx[i];
		}

	}//qspline

	public double eval(double z){
		int i = binsearch(x,z);
		double S = y[i] + b[i]*(z-x[i])+c[i]*(z-x[i])*(z-x[i]);
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
	return b[i] + 2*c[i]*(z-x[i]);
	}

	public double integral(double z){
		int n = binsearch(x,z);
		double integral = 0;
		for(int i=0;i<n;i++){
			integral += y[i]*(x[i+1]-x[i])+b[i]*(x[i+1]-x[i])*(x[i+1]-x[i])/2+c[i]*(x[i+1]-x[i])*(x[i+1]-x[i])*(x[i+1]-x[i])/3;
		}
		integral += y[n]*(z-x[n])+b[n]*(z-x[n])*(z-x[n])/2+c[n]*(z-x[n])*(z-x[n])*(z-x[n])/3;
	return integral;
	}

}//class
