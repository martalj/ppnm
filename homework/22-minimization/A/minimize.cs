using System;
using static System.Console;
using static System.Math;

public class minimize{
	public static vector gradient(Func<vector,vector> f, vector x){
		vector gx  = new vector(x.size);
		vector x0 = x.copy();
		for(int i=0; i<x.size; i++){
			double dx = Abs(x[i])*Pow(2,-26);
			x[i] += dx;
			gx[i] = (f(x)-f(x0))/dx;
			x[i] -= dx;
		} //for
	return gx;
	} //gradient

	public static vector qnewton(Func<vector,double> f, vector start, double acc = 1e-3){
		matrix B = matrix.id(start.size);
		vector gx = gradient(f,start);
		vector fx = f(x);
		while(gx.norm() > acc){
			vector dx = -B*gx;
			double lambda = 1;
			while(true){
				z = x+lambda*dx;
				fz = f(z);
				if(fz < fx){
					break;
				}
				if(lambda<Pow(2,-26);
					B = matrix.id(start.size);
					break;
				}
				lambda/=2;
			} //while true
			vector s = z-x;
			vector gz = gradient(f,z);
			vector y = gz-gx;
			vector u =s-B*y;
			double uTy = u%y;
			B.update(u,u,u/uTy);
			x=z;
			gx=gz;
			fx=fz;
		} // while > acc
	return x;
	} //qnewton

} //class
