// Namespace Declaration
using System;


    public class Pragim
    {
        public static void Main()
        {
            // Write to console
            //Part 1 - C# Tutorial - Introduction
            Console.WriteLine("Welcome to PRAGIM Technologies!");
            //-------------------------------------------------------------------------------------------------------------------------
            //Part 2 - C# Tutorial - Reading and writing to a console
            // Prompt the user for his name
            Console.WriteLine("Please enter your name");
            // Read the name from console
            string UserName = Console.ReadLine();
            // Concatenate name with hello word and print
            Console.WriteLine("Hello " + UserName);

            //Placeholder syntax to print name with hello word 
            //Console.WriteLine("Hello {0}", UserName);

            //-------------------------------------------------------------------------------------------------------------------------
            //Part 3- C# Tutorial - Strings 
            // Displaying double quotes in c#
            string Name = "\"Pragim\"";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "One\nTwo\nThree";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "c:\\Pragim\\DotNet\\Training\\Csharp";
            Console.WriteLine(Name);

            // C# verbatim literal
            Name = @"c:\Pragim\DotNet\Training\Csharp";
            Console.WriteLine(Name);

            //-------------------------------------------------------------------------------------------------------------------------
            //Part 4- C# Tutorial - Operratoes

            // Assignment Operator example
            // Single = is the assignment operator
            int i = 10;
            bool b = true;

            // For dividing 2 numbers we can use either
            // % or / operators
            int numerator = 10;
            int denominator = 2;

            // Arithmentic operator / returns quotient
            int quotient = numerator / denominator;
            Console.WriteLine("Quotient = {0}", quotient);

            // Arithmentic operator % returns remainder
            int remainder = numerator % denominator;
            Console.WriteLine("Remainder = {0}", remainder);

            // To compare if 2 numbers are
            // equal use comparison operator ==
            int number = 10;
            if (number == 10)
            {
                Console.WriteLine("Number is equal to 10");
            }

            // To compare if 2 numbers are not
            // equal use comparison operator !=
            if (number != 5)
            {
                Console.WriteLine("Number is not equal to 5");
            }

            // When && operator is used all the conditions must
            // be true for the code in the "if" block to be executed
            int number1 = 10;
            int number2 = 20;

            if (number1 == 10 && number2 == 20)
            {
                Console.WriteLine("Both conditions are true");
            }

            // When || operator is used the code in the "if" block
            // is excuted if any one of the condition is true
            number1 = 10;
            number2 = 21;

            if (number1 == 10 || number2 == 20)
            {
                Console.WriteLine("Atleast one of the condition is true");
            }

            int numberT = 10;

            // Ternary operator example
            bool isNumber10 = numberT == 10 ? true : false;

            Console.WriteLine("Number == 10 is {0}", isNumber10);

            // Coalsaing operator - it checks for null opeator 
            string numberCoalsaing = "";

            // Coalsaing operator example
            string isNumbernumberCoalsaing = numberCoalsaing ?? null;
            Console.WriteLine("Number is", isNumbernumberCoalsaing);
            //-----------------------------------------------------------------------------------------------------
            // Nullable types

            int AvailableTickets;
            int? TicketsOnSale = null;

            if (TicketsOnSale == null)
            {
                AvailableTickets = 0;
            }
            else
            {
                AvailableTickets = (int)TicketsOnSale;
            }

            Console.WriteLine("Available Tickets={0}", AvailableTickets);
            //----------------------------------------------------------------------------------------------------------
            // Using Coalsing Operator
            int AvailableTickets1;
            int? TicketsOnSale1 = null;

            //Using null coalesce operator ??
            AvailableTickets1 = TicketsOnSale1 ?? 0;

            Console.WriteLine("Available Tickets={0}", AvailableTickets1);

            //-------------------------------------------------------------------------------------------------------------
            //Part 7 - C# Tutorial - Datatype conversions
            float f = 100.25F;

            // Cannot implicitly convert float to int.
            // Fractional part will be lost. Float is a
            // bigger datatype than int, so there is
            // also a possiblity of overflow exception
            // int i = f;

            // Use explicit conversion using cast () operator
            int i1 = (int)f;
            Console.WriteLine(i1);

            // OR use Convert class
            int i2 = Convert.ToInt32(f);

            Console.WriteLine(i2);

            //--------------------------------------------------------------------------------------------------------------
            // Arrays
            // Initialize and assign values in different lines
            int[] EvenNumbers = new int[3];
            EvenNumbers[0] = 0;
            EvenNumbers[1] = 2;
            EvenNumbers[2] = 4;

            // Initialize and assign values in the same line
            int[] OddNumbers = { 1, 3, 5 };

            Console.WriteLine("Printing EVEN Numbers");

            // Retrieve and print even numbers from the array
            for (int i3 = 0; i3 < EvenNumbers.Length; i3++)
            {
                Console.WriteLine(EvenNumbers[i3]);
            }

            Console.WriteLine("Printing ODD Numbers");

            // Retrieve and print odd numbers from the array
            for (int i4 = 0; i4 < OddNumbers.Length; i4++)
            {
                Console.WriteLine(OddNumbers[i4]);
            }

            //------------------------------------------------------------------------------------------------------------------
            // if/else
            Console.WriteLine("Enter Your Number");
            int Usernumber = int.Parse(Console.ReadLine());
            if (Usernumber == 1)
            {
                Console.WriteLine("Dear User Your Number is 1");
            }

            else if (Usernumber == 2)
            {
                Console.WriteLine("Dear User Your Number is 2");
            }
            else if (Usernumber == 3)
            {
                Console.WriteLine("Dear User Your Number is 3");
            }
            else if (Usernumber == 4)
            {
                Console.WriteLine("Dear User Your Number is 4");
            }
            else if (Usernumber == 5)
            {
                Console.WriteLine("Dear User Your Number is 5");
            }
            else
            {
                Console.WriteLine("Dear User Your Number is Not Between 1-5");
            }

            //----------------- Loops
            int loop = 1;
            while (loop <= 3)
            {
                int j = 1;
                while (j <= 3)
                {
                    Console.WriteLine("This is portion of loop - while");
                    Console.WriteLine(loop + " " + j);
                    j++;
                }
                loop++;
            }

            //=------------------------------------------------------------------------------------- do while loop
            int idw = 1;

            do
            {
                Console.WriteLine("This is portion of do while--");
                int jdw = 1;

                do
                {
                    Console.WriteLine(idw + " " + jdw);
                    jdw++;
                } while (jdw <= 3);
                idw++;
            } while (idw <= 3);

            //---------------------------------------------------------------- for loop
            for (int ifor = 1; ifor <= 3; ifor++)
            {
                Console.WriteLine("This is inside of for loop!!");
                for (int jfor = 1; jfor <= 3; jfor++)
                {
                    Console.WriteLine(ifor + " " + jfor);
                }
            }

            //----------------------------- Continue
            for (int icon = 1; icon <= 10; icon++)
            {
                if (icon == 5)
                {
                    Console.WriteLine("This is going to continue from 5 and will skip code below it");
                    continue;
                }
                Console.WriteLine(icon);
            }

            //---------------------------------------------------------------  Classes
            Circle c1 = new Circle(5);
            float Area = c1.ClacArea();
            Console.WriteLine("Area {0}", Area);

            Circle c2 = new Circle(6);
            float Area2 = c2.ClacArea();
            Console.WriteLine("Area {0}", Area2);


        // Cnstructor inheritance
        Car car = new Car("Toyota");

        Console.WriteLine("Car Model: {0}, Speed: {1}", car.model, car.speed);

        // method hiding
        // Creating the object of the derived class 
        My_Member obj = new My_Member();

        // Access the method of derived class 
        obj.member();

        Console.ReadKey();
        //====================================================================================================================
    }

        public class Circle
        {
            static float _PI = 3.141f;
            private readonly int _Radius;

            public Circle(int Radius)
            {
                this._Radius = Radius;
            }

            public float ClacArea()
            {
                return Circle._PI * this._Radius * this._Radius;

            }

            //Destruror 
            ~Circle()
            {
                //Clean up Code
            }
        }

        // constructor level inheritance
       public class Vehicle
        {
            public int speed;

            public Vehicle() { }  
            public Vehicle(int speed)
            {
                this.speed = speed;
            }
        }

       public class Car : Vehicle
        {
            public string model;
            private readonly int _speed;

            public Car(string model) : base()
            {
                this.model = model;
                //this._speed = speed;
            consoleSpeed();
            }
             
            public void consoleSpeed()
            {
                //Console.WriteLine(this._speed);
            }
        }

    //--------------------------- method hidding
    // Base Class 
    public class My_Family
    {
        public void member()
        {
            Console.WriteLine("Total number of family members: 3");
        }
    }

    // Derived Class 
    public class My_Member : My_Family
    {


        public new void member()
        {

            // Calling the hidden method of the 
            // base class in a derived class 
            // Using base keyword 
            base.member();
            Console.WriteLine("Name: Rakesh, Age: 40 \nName: Somya," +
                                  " Age: 39 \nName: Rohan, Age: 20");
        }
    }


}

