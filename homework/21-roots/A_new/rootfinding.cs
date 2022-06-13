using System;
using static System.Console;
using static System.Math;

public class roots{
	public static vector newton(Func<vector,vector>f, vector x0, double eps=1e-2){
		int n = x0.size;
		matrix J = new matrix(n,n);
		vector dx = new vector(x0.size);
		for(int i=0;i<x0.size;i++){
			dx[i] = x0[i]*Pow(2,-12);
			vector df = f(dx)-f(x0);
			for(int j=0;j<n;j++){
				J[j,i] = df[j]/dx[i];
			}
		}

		J.print("J = ");
		matrix R = new matrix(n,n);
		vector b = new vector(n);
		matrix J_inv = new matrix(n,n);
		matrix Q = J.copy();
		gs.QRGSdecomp(J,R,Q);
		for(int k=0;k<n;k++){
			b[k] = 1;
			J_inv[k] = gs.QRGSsolve(Q,R,b);
			b[k] = 0;
		}
		J_inv.print("J_inv = ");

		while(f(x0).norm()>eps){
			vector Deltax = -J_inv*f(x0);
			double lambda = 1;
			while(f(x0+lambda*Deltax).norm()>(1-lambda/2)*f(x0).norm() && lambda>1.0/32){
				lambda/=2;
			}
		x0 += lambda*Deltax;
		} //while
	return x0;

	}//newton
} //class
