using static System.Console;
using static System.Math;

class main{
	public static void Main(){
	//Random numbers
		var rnd=new System.Random();
		int n=10;
		var x=new double[n];
		var y=new double[n];
		for(int i=0;i<n;i++){
			x[i]=i;
			y[i]=rnd.NextDouble()*5;
			WriteLine($"{x[i]} {y[i]}");
			}

		WriteLine();
		WriteLine();

		qspline spline_Rand = new qspline(x,y);
		for(double l=1; l<x[x.Length-1]; l+=0.1){
			double sol = spline_Rand.eval(l);
			WriteLine($"{l} {sol} {spline_Rand.derivative(l)} {spline_Rand.integral(l)}");

		}

		WriteLine();
		WriteLine();

	//x^2
		var x2=new double[n];
		var y2=new double[n];
		for(int k=1;k<n;k++){
			x2[k]=k;
			y2[k]=k*k;
			WriteLine($"{x2[k]} {y2[k]}");
			}

		WriteLine();
		WriteLine();

		qspline spline_x2 = new qspline(x2,y2);
		for(double l=1; l<x2[x2.Length-1]; l+=0.1){
			double sol = spline_x2.eval(l);
			WriteLine($"{l} {sol} {spline_x2.derivative(l)} {spline_x2.integral(l)}");
		}

	}
}
