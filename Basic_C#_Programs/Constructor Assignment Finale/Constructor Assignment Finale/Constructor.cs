using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{

	// Chain two constructors together

	public Class1(string myNum2): this(15)
	{
		myNum2 = "Jack";

		return myNum2;


	
	}


	public Class1( int myNum)
    {
		 myNum = 15;

		return myNum;


    }
}
