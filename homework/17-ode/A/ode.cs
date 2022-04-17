using System;
using static System.Console;
using static System.Math;

public class rk{
	public static (vector,vector) rkstep12(Func<double,vector,vector> f, double x, vector y, double h){
		vector k0 = f(x,y);
		vector k1 = f(x+h/2,y+k0*(h/2));
		vector yh = y+k1*h;
		vector er = (k1-k0)*h;
		return (yh,er);
	}//rkstep12

	public static vector driver(
			Func<double,vector,vector> F, double a, vector ya, double b, genlist<double> xlist = null, genlist<vector> ylist = null, 
			double h=0.01, double acc = 0.01, double eps=0.01){
		if(a>b) throw new Exception("driver: a>b");
		double x=a; vector y=ya;
		if(xlist!=null){xlist.clear();xlist.push(x);}
		if(ylist!=null){ylist.clear();ylist.push(y);}
		do{
			if(x>=b) return y;
			if(x+h>b) h=b-x;
			var (yh,erv) = rkstep12(F,x,y,h);
			double tol = Max(acc,yh.norm()*eps)*Sqrt(h/(b-a));
			double err = erv.norm();
			if(err<=tol){
				x+=h;y=yh;
				if(xlist!=null)xlist.push(x);
				if(ylist!=null)ylist.push(y);
			}//if
			h*= Min(Pow(tol/err,0.25)*0.95,2);
		}while(true);
	}//driver

}//Class
