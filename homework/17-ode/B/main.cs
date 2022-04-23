using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;

class main{
	static void Main(){
	
	var xs = new genlist<double>();
	var ys = new genlist<vector>();	
	double b = 0.25, c = 5.0;

	Func<double, vector, vector> pend = delegate(double t, vector y){
	return new vector(y[1],-b*y[1]-c*Sin(y[0]));
	};

	vector init = new vector(PI-0.1,0);
	double a = 0, end = 10;
	rk.driver(pend,a,init,end,xs,ys);
	for(int i=0;i<=xs.size;i++){
		WriteLine($"{xs} {ys}");
	}//for

	}//Main
}//Class
