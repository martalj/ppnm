using System;
using static System.Console;
using static System.Math;

class main{
	public static void Main(){
	        Func<vector,vector> f=delegate(vector x){
	            vector sol=new vector(x[0]*x[0]*x[1], 5*x[0] + Cos(x[1]));
	            return sol;};

		vector x0 = new vector(1,1);
		vector x1 = roots.newton(f,x0);
		WriteLine($"Roots: {x1[0]} {x1[1]}. Evaluating roots {f(x1)[0]} {f(x1)[1]}");
	} //Main
} //class
