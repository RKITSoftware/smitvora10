using System;

namespace private_modifier
{
	class Name
	{

		// Member name declared
		// as protected
		private string name;

		public void setName(string name)
		{
			this.name = name;
		}
		public string getName()
		{
			return name;
		}
	}

	// class MyName inherits the
	// class Name
	class MyName : Name
	{

        // Members of MyName can access 'Name'
		//public void show()
		//{
			//Console.WriteLine("Name is :{0}",name);
		//}
		// this shows an error due to accessibility of private string name
		

	}

	class Program
    {
        static void Main(string[] args)
        {
			Name name = new Name();
			//the only way we can assign and private objects outside the class is by using properties as it cannot be called by instantiation and also by inheritance
			name.setName("Smit");
            Console.WriteLine("Name is:"+ name.getName());
			//output -Name is:Smit

		}
    }
}
