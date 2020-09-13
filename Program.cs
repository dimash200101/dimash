using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace Collections
{
    class Program
    {
      
        delegate int Operation(List<int>);


        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1,4,7,9,49};
            //var results = numbers.Where(d => d.Count >= 5).Select(d => d.list[numbers]);


            //Lambda
            //var squaredNumbers = numbers.Select(x => x * x);
            //Console.WriteLine(string.Join(" ", squaredNumbers));
            
            Operation del = Multiply; // делегат указывает на метод Add
            int result = del(numbers); // фактически Add(4, 5)
            Console.WriteLine(result);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }



            List<Person> people = new List<Person>(7);
            people.Add(new Person() { Name = "Dimash" });
            people.Add(new Person() { Name = "Aizhan" });
            people.Add(new Person() { Name = "Kamen" });
            people.Add(new Person() { Name = "Bibigul" });
            people.Add(new Person() { Name = "Omirkhan" });


            //linq
           // var selectedPeople = from t in people
                  //              where t.ToUpper().StartsWith("A")
                    //            orderby t 
                      //          select t; 


            foreach (Person i in people)
            {
                Console.WriteLine(i.Name);
            }

            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
    private static int Multiply(List<int> numbers)
    {
        int x = 1;
        foreach (int i in numbers)
        {
            x=x*i;
        }
        return x;
    }
}
