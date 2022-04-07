using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;

class main{
	static void Main(){

	//double b=0.25, c=5;

	Func<double,vector,vector> F = delegate(double t, vector u){
		double v = u[1];  
	return new vector(-u);
	};

	vector y0 = new vector(1,1);
	double start = 0, stop = 10;
	vector res = rk.driver(F,start,y0,stop);

	res.print("res = ");

	}//Main
}//Class
