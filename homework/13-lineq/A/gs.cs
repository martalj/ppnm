using static System.Console;
using static System.Math;

public class gs{
	public static matrix QRGSdecomp(matrix A, matrix R){
		int m = A.size2;
		matrix Q = new matrix(A.size1,m);
		for(int i=0;i<m;i++){
			R[i,i]=A[i].norm();
			Q[i] = A[i]/R[i,i];
			for(int j=i+1;j<m;j++){
				R[i,j] = Q[i].dot(A[j]);
				A[j] -= R[i,j]*Q[i];
				}
		}	
		A.print("A"); R.print("R"); Q.print("Q");
	return Q;
	}
}
