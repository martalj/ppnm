using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;

class main{
	static void Main(){

	//double b=0.25, c=5;

	Func<double,vector,vector> F = delegate(double t, vector u){  
	return new vector(u[1],-u[0]);
	};

	var xs = new genlist<double>();
	var ys = new genlist<vector>();
	vector y0 = new vector(0,1);
	double start = 0, stop = 2*PI;
	rk.driver(F,start,y0,stop,xs,ys);
	for(double i=0; i<=xlist; i++){
		WriteLine($"{xs[i]} {ys[i][0]} {ys[i][1]}");
	}//for

	}//Main
}//Class
