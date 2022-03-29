using static System.Math;
using static System.Console;

public class main{
	static double lngamma(double x){
	///log gamma function (from wikipedia, based on Stirlings approximation)
		double lngamma=x*Log(x)-x-1/2*Log(x)+1/2*Log(2*PI)+1/(12*x)-1/(360*x*x*x);
		return lngamma;
	}

public static void Main(){
	for(double x=0.1;x<=10;x+=1.0/32)
		WriteLine($"{x} {lngamma(x)}");
	}

}
