using static System.Console;

public class main{
	static void Main(){
		vec u = new vec(2,3,4);
		vec v = new vec(4,5,6);
		WriteLine($"{vec.approx(u,v)}");
	}
}
