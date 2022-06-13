using static System.Console;
using static System.Math;
using System;

class main{
	public static void Main(){
	        Func<vector,vector> f=delegate(vector x){
	            vector sol=new vector(-2*(x[0]-2)*(x[0]-2)+3);
	            return sol;};

		vector x0 = new double[] {1};
		vector x1 = roots.newton(f,x0);
		WriteLine($"Roots: {x1[0]} {x1[1]}. Evaluating roots {f(x1)[0]} {f(x1)[1]}");
	} //Main
} //class
