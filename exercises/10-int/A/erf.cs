using System;
using static System.Console;
using static System.Math;

class Erf{
	static double erf(double y){
	System.Func<double,double> f = delegate(double x){return Exp(-x*x);};
	double res = integrate.quad(f,0,y);
	return res*2/Sqrt(PI);
	}

	static void Main(){
	for(double x=-10;x<=10;x+=1.0/8)
		WriteLine($"{x} {erf(x)}");
	}
}
