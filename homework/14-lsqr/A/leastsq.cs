'using static System.Math;
using static System.Console;

public class leastsquares{
	double f(int i, double z){
		if(i==0) return 1;
		if(i==1) return z;
		else return WriteLine("Not a number");
		}

	var fs = new Func<double,double>[]{
		z=>1.0, z=>z, z=>Log(z);
		}
	
	public static vector lsfit(Func<double, double> fs, double[] x, double[] y, double[] dy){
		int n = x.size, m = fs.Length;
		var A = new matrix(n,m);
		var b = new vector(n);
		for(int i=0;i<n;i++){
			b[i]=y[i]/dy[i];
			for(int k=0;k<m;k++){
				A[i,k]=fs[k](x[i])/dy[i];
				}
			}
		matrix Q = A.copy();
		matrix R = new matrix(m,m);
		gs.QRGSdecomp(A,R,Q);
		var c = gs.QRGS(Q,R,b);
		}	
	return c;
}
