CalculatorApp();

void CalculatorApp()
{
    try
    {
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the operation
        Console.Write("Enter the operation (+, -, *, /): ");

        // Keyboard input is by default of type 'string'
        // and requires conversion to 'char' to work
        // with the switch statement
        char operation = Convert.ToChar(Console.ReadLine());
        int result = 0;

        // Perform the operation
        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }
        // Output the result to the user
        Console.WriteLine($"Result: {result}");
    }
    catch (Exception ex)
    {
        // Handle the case where the input is not valid
        // and show the user the error message content.
        Console.WriteLine($"Error:{ex.Message}. Please enter a valid operation.");
    }
    finally
    {

    }
}