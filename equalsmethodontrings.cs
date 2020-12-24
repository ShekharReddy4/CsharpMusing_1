using System;
using System.Text;

class musingsofcsharp
{
	// change this method to Main(string[] args) before execution
	public static void Main2()
	{
		string s = "hello";
		string s2 = "hello";
    Console.WriteLine(s.Equals(s2));
		Console.WriteLine(s == s2);
		Console.WriteLine("ReferenceEquals method : "+ Object.ReferenceEquals(s, s2));
		Bus b1 = new Bus();
		Bus b2 = new Bus();
		Bus.sqno = 12;
		Console.WriteLine(Bus.sqno);

		// for string builder bcs it is a reference type
		var sb1 = new StringBuilder("Blue");
		var sb2 = new StringBuilder("Blue");
    Console.WriteLine(sb1 == sb2);//false

		var d1 = DateTime.Now.Date;
		var d2 = DateTime.Now.Date;
		Console.WriteLine(d1 == d2);//true
	}
}