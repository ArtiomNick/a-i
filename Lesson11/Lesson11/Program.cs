using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shift> shifts = new List<Shift>()
            {
                new Shift(){ StartTime = "8:00", EndTime = "17:00", Name = "day"},
                //new Shift(){ StartTime = "12:00", EndTime = "17:00", Name = "day"},
                new Shift(){ StartTime = "13:00", EndTime = "22:00", Name = "night"},

            };

            List<Employee> employees = new List<Employee>(){
                new Employee(){ Name = "name1", Salary = 20, Department = "groceries", Shift = shifts[0] },
                new Employee(){ Name = "name2", Salary = 3, Department = "groceries", Shift = shifts[1]},
                new Employee(){ Name = "name3", Salary = 15, Department = "groceries", Shift = shifts[0]},
                new Employee(){ Name = "name4", Salary = 10, Department = "DELI", Shift = shifts[1] },
                new Employee(){ Name = "name5", Salary = 15, Department = "DELI", Shift = shifts[0] },
                new Employee(){ Name = "name6", Salary = 25, Department = "DELI", Shift = shifts[1] },
                new Employee(){ Name = "name7", Salary = 4, Department = "groceries", Shift = shifts[0] },
                new Employee(){ Name = "name8", Salary = 21, Department = "groceries", Shift = shifts[1] },
                new Employee(){ Name = "name8", Salary = 21, Department = "groceries", Shift = shifts[1] }
            };

            var matrix = new[]
            {
                new[] {"value1", "value2"},
                new[] {"value3", "value4"}
            };

            var shiftAdditional = new List<Shift>()
            {
                new Shift(){ Name = "A1", list = new List<int>(){ 1, 2, 3, 4 }},
                new Shift(){ Name = "A2", list = new List<int>(){ 10, 22, 30, 40 }},
                new Shift(){ Name = "A3", list = new List<int>(){ 55, 32 }},
                new Shift(){ Name = "A4", list = new List<int>(){ 4 }}
            };


            Console.WriteLine("Filtering");
            var query1 = employees.Where(x => x.Salary < 20);
            var query2 = employees.Take(2);
            var query3 = employees.Skip(3);
            var query4 = employees.TakeWhile(x => x.Department == "groceries");
            var query5 = employees.SkipWhile(x => x.Department == "groceries");
            var query6 = employees.Distinct(new EmployeeEqualityComparer());

            //foreach (Employee empl in query1)
            //{
            //    Console.WriteLine(" ");
            //    Console.WriteLine("Name: {0}, Salary: {1}, Department: {2} ", empl.Name, empl.Salary, empl.Department);
            //}

            

            Console.WriteLine("Projection");
            var query7 = employees.Select(x => x.Name);
            var query8 = matrix.SelectMany(x => x);

            //foreach (var empl in query7)
            //{
            //    Console.WriteLine(" ");
            //    Console.WriteLine("Name: {0}", empl);
            //}

            Console.WriteLine("Joining");
            var query9 = shifts.Join(employees,
                                        shift => shift,
                                        empl => empl.Shift,
                                        (shift, empl) =>
                                                    new { ShiftName = shift.Name, EmployeeName = empl.Name}
                );

            

            //foreach (var empl1 in query9)
            //{
            //    Console.WriteLine("Shift: {0}, Employee: {1}", empl1.ShiftName, empl1.EmployeeName);
            //}

            var query10 = shifts.GroupJoin(employees,
                                        shift => shift,
                                        empl => empl.Shift,
                                        (shift, em) =>
                                                    new { ShiftName = shift.Name, EmployeeName = em }
                );

            //foreach (var shift in query10)
            //{
            //    Console.WriteLine("Shift: {0}", shift.ShiftName);
            //    foreach (var employee in shift.EmployeeName)
            //    {
            //        Console.WriteLine(employee.Name);
            //    }
            //}

            var query11 = shifts.Zip(employees, (e, s) => e.Name + " " + s.Name);
            //foreach (var e in query11)
            //{
            //    Console.WriteLine(e);
            //}

            Console.WriteLine("Ordering");
            var query12 = query1.OrderBy(e => e.Salary).ThenBy(e => e.Name);
            var query13 = query1.OrderByDescending(e => e.Salary).ThenByDescending(e => e.Name);
            var query14 = query13.Reverse();

            //foreach (Employee empl in query14)
            //{
            //    Console.WriteLine(" ");
            //    Console.WriteLine("Name: {0}, Salary: {1}, Department: {2} ", empl.Name, empl.Salary, empl.Department);
            //}

            Console.WriteLine("Grouping");
            var query15 = from a in shiftAdditional
                          group a by a.list.Average() > 20;

            //foreach (var group in query15)
            //{
            //    Console.WriteLine(" ");
            //    foreach (var a in group)
            //    {
            //        Console.WriteLine("Name: {0}, Average: {1}", a.Name, a.list.Average());
            //    }

            //}

            Console.WriteLine("Set operators");
            var query16 = query1.Union(query1);
            var query17 = query1.Concat(query1);
            var query18 = query1.Intersect(query2);
            var query19 = query1.Except(query2);

            

            Console.WriteLine("Conversion methods");
            ArrayList elements = new System.Collections.ArrayList() { "Table", "Name", true, 3.0, "1/21qq" };
            ArrayList elements1 = new System.Collections.ArrayList() { "Table", "Name", "1/21qq" };

            IEnumerable<string> query20 = elements.OfType<string>();
            IEnumerable<string> query21 = elements1.Cast<string>().OrderBy(element => element).Select(element => element);

            //foreach (var el in query20)
            //{
            //    Console.WriteLine(" ");
            //    Console.WriteLine("String element:" + el);
            //}

            string[] names = employees.Select(empl => empl.Name).ToArray();

            //foreach(string s in names)
            //{
            //    Console.WriteLine("Name: " + s);
            //}

            List<int> salaries = employees.Select(empl => empl.Salary).ToList();

            //foreach (int s in salaries)
            //{
            //    Console.WriteLine("Salary: " + s);
            //}

            Dictionary<string, Shift> dictionary = shifts.ToDictionary(s => s.Name);

            //foreach (KeyValuePair<string, Shift> d in dictionary)
            //{
            //    Console.WriteLine("{0} shift: {1} - {2}", d.Key, d.Value.StartTime, d.Value.EndTime);
            //}

            //IEnumerable<string> query20 = elements.OfType<string>();
            ILookup<string, Shift> lookup = shifts.ToLookup(s => s.Name);

            //foreach (IGrouping<string, Shift> l in lookup)
            //{
            //    Console.WriteLine("{0} shift:", l.Key);
            //    foreach (Shift s in l)
            //    {
            //        Console.WriteLine("{0} - {1}", s.StartTime, s.EndTime);
            //    }
            //}

            IQueryable<string> query23 = names.AsQueryable();
            IEnumerable<string> query22 = names.AsEnumerable().Where(name => name.Contains("a"));

            //foreach (string s in query22)
            //{
            //    Console.WriteLine("Name: " + s);
            //}

            Console.WriteLine("Element operators");
            int sal;
            sal = salaries.First(f => f > 20);
            sal = salaries.FirstOrDefault(f => f < 20);
            sal = salaries.Last(f => f < 20);
            sal = salaries.LastOrDefault(f => f < 20);
            sal = salaries.Single(f => f == 10);
            sal = salaries.Single(f => f < 4);
            sal = salaries.ElementAt(0);
            sal = salaries.ElementAtOrDefault(1);
            //Console.WriteLine(sal);
            List<int> numbers = new List<int>();
            //foreach (int i in numbers.DefaultIfEmpty())
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("Agregation methods");
            var count = salaries.Count(c => c > 10);
            var max = salaries.Max();
            var sum = salaries.Sum();
            var nameList = names.Aggregate((s1, s2) => s1 + "," + s2);
            //Console.WriteLine(nameList);

            Console.WriteLine("Quantifiers");
            bool b1 = salaries.Any(s => s == 21);
            bool b2 = salaries.All(s => s > 2 && s < 30);
            bool b3 = salaries.Take(1).SequenceEqual(new List<int>() { salaries[0] });

            //Console.WriteLine(b1);

            Console.WriteLine("Generation methods");
            var emptyEnumerable = Enumerable.Empty<int>();
            var enumerableRepeat = Enumerable.Repeat(10, 3);
            var enumerableRange = Enumerable.Range(3, 7);

            foreach (int i in enumerableRange)
            {
                Console.WriteLine(i);
            }








            Console.ReadKey();
        }
    }
}
