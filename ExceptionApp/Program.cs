namespace ExceptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
        
                Teacher teacher = new Teacher(35, "Huseyn", "XX", "phd", 123);
                Console.WriteLine(teacher.ToString());
                // GetData();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                //throw;
            }

        }

        static void GetData()
        {
            try
            {
                Console.WriteLine("Telebnin adini daxili ediniz");
                string studentName = Console.ReadLine();

                if (ValideName(studentName))
                {
                    Console.WriteLine("Telebnin soyadini daxili ediniz");
                    string studentlastName = Console.ReadLine();
                }
                else
                {
                    throw new InvalidStudentNameException(studentName);
                }

            }


            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }

        static bool ValideName(string studentName) {

            foreach (var item in studentName)
            {
                if (char.IsNumber(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
