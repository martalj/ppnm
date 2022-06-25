using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		Func<vector,double> r = delegate(vector args){
			return (1-args[0])*(1-args[0]) +100*(args[1]-args[0]*args[0])*(args[1]-args[0]*args[0]);
		};	

		vector x0 = new vector(2);
		x0[0] = 1;
		x0[1] = 1;
		vector x1;
		int s;
		(x1,s) = minimize.qnewton(r,x0);
		WriteLine($"Rosenbrock minimum is at {x1[0]},{x1[1]}, found in {s} steps");

		Func<vector,double> h = delegate(vector args){
			return (args[0]*args[0]+args[1]-11)*(args[0]*args[0]+args[1]-11) + (args[0]+args[1]*args[1]-7)*(args[0]+args[1]*args[1]-7);
		};
		
		vector x2 = new vector(2);
		x2[0] = 1;
		x2[1] = 1;
		vector x3;
		int t;
		(x3,t) = minimize.qnewton(h,x0);
		WriteLine($"Himmelblau minimum is at {x3[0]},{x3[1]}, found in {t} steps");
		
	}

}
