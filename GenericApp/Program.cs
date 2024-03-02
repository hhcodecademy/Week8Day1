using System.Drawing;

namespace GenericApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            //DataStoreGeneric<int> dataStoreInt = new DataStoreGeneric<int>();
            //DataStoreGeneric<float> dataStoreFloat = new DataStoreGeneric<float>();
            //DataStoreGeneric<string> dataStoreStr = new DataStoreGeneric<string>();
            DataStoreGeneric<Mentor> dataStorePerson = new DataStoreGeneric<Mentor>();
            DataStoreGenericNumber<int> dataStoreInt = new DataStoreGenericNumber<int>();
            do
            {
                
                Person person = new Person();
                Console.WriteLine("Telebenin yasini daxil ediniz");
                int age = int.Parse(Console.ReadLine());
                person.Age = age;
                Console.WriteLine("Telebenin qiymetini daxil ediniz");
                float point = float.Parse(Console.ReadLine());
                person.Point = point;

                Console.WriteLine("Telebenin adini daxil ediniz");
                string name = Console.ReadLine();
                person.Name = name;
                dataStorePerson[count] = person;

                count++;

            } while (count<3);
      
         
            
        }
    }
}
