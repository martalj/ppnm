using static System.Console;

public class main{
	static void Main(){
		vec u= new vec(100,200,300);
		u.print("u = ");
		vec v= new vec(1,2,3);
		v.print("v = ");
		(u+v).print("u+v = ");
		(u-v).print("u-v = ");
		(4*v).print("4*v = ");
		var w = v*4;
		w.print("v*4 = ");
	}
}
