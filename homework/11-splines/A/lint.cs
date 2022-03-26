using System;
public static partial class lint{

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

	public static double linterpInteg(double[] x, double[] y, double z){
		double integral = 0;
		int i = 0;
		while(z > x[i+1]){
			double dx = x[i+1]-x[i];
			double dy = y[i+1]-y[i];
			integral += y[i]*dx+0.5*dy*dx;
			i++;
			}
		integral += y[i]*(z-x[i]) + 0.5*(y[i+1]-y[i])/(x[i+1]+x[i])*(z-x[i])*(z-x[i]);
	return integral;
	}

}
