using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;

class main{
	static void Main(){

	Func<double,vector,vector> F = delegate(double t, vector u){  
	return new vector(u[1],-u[0]);
	};
	
	vector y0 = new vector(0,-1);
	double start = 0, stop = 2*PI;
	for(double i=0; i<=100; i++){
		double t = i/stop;
		vector res = rk.driver(F,start,y0,t);
		WriteLine($"{t} {res[0]} {res[1]}");
	}//for

	WriteLine();
	WriteLine();

	double b = 0.25, c = 5.0;

	Func<double, vector, vector> pend = delegate(double t, vector y){
	return new vector(y[1],-b*y[1]-c*Sin(y[0]));
	};

	vector init = new vector(PI-0.1,0);
	double a = 0, end = 10;
	for(double i = start; i<=100; i++){
		double t = i/end;
		vector res = rk.driver(pend,a,init,t);
		WriteLine($"{t} {res[0]} {res[1]}");
	}//for

	}//Main
}//Class
