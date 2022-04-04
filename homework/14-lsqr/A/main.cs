using System;
using static System.Console;
public class main{
public static void Main(){
        var list = new genlist<double[]>();
        char[] delimiters = {' ','\t',','};
        var options = StringSplitOptions.RemoveEmptyEntries;
	var xs = ReadLine();
	var ys = ReadLine();
	var dy = ReadLine();
	xs.Split(delimiters,options);
	ys.Split(delimiters,options);
	dy.Split(delimiters,options);
	WriteLine($"{xs[1]}");
	}//Main function
}//class
