using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
	System.Func<double,double> f = delegate(double x){return Log(x)/Sqrt(x);};
	double res = integrate.quad(f,0,1);
	WriteLine($"Result is {res}, exact result is -4");

	}

}
