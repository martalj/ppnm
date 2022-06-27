using static System.Console;
using static System.Math;

public class main{
	static void Main(){
		vec u = new vec(2,3,4);
		vec v = new vec(4,5,6);
		u.print("u = ");
		v.print("v = ");
		WriteLine($"Are u and v approximately the same?: {vec.approx(u,v)}");

		vec u2 = new vec(1e-10,1e-10,2e-10);
		vec v2 = new vec(2e-10,2e-10,6e-10);
		u2.print("u = ");
		v2.print("v = ");
		WriteLine($"Are u and v approximately the same?: {vec.approx(u2,v2)}");

		vec u3 = new vec(Sqrt(1),Sqrt(2),Sqrt(5));
		vec v3 = new vec(Sqrt(2),Sqrt(1),Sqrt(5));
		u3.print("u = ");
		v3.print("v = ");
		WriteLine($"Are u and v approximately the same?: {vec.approx(u3,v3)}");

		

	}
}
