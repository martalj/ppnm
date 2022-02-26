using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
	System.Func<double,double> f = delegate(double x){return Sin(x);};
	for(double k=1;k<=3;k++)table.make_table(f,1*k,5*k,1*k);
	}

}
