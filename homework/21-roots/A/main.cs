using static System.Console;
using static System.Math;
using System;

class main{
	public static void Main(){
		Func<vector,vector> f=delegate(vector x){
		return new vector(2*x[0]+3);
		};

		var x0 = new vector(-1.1);
		vector x1 = roots.newton(f,x0);
		WriteLine("Searching for roots for the function 2x+3:");
		WriteLine($"The root is at {x1[0]}. The function in this point yields {f(x1)[0]}");

		WriteLine();
		WriteLine();

		Func<vector,vector> R=delegate(vector x){
		return new vector(-2*(1-x[0])-400*(x[1]-x[0]*x[0]), 200*(x[1]-x[0]*x[0]));
		};

		var xR0 = new vector(2,8);
		var xR = roots.newton(R,xR0);
		WriteLine("Searching for extremums of Rosenbrock's valley function by searching for the roots of its gradient:");
		WriteLine($"The root is at {xR[0]},{xR[1]}. The function in this point yields {R(xR)[0]},{R(xR)[1]}");

	} //Main
} //class
