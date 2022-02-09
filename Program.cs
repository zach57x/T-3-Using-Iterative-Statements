// Author: Zachary Brand
// Date: 2/8/2022
// Assignment: T-3 Using Iterative Statements
// Desc: Conversion Table from CAD to USD

class Program
{
	static void Main(string[] args)
	{
		// Ask the user to input a CAD value
		Console.WriteLine("What CAD value would you like to convert to USD?");

		// Use try catch logic to confirm valid input
		try
		{
			// User inputs CAD amount they wish to convert
			string inputdata = Console.ReadLine();
			int cadvalue = int.Parse(inputdata);
			if (cadvalue < 0 || cadvalue > 200)
			{
				// If statement to determine that CAD value is in the accepted range
				Console.WriteLine("Please enter a value between 0 CAD and 200 CAD and run again");
				Console.WriteLine("Press any key to exit the program");
				Console.ReadKey(true);
				Environment.Exit(0);
			}
			if (cadvalue > 0 || cadvalue < 200)
			{
				// User inputs amount they wish to increment the table by
				Console.WriteLine("Please enter a value you wish to increment the table by:");
				string inputdata1 = Console.ReadLine();
				int incrementvalue = int.Parse(inputdata1);
				if (incrementvalue < 5 || incrementvalue > 25)
				{
					// If statement to determine that increment value is in accepted range
					Console.WriteLine("Please enter an increment value between 5 and 25  and run again");
					Console.WriteLine("Press any key to exit the program");
					Console.ReadKey(true);
				}
				else
				{
					// While loop to create the table and stop at 200
					while (cadvalue <= 200)
					{
						double usdvalue = 0.792367;
						Console.WriteLine("CAD value: " + cadvalue + " USD value: " + cadvalue * usdvalue);
						cadvalue = cadvalue + incrementvalue;
					}
				}
			}
		}
		catch
		{
			// End of catch for invalid input
			Console.WriteLine("Please enter a value between 0 CAD and 200 CAD and run again");
			Console.WriteLine("Press any key to exit the program");
			Console.ReadKey(true);
		}	
	}
}
