using static System.Console;
using static System.Math;

public class gs{
	public static matrix QRGSdecomp(matrix A, matrix R){
		int m = A.size2;
		matrix Q = new matrix(A.size1,m);
		matrix v = A.copy();
		for(int i=0;i<m;i++){
			R[i,i]=v[i].norm();
			Q[i] = v[i]/R[i,i];
			for(int j=i+1;j<m;j++){
				R[i,j] = Q[i].dot(A[j]);
				v[j] -= R[i,j]*Q[i];
				}
		}	
		A.print("A"); R.print("R"); Q.print("Q");
	return Q;
	}

	public static vector QRGSsolve(matrix Q, matrix R, vector b){
		matrix QT = Q.transpose();
		vector x = QT*b;
		for(int n=1;n<x.size;n++){
			x[n-1] = (x[n-1] - R[n-1,n])/R[n-1,1];
		}
	return x;
	}
}
