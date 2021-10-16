// C# Program to show the use of
// protected Access Modifier
using System;

namespace protected_modifier
{

	class Name
	{

		// Member name declared
		// as protected
		protected string name = "Smit";

		public Name()
		{
			name = "Smit";
		}
	}

	// class MyName inherits the
	// class Name
	class MyName : Name
	{

		// Members of MyName can access 'Name'
		public string getName()
		{
			return name;
		}
	}

	class Program
	{

		static void Main(string[] args)
		{
			Name obj1 = new Name();
			MyName obj2 = new MyName();

			// Displaying the value of name
			Console.WriteLine("Name is : {0}", obj2.getName());
			//if we try to access name directly of obj1 of class Name then we get a compile time error as it is inaccessible but we 			//can access it through obj2
			//where class "Name" is parent.

			//output - Name is : Smit
		}
	}
}
