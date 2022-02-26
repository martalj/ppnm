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
	public static double dot(vec u, vec v){return (u.x*v.x+u.y*v.y+u.z*v.z);}
	public static vec prod(vec u, vec v){return new vec(u.y*v.z-u.z*v.y,u.z*v.x-u.x*v.z,u.x*v.y-u.y*v.x);}
	public static double norm(vec u){return (Abs(u.x)+Abs(u.y)+Abs(u.z));}
}
