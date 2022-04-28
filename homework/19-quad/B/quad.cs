using System;
using static System.Console;
using static System.Math;

public class quad{
	public static double clencurt(Func<double,double> f, double a, double b,
	double del=0.001, double eps=0.001, double f2=Double.NaN, double f3=Double.NaN){
		double h=b-a;
		
		Func<double, double> F = delegate(double theta){
			double t = (a+b)/2+h/2*Cos(theta);
			double res = f(t)*Sin(theta)*h/2;
			return res;
		}; //F

		if(Double.IsNaN(f2)){
			f2=F(2*PI/6); 
			f3=F(4*PI/6);
			}

		double f1=F(PI/6), f4=F(5*PI/6);
		double Q = (2*f1+f2+f3+2*f4)/6*PI;
		double q = (f1+f2+f3+f4)/4*PI;
		double err = Abs(Q-q);
		if (err <= del+eps*Abs(Q)) return Q;
		else return clencurt(f,a,(a+b)/2,del/Sqrt(2),eps,f1,f2)+clencurt(f,(a+b)/2,b,del/Sqrt(2),eps,f3,f4);
	}// integrate

}//class
