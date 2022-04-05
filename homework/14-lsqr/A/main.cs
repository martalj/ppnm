using System;
using static System.Console;
using static System.Math;

public class main{
	public static void Main(){
	        var list = new genlist<double[]>();
	        char[] delimiters = {' ','\t',','};
	        var options = StringSplitOptions.RemoveEmptyEntries;
		for(string line = ReadLine();line != null; line = ReadLine()){
			var data = line.Split(delimiters, options);
			int n = data.Length;
			var numbers = new double[n];
			for(int i=0;i<n;i++){
				numbers[i]=double.Parse(data[i]);
				}
			list.push(numbers);
			}
		var xs = list.data[0];
		var ys = list.data[1];
		var dy = list.data[2];
		for(int i=0;i<xs.Length;i++){
			WriteLine($"{xs[i]} {ys[i]} {dy[i]}");
			}		

		var fs = new Func<double,double>[] {z=>1.0, z=>z, z=>z*z};

		vector c = leastsquares.lsfit(fs,xs,ys,dy);
		
		WriteLine();		
		WriteLine();

		for(double i = 0;i<15;i+=0.2){
			WriteLine($"{i} {c[0]+i*c[1]+i*i*c[2]}");			
			}
		
	}//Main function
}//class
