using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		var rand = new System.Random();
		int n = (int) 4;
		var A = new matrix(n,n);
		for (int i=0; i<n; i++){
			for (int j=0; j<n; j++){
				A[i, j] = rand.Next(0,10);
				}
			}

		A.print("A");
		matrix Q = A.copy();
		matrix R = new matrix(A.size1,A.size2);
		gs.QRGSdecomp(A,R,Q);
		matrix B = gs.QRGSinverse(Q, R);
		B.print("B");
		matrix AA_inv = A*B;
		AA_inv.print("A*B should be = I:");
		}

}
