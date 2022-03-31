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
				A[i, j] = rand.NextDouble();
			}
		}

	matrix R = new matrix(m,m);
	matrix Q = A.copy();
	gs.QRGSdecomp(A,R,Q);
	matrix QT = Q.transpose();
	matrix QTQ = Q.transpose()*Q;
	matrix QR = Q*R;
			
	QT.print("Q^T");
	QTQ.print("Q^T*Q");
	QR.print("Q*R");
	R.print("R");
	Q.print("Q");

	vector b = new vector(1,3,5,4);
	//for(int i=0;i<n;i++){
	//	b[i] = rand.NextDouble();
	//	}
	b.print("b");
	vector x = gs.QRGSsolve(Q,R,b);
	x.print("x");
	vector c = A*x;
	c.print("A*x");
	}

}
