using System;
using static System.Console;
using static System.Math;

class main{
	static void Main(){
		var rand = new System.Random();
		int n = (int) 4;
		var A = new matrix(n,n);
		for (int i=0; i<n; i++){
			for (int j=i; j<n; j++){
				A[i, j] = rand.Next(0,10);
				A[j,i] = A[i,j];
				}
			}
		
		A.print("A=");
		
		(matrix D, matrix V) = evd.jacobi_cyclic(A);
		D.print("D=");
		V.print("V=");
		
		matrix VtAV = V.T*A*V;
		matrix VDVt = V*D*V.T;
		matrix VtV = V.T*V;
		matrix VVt = V*V.T;
		VtAV.print("V^T*A*V should be = D: ");
		VDVt.print("V*D*V^T should be = A: ");
		VtV.print("V^T*V should be = 1:");
		VVt.print("V*V^T should be = 1:");

		} //Main

} //Class
