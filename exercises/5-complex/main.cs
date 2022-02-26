using System;
using static System.Math;
using static System.Console;

class main{
	static void Main(){
		complex z = new complex(-1,0);
		WriteLine($"sqrt(-1) = {cmath.sqrt(z)}, should be i");
		WriteLine($"sqrt(i) = {cmath.sqrt(cmath.I)}, should be 0.707+0.707i");
		WriteLine($"exp(i) = {cmath.exp(cmath.I)}, should be 0.54+0.84i");
		WriteLine($"exp(i*pi) = {cmath.exp(cmath.I*PI)}, should be -1");
		WriteLine($"pow(i,i) = {cmath.pow(cmath.I,cmath.I)}, should be 0.208");
		WriteLine($"log(i) = {cmath.log(cmath.I)}, should be 0.682i");
		WriteLine($"sin(i*pi) = {cmath.sin(cmath.I*PI)}, should be 11.549i");
		
	}
}
