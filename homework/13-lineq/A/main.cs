using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		var rand = new System.Random();
		int n = (int) 4;
		int m = (int) 3;
		var A = new matrix(n,m);
		for (int i=0; i<n; i++){
			for (int j=0; j<m; j++){
				A[i, j] = rand.Next(0,10);
				}
			}
		
		matrix A_sqr = new matrix(n,n);
		for (int i=0; i<n; i++){
			for (int j=0; j<n; j++){
				A_sqr[i, j] = rand.Next(0,10);
				}
			}
		
		
		A.print("A = ");
		matrix R = new matrix(m,m);
		matrix Q = A.copy();
		gs.QRGSdecomp(A,R,Q);
		matrix QT = Q.transpose();
		matrix QTQ = Q.transpose()*Q;
		matrix QR = Q*R;
				
		QTQ.print("Q^T*Q should be = 1:");
		QR.print("Q*R should be = A:");
		R.print("R should be upper triangular:");
		Q.print("Q = ");

		//vector b = new vector(1,3,5,4);
		vector b = new vector(n);
		for(int i=0;i<n;i++){
			b[i] = rand.Next(0,10);
			}
		A_sqr.print("A_sqr = ");
		b.print("b = ");
		matrix R_sqr = new matrix(n,n);
		matrix Q_sqr = A_sqr.copy();
		gs.QRGSdecomp(A_sqr,R_sqr,Q_sqr);
		vector x = gs.QRGSsolve(Q_sqr,R_sqr,b);
		x.print("x = ");
		vector c = A_sqr*x;
		c.print("A_sqr*x should be = b:");
		}

}
