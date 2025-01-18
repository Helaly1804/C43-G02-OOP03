namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] empArr = new Employee[3];
            string[] strArr = {"DBA" ,"Guest", "Secretary"};
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine($"Please enter the details of Employee number{i} :");
                bool isParsed;
                string name;
                int salary , day,month,year;
                HiringDate date;
                Security security;
                Gender gender;
                int id = i;
                do
                {
                    Console.WriteLine("Please Enter the name of Employee");
                    name = Console.ReadLine();
                } while( name is null );
                do
                {
                    Console.WriteLine("Please Enter the salary");
                    isParsed = int.TryParse(Console.ReadLine(), out salary);
                } while (!isParsed);
                do
                {
                    Console.WriteLine("Please enter the day of the Hiring Date");
                    isParsed = int.TryParse(Console.ReadLine(),out day);

                }while (!isParsed);
                do
                {
                    Console.WriteLine("Please enter the month of the Hiring Date");
                    isParsed = int.TryParse(Console.ReadLine(), out month);

                } while (!isParsed);
                do
                {
                    Console.WriteLine("Please enter the year of the Hiring Date");
                    isParsed = int.TryParse(Console.ReadLine(), out year);

                } while (!isParsed);
                date = new HiringDate(day,month,year);
                do
                {
                    Console.WriteLine("Please Enter your Gender : ");
                    isParsed = Enum.TryParse(Console.ReadLine().ToLower(), out gender);
                }while(!isParsed);
                Enum.TryParse(strArr[i].ToLower(), out security);
                empArr[i] = new Employee(id, name, date, gender, salary,security);
            }
            for(int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine(empArr[i]);
            }
            #region 4
            Employee swap;
            for (int i = 0; i < empArr.Length-1; i++)
            {
                for (int j = i; j < empArr.Length; j++)
                {
                    if (empArr[i].Salary > empArr[j].Salary)
                    {
                        swap = empArr[j];
                        empArr[j] = empArr[i];
                        empArr[i] = swap;
                    }
                }
            }
            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine(empArr[i]);
            }
            #endregion
            #region 5
            EBook ebook = new EBook("C# Programming", "John Doe", "123-4567890123", 1.5);
            PrintedBook printedBook = new PrintedBook("Learn Algorithms", "Jane Smith", "987-6543210987", 450);

            Console.WriteLine("EBook Information:");
            ebook.DisplayInfo();

            Console.WriteLine("\nPrinted Book Information:");
            printedBook.DisplayInfo();
            #endregion

        }
    }
}
