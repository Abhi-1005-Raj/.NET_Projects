using Unit_Testing_Proj;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        while (true)
        {
            Console.WriteLine("=== Calculator ===");
            Console.Write("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            Console.Write("Enter operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            try
            {
                int result = op switch
                {
                    "+" => calculator.Add(a, b),
                    "-" => calculator.Subtract(a, b),
                    "*" => calculator.Multiply(a, b),
                    "/" => calculator.Divide(a, b),
                    _ => throw new InvalidOperationException("Unknown operator")
                };

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.Write("Do you want to perform another calculation? (y/n): ");
            var cont = Console.ReadLine();
            if (cont?.ToLower() != "y") break;

            Console.Clear();
        }
    }
}