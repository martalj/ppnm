using static System.Console;

public class main{
	static void Main(){
		vec u= new vec(100,200,300);
		u.print("u = ");
		vec v= new vec(1,2,3);
		v.print("v = ");
		(vec.prod(u,v)).print("u cross prod v = ");
		WriteLine($"u dot c = {vec.dot(u,v)}");
		WriteLine($"norm(u) = {vec.norm(u)}");
	}
}
