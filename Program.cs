namespace WorkDaysOfMounth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write needed mounth(0 for current):");
            string? input = Console.ReadLine();
            int inputInt = Convert.ToInt32(input);
            int workDays = 0, Weekends = 0;

            DateTime spDate;
            if(inputInt == 0)
            {
                spDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
            else
            {
                spDate = new DateTime(DateTime.Now.Year, inputInt, 1);
            }
            
            int daysInMount = DateTime.DaysInMonth(spDate.Year, spDate.Month);
            
            for(int i = 1; i < daysInMount+1; i++)
            {
                DateTime temp = new DateTime(spDate.Year, spDate.Month, i);
                if(temp.DayOfWeek == DayOfWeek.Sunday || temp.DayOfWeek == DayOfWeek.Saturday)
                { 
                    Weekends++;
                }
                else
                {
                    workDays++;
                }
            }
            Console.WriteLine($"Workdays:{workDays}, Weekends:{Weekends}");
        }
    }
}