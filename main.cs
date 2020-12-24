using System;
using System.Text;

public class BaseClass
{
	public BaseClass()
	{
		Console.WriteLine("Baseclass default constr");
	}
	public BaseClass(int i)
	{
		Console.WriteLine("Baseclass overloaded");
	}
	static BaseClass()
	{
		Console.WriteLine("Baseclass static default constr");
	}

	// the following will not be compiled because static ctor must be parameterless
	// static BaseClass(int i)
	// {
	// 	Console.WriteLine("Baseclass static overloaded constr");
	// }
}

public class DerivedClass : BaseClass
{
	public DerivedClass():this(3)
	{
		
		Console.WriteLine("DerivedClass default constr");
		
	}
	public DerivedClass(int i) 
	{
		Console.WriteLine("DerivedClass overloaded constr");
	}
	static DerivedClass()
	{
		Console.WriteLine("DerivedClass static default constr");
	}
}
class MainClass {
  public static void Main (string[] args) {
    
		DerivedClass der = new DerivedClass();
		// DerivedClass static default constr
		// Baseclass static default constr
		// Baseclass default constr
		// DerivedClass overloaded constr
		// DerivedClass default constr


		BaseClass bder = new DerivedClass();
		// Baseclass default constr
		// DerivedClass overloaded constr
		// DerivedClass default constr

		BaseClass bderr = new DerivedClass(2);
		// Baseclass default constr
		// DerivedClass overloaded constr
  }
}