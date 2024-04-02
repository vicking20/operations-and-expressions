using System.Diagnostics.Metrics;

namespace OperatorsAndExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Arithmetic Operators
            // - Prompts the user to enter two numbers
            // - Computes and siplays the addition, subtraction, multiplication, division and modulus
            //   of the two numbers
            // Enter your code below
                Console.Write("Enter the first number: ");
                if (!double.TryParse(Console.ReadLine(), out double firstNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }

                Console.Write("Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out double secondNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                double addition = firstNumber + secondNumber;
                double subtraction = firstNumber - secondNumber;
                double multiplication = firstNumber * secondNumber;
                double division = firstNumber / secondNumber;
                double modulus = firstNumber % secondNumber;
                
                Console.WriteLine($"Addition: {addition}");
                Console.WriteLine($"Subtraction: {subtraction}");
                Console.WriteLine($"Multiplication: {multiplication}");
                Console.WriteLine($"Division: {division}");
                Console.WriteLine($"Modulus: {modulus}");
            }
    }


        // Task 2: Relational and Equality Operators
        // - Prompts the user to enter two integers
        // - Compares the two integers and displays whether they are equal, and if not, which one is larger.
        // Enter your code below
{
        Console.Write("Enter the first integer: ");
        if (!int.TryParse(Console.ReadLine(), out int firstNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        Console.Write("Enter the second integer: ");
        if (!int.TryParse(Console.ReadLine(), out int secondNumber))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return;
        }

        // Compare the two integers
        if (firstNumber == secondNumber)
        {
            Console.WriteLine("The two integers are equal.");
        }
        else
        {
            // Determine which one is larger
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"The first number, {firstNumber} is larger than the second number, {secondNumber}.");
            }
            else
            {
                Console.WriteLine($"The second number, {secondNumber} is larger than the first number, {firstNumber}.");
            }
}
    }
}


    // Task 3: Logical Operators
    // - Prompts the user to enter an age.
    // - Checks if the age is greater than 13 and less than 20.If it is, print "Teenager".Otherwise, print "Not a teenager".
    // Enter your code below    
        int age;

        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        if (age > 13 && age < 20)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Not a teenager");
}
    }
}



    // Task 4: Unary and Assignment Operators
    // - Initializes a variable called counter with a value of 10.
    // - Increments the counter using the ++ operator.
    // - Decrements the counter using the -- operator.
    // - Multiplies the counter by 5 using the *= operator.
    // - Divides the counter by 2 using the /= operator.
    // - Displays the current value of counter after each operation.
    // Enter your code below
        int counter = 10;

        counter++;
        Console.WriteLine("Counter Increment: " + counter);

        counter--;
        Console.WriteLine("Counter Decrement: " + counter);

        counter *= 5;
        Console.WriteLine("After multiplying by 5: " + counter);

        counter /= 2;
        Console.WriteLine("After dividing by 2: " + counter);
    }
}


}
}
}