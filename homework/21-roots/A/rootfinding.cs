using System;
using static System.Console;
using static System.Math;

public class roots{
	public static matrix jacobian(Func<vector,vector> f, vector x0){
		int n=f(x0).size;
		int m=x0.size;
		matrix J = new matrix(n,m);
		vector deltax = new vector(x0.size);
		for(int i=0; i<deltax.size; i++){
			deltax[i] = Abs(x0[i])+Pow(2,-26);
		} //for

		for(int j=0; j<n; j++){
			for(int k=0; k<m; k++){
				vector xshift = new vector(deltax.size);
				xshift[k] = deltax[k];
				vector xprime = x0+xshift;
				vector df = f(xprime)-f(x0);
				J[j,k] = df[j]/deltax[k];
			} //for k
		} //for j

		return J;
	} //jacobian

	public static vector newton(Func<vector,vector> f, vector x0, double eps=1e-2){
		do{
			matrix J = jacobian(f,x0);		
			int m=x0.size;
			matrix Q = J.copy();
			matrix R = new matrix(m,m);
			vector Deltax = gs.QRGSsolve(Q,R,-f(x0));
			double lambda = 1;
			do{
				lambda/=2;
			}while(f(x0+lambda*Deltax).norm()>(1-lambda/2)*f(x0).norm() && lambda>1.0/32);
			x0+=lambda*Deltax;
		}while(f(x0).norm()>eps);

		return x0;

	} //newton
} //class
