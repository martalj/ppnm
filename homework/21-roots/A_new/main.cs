using static System.Console;
using static System.Math;
using System;

class main{
	public static void Main(){
		Func<vector,vector> f=delegate(vector x){
		vector sol = new vector(1);
		sol[0] = 2*x[0];
		return sol;
		};

		var x0 = new vector(0.1);
		x0.print("x0 =");
		vector x1 = roots.newton(f,x0);
		x1.print("x1 =");
	} //Main
} //class
