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
		WriteLine($"The root is at {x1[0]}. The function in this point yields {f(x1)[0]} ");
	} //Main
} //class
