using System;
using static System.Console;

public class main{
	public static void Main(){
	        var list = new genlist<int>();
		list.push(2);
		list.push(67);
		list.push(32478);
		list.push(392);
		list.push(123);
		WriteLine("Initial list:");
		for(int i = 0;i<list.size;i++){
			Write($"{list.data[i]} ");
		}
		WriteLine();

		WriteLine("Removing element number 3:");
		list.remove(3);
		for(int i = 0;i<list.size;i++){
			Write($"{list.data[i]} ");
		}
		WriteLine();

		WriteLine("Clearing the list:");
		list.clear();
		for(int i = 0;i<list.size;i++){
			Write($"C{list.data[i]} ");
		}
		WriteLine();
	}
}
