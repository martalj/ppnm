using System;
using static System.Console;
using static System.Math;

class main{
public static void Main(){ //example from wikipedia "double integral over rectangle"
	Func<vector, double> f = delegate(vector x){return x[0]*x[0]+4*x[1];};
	vector a = new vector(11,7);
	vector b = new vector(14,10);
	for(int N=100;N<10000;N+=100){
		(double q, double e) = montecarlo.plainmc(f,a,b,N);
		WriteLine($"{N} {q} {e}");
	} //for
	
	WriteLine();
	WriteLine();
	
	Func<vector, double> F = delegate(vector x){return 1/(PI*PI*PI)*1/(1-Cos(x[0])*Cos(x[1])*Cos(x[2]));};
	vector start = new vector(0,0,0);
	vector end = new vector(PI,PI,PI);
	for(int N=100;N<10000;N+=100){
		(double r, double w) = montecarlo.plainmc(F,start,end,N);
		WriteLine($"{N} {r} {w}");
	}//for
	
	} //Main
} //class
