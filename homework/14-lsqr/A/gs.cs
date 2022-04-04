using static System.Console;
using static System.Math;

public class gs{
	public static void QRGSdecomp(matrix A, matrix R, matrix Q){
		int m = A.size2;
		for(int i=0;i<m;i++){
			R[i,i]=Q[i].norm();
			Q[i] = Q[i]/R[i,i];
			for(int j=i+1;j<m;j++){
				R[i,j] = Q[i].dot(Q[j]);
				Q[j] -= R[i,j]*Q[i];
				}
			}	
	}

	public static vector QRGSsolve(matrix Q, matrix R, vector b){
		vector x = Q.T*b;
		for(int i=x.size-1; i>=0; i--){
			double sum=0;
			for(int n=i+1; n<x.size; n++){
				sum += R[i,n]*x[n];
				}
			x[i] = (x[i]-sum)/R[i,i];
			}
	return x;
	}

	public static matrix QRGSinverse(matrix Q, matrix R){
		matrix A = Q*R;
		vector b = new vector(A.size1);
		matrix B = new matrix(A.size1,A.size2);
		for(int i=0; i<A.size1; i++){
			b[i] = 1;
			B[i] = QRGSsolve(Q,R,b);
			b[i] = 0;
			}
	return B;
	}
}
