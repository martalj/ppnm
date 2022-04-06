using static System.Math;
using static System.Console;
using System;

public class leastsquares{	
	public static vector lsfit(Func<double, double>[] fs, double[] x, double[] y, double[] dy){
		int n = x.Length, m = fs.Length;
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
		var c = gs.QRGSsolve(Q,R,b);
		
		return c;
		}
}
