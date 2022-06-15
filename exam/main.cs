using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		var x = new double[10];
		var y = new double[10];
		for(int i=0;i<x.Length;i++){
			x[i] = i;
			y[i] = i*i;
			WriteLine($"{x[i]} {y[i]}");
		}
		
		WriteLine();
		WriteLine();

		double[] p;
		p = subspline.inner(x,y);
		for(int j=0;j<p.Length;j++){
			WriteLine($"{j} {p[j]}");
		}

	}//Main
}//class
