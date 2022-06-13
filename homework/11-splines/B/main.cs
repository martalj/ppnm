using static System.Console;
using static System.Math;

class main{
	public static void Main(){
	//Random numbers
		var rnd=new System.Random();
		int n=10,N=10*n;
		var x=new double[n];
		var y=new double[n];
		for(int i=0;i<n;i++){
			x[i]=i;
			y[i]=rnd.NextDouble()*5;
			WriteLine($"{x[i]} {y[i]}");
			}

		WriteLine();
		WriteLine();

		for(double j=0;j<N-1;j+=0.1){
			double z=x[0]+j*(x[n-1]-x[0])/(N-1);
			WriteLine($"{z} {lint.linterp(x,y,z)} {lint.linterpInteg(x,y,z)} ");
		}

		WriteLine();
		WriteLine();

	//x^2
		var x2=new double[n];
		var y2=new double[n];
		for(int k=0;k<n;k++){
			x2[k]=k;
			y2[k]=k*k;
			WriteLine($"{x2[k]} {y2[k]}");
			}

		WriteLine();
		WriteLine();

		for(double l=0; l<N-1; l+=0.1){
			double z2=x2[0]+l*(x2[n-1]-x2[0])/(N-1);
			WriteLine($"{z2} {lint.linterp(x2,y2,z2)} {lint.linterpInteg(x2,y2,z2)} ");
		}

	}
}
