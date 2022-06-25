using System;
using static System.Console;
using static System.Math;

public class minimize{
	public static vector gradient(Func<vector,double> f, vector x){
		vector gx  = new vector(x.size);
		vector x0 = x.copy();
		for(int i=0; i<x.size; i++){
			double dx = Abs(x[i])*Pow(2,-26);
			if(Abs(x[i])<Sqrt(Pow(2,-26))){
				dx = Pow(2,-26);
			}
			
			x0[i] += dx;
			gx[i] = (f(x0)-f(x))/dx;
		} //for
	return gx;
	} //gradient

	public static (vector,int) qnewton(Func<vector,double> f, vector x, double acc = 1e-3){
		matrix B = matrix.id(x.size);
		vector gx = gradient(f,x);
		double fx = f(x);
		int steps = 100000;
		int s = 0;
		vector z;
		double fz;
		while(s < steps){
			s++;
			vector dx = -B*gx;
			double lambda = 1;
			while(true){
				s++;
				z = x+lambda*dx;
				fz = f(z);
				if(fz < fx){
					break;
				}
				if(lambda<Pow(2,-26)){
					B.set_identity();
					break;
				}
				lambda/=2;
			} //while true
			vector gz = gradient(f,z);
			vector y = gz-gx;
			vector u =lambda*dx-B*y;
			double uTy = u%y;
			if(Abs(uTy)>1e-6){
				B.update(u,u,1/uTy);
			}
			x=z;
			gx=gz;
			fx=fz;
			if(Abs(gx.norm())<acc){break;}
		} // while steps
	return (x,s);
	} //qnewton

} //class
