class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Enter two numbers");

            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operation you want to perform +, -, *, /");

            char operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
            {
                double sum = num1 + num2;
                Console.WriteLine("The sum is: " + sum);
            }
            else if (operation == '-')
            {
                double difference = num1 - num2;
                Console.WriteLine("The difference is: " + difference);
            }
            else if (operation == '*')
            {
                double product = num1 * num2;
                Console.WriteLine("The product is: " + product);
            }
            else if (operation == '/')
            {
                 if (num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    continue;
                }
                double quotient = num1 / num2;
                Console.WriteLine("The quotient is: " + quotient);
            }

            Console.WriteLine("Do you want to perform another operation? (y/n)");

            char response = Convert.ToChar(Console.ReadLine());

            if (response == 'n')
            {
                isRunning = false;
            }
        }
    }
}
