using System;
using static System.Console;
using static System.Math;

public class maxmin{
	public static void max(){
		int i=1; while(i+1>i) i++;
		WriteLine($"My max int = {i} and int.MaxValue = {int.MaxValue}");
	}

	public static void min(){
		int i=-1; while(i-1<i) i--;
		WriteLine($"My min int = {i} and int.MinValue = {int.MinValue}");
	}
}


public class machineepsilon{
	public static void epsdouble(){
		double x=1; while(1+x!=1) {x/=2;} x*=2;
		WriteLine($"My value x = {x}, the machine value = {System.Math.Pow(2,-52)}");
	}

	public static void epsfloat(){
		float y=1F; while((float)(1F+y) != 1F){y/=2F;} y*=2F;
		WriteLine($"My value y = {y}, the machine value = {System.Math.Pow(2,-23)}");
	}

	public static void epstiny(){
		int n=(int)1e6;
		double epsilon=Pow(2,-52);
		double tiny=epsilon/2;
		double sumA=0, sumB=0;

		sumA+=1; for(int i=0;i<n;i++){sumA+=tiny;}
		WriteLine($"sumA-1 = {sumA-1:e} should be {n*tiny:e}");

		for(int i=0;i<n;i++){sumB+=tiny;} sumB+=1;
		WriteLine($"sumB-1 = {sumB-1:e} should be {n*tiny:e}");
	}
}

public class boolean{
	public static void approx(double a, double b, double tau=1e-9, double epsilon=1e-9){
	WriteLine($"Checking if numbers {a} and {b} are equal:");
	if (Abs(a-b)<tau){WriteLine("absolute true");}
	else if (Abs(a-b)/(Abs(a)+Abs(b))< epsilon){WriteLine("relative true");}
	else {WriteLine("false");}	
	}
}
