using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		var rand = new System.Random();
		int n = (int) 10;
		int m = (int) 5;
		var A = new matrix(n,m);
		for (int i=0; i<n; i++){
			for (int j=0; j<m; j++){
				A[i, j] = rand.NextDouble();
			}
		}
	matrix R = new matrix(m,m);
	matrix Q = gs.QRGSdecomp(A,R);
	matrix QTQ = Q.transpose()*Q;
	matrix QR = Q*R;
	
	QTQ.print("Q^T*Q");
	QR.print("Q*R");
	}

}
