using static System.Console;
using static System.Math;

class main{
	public static void Main(){
		var rnd=new System.Random();
		int n=5,N=10*n;
		var x=new double[n];
		var y=new double[n];
		for(int i=0;i<n;i++){
			x[i]=i;
			y[i]=rnd.NextDouble()*5;
			WriteLine($"{x[i]} {y[i]}");
			}

		WriteLine();
		WriteLine();

		for(int j=0;j<N;j++){
			double z=x[0]+j*(x[n-1]-x[0])/(N-1);
			WriteLine($"{z} {lint.linterp(x,y,z)}");
			}
	}
}
