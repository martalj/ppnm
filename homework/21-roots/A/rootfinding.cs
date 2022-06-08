using System;
using static System.Console;
using static System.Math;

public class roots{
	public static vector newton(Func<vector,vector> f, vector x0, double eps=1e-2){
		int n=f(x0).size;
		int m=x0.size;
		matrix J = new matrix(n,m);
		vector deltax = new vector(x0.size);
		for(int i=0;i<deltax.size;i++){
			deltax[i] = Abs(x0[i])+Pow(2,-26);
		} //for

		for(int j=0;j<n;j++){
			for(int k=0; k<m; k++){
				vector df = f(x0+deltax)-f(x0);
				J[j,k] = df[j]/deltax[k];
			} //for k
		} //for j
		while(f(x0).norm()>eps){
			matrix Q = J.copy();
			matrix R = new matrix(m,m);
			gs.QRGSdecomp(J,R,Q);
			vector Deltax = gs.QRGSsolve(Q,R,f(x0));
			double lambda = 1;
			while(f(x0+lambda*Deltax).norm()>(1-lambda/2)*f(x0).norm() && lambda<1.0/32){
				lambda/=2;
			} //while
			x0+=lambda*Deltax;
		} //while
		return x0;
	} //newton
} //class
