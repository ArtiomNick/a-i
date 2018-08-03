using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lesson15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encoding");
            string path = @"C:\Users\artiom.nichifor\Desktop\";

            string fileName = "MyTxtFile.txt";

            TryEncoding(path, fileName);

            Console.WriteLine("String");
            Employee employee1 = new Employee("name1", 40, 10, "dep1");
            Employee employee2 = new Employee("name2", 20, 8, "dep1");

            StringManipulations(employee1, employee2);

            Console.WriteLine("TimeSpanAndDateTime");
            TimeSpanAndDateTime();

            Console.WriteLine("CultureInfo");
            CultureInfo md = CultureInfo.GetCultureInfo("md-MD");
            Console.WriteLine(16.79.ToString("C", md));

            NumberFormatInfo f = new NumberFormatInfo();
            Console.WriteLine(12451.11429994.ToString("N5", f));

            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();

            Console.WriteLine("CheckMyTime");

            string path1 = @"C:\Users\artiom.nichifor\Desktop\CheckMyTime.txt";

            CheckMyTime(path1);


            SomeClass someClass = new SomeClass(path1);
            //someClass.Dispose();



            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }


        private static void TryEncoding(string path, string name)
        {
            try
            {
                if (File.Exists(path + name))
                {
                    File.Delete(path + name);
                }

                using (FileStream fs = File.Create(path + name))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("This is introducti on");
                    fs.Write(info, 0, info.Length);

                    using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                    {
                        writer.WriteLine("There is UTF8 encoding");
                    }

                    //byte[] utf8Bytes = System.Text.Encoding.UTF8.GetBytes("\nThere is UTF8 encoding ");
                    //fs.Write(utf8Bytes, 0, utf8Bytes.Length);


                    //byte[] utf16Bytes = System.Text.Encoding.Unicode.GetBytes("\nThere is Unicode encoding");
                    //byte[] utf32Bytes = System.Text.Encoding.UTF32.GetBytes("\nThere is UTF32 encoding");
                    //string info1 = System.Text.Encoding.UTF8.GetString(utf8Bytes);
                    //string info2 = System.Text.Encoding.Unicode.GetString(utf16Bytes);
                    //string info3 = System.Text.Encoding.UTF32.GetString(utf32Bytes);
                    //Console.Write(info1);
                    //Console.Write(info2);
                    //Console.Write(info3);

                    //using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                    //{
                    //    writer.WriteLine("There is UTF8 encoding");
                    //}
                    //using (StreamWriter writer1 = new StreamWriter(fs, Encoding.Unicode))
                    //{
                    //    writer1.WriteLine("There is Unicode encoding");
                    //}

                    fs.Write(utf8Bytes, 0, utf8Bytes.Length);
                    fs.Write(utf16Bytes, 0, utf16Bytes.Length);
                    fs.Write(utf32Bytes, 0, utf32Bytes.Length);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        private static void StringManipulations(Employee employee1, Employee employee2)
        {
            string s1 = "Ana are mere";
            s1.StartsWith("ana");   //False
            s1.Contains("Ana");     //True
            s1.EndsWith("mere");    //True

            string s2 = "Name:{0,-10} Wage={1,2:C}      Department:{2}";

            Console.WriteLine(string.Format(s2, employee1.Name, employee1.Wage(), employee1.Department));
            Console.WriteLine(string.Format(s2, employee2.Name, employee2.Wage(), employee2.Department));

            Console.WriteLine("Î".Equals("î", StringComparison.InvariantCultureIgnoreCase));    //True
            Console.WriteLine("Î".Equals("î", StringComparison.CurrentCultureIgnoreCase));      //True
            Console.WriteLine("Î".Equals("î"));      //False

            Console.WriteLine(string.Compare("Î", "î", StringComparison.InvariantCulture));     // 1
        }

        private static void TimeSpanAndDateTime()
        {
            DateTime dateTime1 = DateTime.Now;
            TimeSpan duration = new TimeSpan(2, 30, 0);
            Console.Write($"{dateTime1} - {duration} = {dateTime1.Subtract(duration)}\n");

            DateTime dateTime2 = DateTime.Now;
            DateTimeOffset dateTimeOffset = new DateTimeOffset(dateTime2);
            Console.WriteLine($"{dateTime2} {dateTime2.Kind}");

            TimeZone timeZone = TimeZone.CurrentTimeZone;

            Console.WriteLine(timeZone.StandardName);

            Console.WriteLine(timeZone.IsDaylightSavingTime(dateTime2));
            Console.WriteLine(timeZone.GetUtcOffset(dateTime2));

            
            



        }


        private static void CheckMyTime(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    //DateTime dateTime = new DateTime(2018, 8, 1, 19, 1, 37); //assuming that this is the utc time
                    DateTime dateTime = DateTime.UtcNow;
                    writer.WriteLine(dateTime);
                }
            }
            //using (FileStream fs = File.OpenRead(path))
            //{
            //    using (StreamReader reader = new StreamReader(fs))
            //    {
            //        string s = reader.ReadToEnd();
            //        //DateTime dt = Convert.ToDateTime(s);
            //        DateTime dt = DateTime.Parse(s);
            //        dt = dt.ToLocalTime();
            //        Console.WriteLine(dt);
            //    }
            //}
            

        }
    }

    
}
