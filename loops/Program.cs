using System.Linq.Expressions;

BuildSwitchStatement();
void BuildSwitchStatement()

{
    Console.WriteLine("Enter a month (1-3): ");
    int month= Convert.ToInt32(Console.ReadLine());
    string monthname;

    switch(month)

    {
        case 1:
            monthname = "January";
            break;

        case 2:

            monthname = "Feb";
            break;

        case 3:

            monthname = "March";
            break;

        default:

            monthname = " Invalid month";
            break;

    }

    Console.WriteLine($" month {month} is {monthname} ");

   
}




