using System.ComponentModel.DataAnnotations.Schema;

namespace dictionary
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

        employees.Add(1, new Employee("John", 30, 10000));
            //employees.Add(2, new Employee("Maria", 40, 10000));
            //employees.Add(3, new Employee("Lisa", 20, 10000));

            //foreach (var item in employees)
            //{
            //    Console.WriteLine($"ID:{item.Key} name: {item.Value.Name} " +
            //        $"earns {item.Value.Salary}" +
            //        $"and is {item.Value.Age} years old  ");
            //}



            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"]= "Texas"
            };

            if(codes.TryGetValue("NY", out string state))
            {
                Console.WriteLine(state);
            }

            foreach (var item in codes)
            {
                Console.WriteLine($"The state code is {item.Key} and the state is {item.Value}");
            }

            //declarando um dicionario
            //Dictionary<int, string> employees = new Dictionary<int, string>();

            /*
            add funcionarios ao dicionario
            employees.Add(101, "Dani");
            employees.Add(102, "Rose");
            employees.Add(103, "Fani");

            //acessando
            string name = employees[101];
            //Console.WriteLine(name);

            //update
            employees[102] = "Jane";
            employees.Remove(103);

            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID = {employee.Key}, Name = {employee.Value}");
            }

            //duplicatas

            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Mike");
            }
            //tenta add
            bool added = employees.TryAdd(102, "Michael");
            if(!added)
            {
                Console.WriteLine("Employee with the id of 102 already exists");
            }
            */

        }


    }
}
