using System;
using static System.Math;
using static System.Console;

public static class math{
	public static void sqrt(){
		double sqrt2=Sqrt(2.0);
		Write($"sqrt2 = {sqrt2}\n");
		Write($"sqrt2*sqrt2 = {sqrt2*sqrt2} (should be 2) \n");
	}
	public static void exp(){
		double exppi=Exp(PI);
		Write($"exp(pi) = {exppi}\n");
	}
	public static void pi(){
		double pie=Pow(PI,E);
		Write($"pi^e = {pie}\n");
	}
}
