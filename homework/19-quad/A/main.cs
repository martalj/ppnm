using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		Func<double, double> sqrt = delegate(double x){return Sqrt(x);};
		double a = 0, b = 1;
		double sqrt_res = quad.integrate(sqrt,a,b);
		WriteLine($"The integral from 0 to 1 of sqrt(x) is {sqrt_res}, should be 2/3.");

		Func<double, double> divsqrt = delegate(double x){return 1/Sqrt(x);};
		double divsqrt_res = quad.integrate(divsqrt,a,b);
		WriteLine($"The integral from 0 to 1 of 1/sqrt(x) is {divsqrt_res}, should be 2.");

		Func<double, double> foursqrt = delegate(double x){return 4*Sqrt(1-x*x);};
		double foursqrt_res = quad.integrate(foursqrt,a,b);
		WriteLine($"The integral from 0 to 1 of 4*sqrt(1-x^2) is {foursqrt_res}, should be {PI}.");

		Func<double, double> lnsqrt = delegate(double x){return Log(x)/Sqrt(x);};
		double lnsqrt_res = quad.integrate(lnsqrt,a,b);
		WriteLine($"The integral from 0 to 1 of ln(x)/sqrt(x) is {lnsqrt_res}, should be -4.");

		WriteLine();
		WriteLine();

		Func<double, double> erf = delegate(double x){return 2/Sqrt(PI)*Exp(-x*x);};
		for(double i=-3;i<3;i+=0.001){
			double res = quad.integrate(erf,a,i);
			WriteLine($"{i} {res}");
		} //for

	}// Main
}// class
