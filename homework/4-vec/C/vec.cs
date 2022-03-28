using System;
using static System.Console;
using static System.Math;

public class vec{
	public double x,y,z;

	//constructors:
	public vec(){x=y=z=0;}
	public vec(double a, double b, double c){x=a;y=b;z=c;}

	//methods:
	public void print(string s){Write(s);WriteLine($"{x} {y} {z}");}
	public void print(){this.print("");}

	static bool approx(double a,double b,double tau=1e-9,double eps=1e-9){
		if(Abs(a-b)<tau)return true;
		if(Abs(a-b)/(Abs(a)+Abs(b))<eps)return true;
		return false;
		}

	public bool approx(vec other){
		if(!approx(this.x,other.x))return false;
		if(!approx(this.y,other.y))return false;
		if(!approx(this.z,other.z))return false;
		return true;
		}

	public static bool approx(vec u, vec v){ return u.approx(v); }

}
