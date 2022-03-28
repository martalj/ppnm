using static System.Console;

public class main{
	static void Main(){
		vec u= new vec(2,3,4);
		u.print("u = ");
		vec v= new vec(5,6,7);
		v.print("v = ");
		(vec.prod(u,v)).print("u cross prod v = ");
		WriteLine($"u dot v = {vec.dot(u,v)}");
		WriteLine($"norm(u) = {vec.norm(u)}");
		WriteLine(u);
	}
}
