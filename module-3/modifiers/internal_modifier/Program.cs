using System;

namespace internal_Modifier
{

	// Declare class Complex as internal
	internal class Name
	{

		// Member name declared
		// as protected
		string name;
		string thought;

		public void set(string name,string thought)
        	{
			this.name = name;
			this.thought = thought;
        	}
		public void get()
        	{
            		Console.WriteLine("Name is : {0}", name);
            		Console.WriteLine("His Thought is : {0}",thought);
        	}

	}


	class Program
	{

		static void Main(string[] args)
		{
			Name obj1 = new Name();
			obj1.set("Smit", "Capitalism is necessary Evil required by individuals for global economy to thrive");
			obj1.get();
			//output-
			//Name is : Smit
			//His Thought is : Capitalism is necessary Evil required by individuals for global economy to thrive
			//we instantiate internal Name class and call it's method and it works but if we make object of same class in another namespace
			//then it will give compile time error of class name not being found as it is internal 
		}
	}
}

namespace alter
{
	class aternating
    {
		//Name name = new Name();
		//name.get();
		//it shows error;
    }
}
