using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo05();
        }

        private static void Demo05()
        {
            HR.Trainer trainer = null;
            Student[] students;
            GetSampleData(24, ref trainer, out students);

            Demo05_01(students);
            {
                Console.WriteLine();
                var query = from Student rcd in students
                            select rcd;
                Demo05_01(query.ToList());
            }
            {
                Console.WriteLine();
                var query = from rcd in students
                            select rcd;
                Demo05_01(query.ToList());
            }
            {
                Console.WriteLine();
                var query = from rcd in students
                            where String.Compare(rcd.Country, "Malaysia", true) == 0
                            select rcd;
                Demo05_01(query.ToList());
            }
            {
                Console.WriteLine();
                var query = from rcd in students
                            orderby rcd.Country descending
                            select rcd;
                Demo05_01(query.ToList());
            }
            {
                Console.WriteLine();
                var query = from rcd in students
                            where rcd.Age < 20
                            select rcd;
                Demo05_01(query.ToList());
            }
            {
                Console.WriteLine();
                var query = from rcd in students
                            where rcd.Age < 20 && 
                                String.Format("{0}, {1}", rcd.firstname, rcd.lastname).Contains("w")
                            select rcd;
                Demo05_01(query.ToList());
            }
            {
                Console.WriteLine();
                var query = from rcd in students
                            where rcd.Age > 30
                            select rcd;
                if (query.Any())
                    Demo05_01(query.ToList());
                else
                    Console.WriteLine("No record found");
            }
        }

        private static void Demo05_01(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("Student name is {0} {1} as age {2} from {3}", 
                    student.firstname, student.lastname, student.Age, student.Country);
            }
        }

        private static void Demo04()
        {
            var stu = new Student() { IdNumber = "123456-12-1234", Country="MY" };
            Console.WriteLine(stu.IdNumber);
            Console.WriteLine(stu.Country);
        }

        private static void Demo03()
        {
            Common.LocationCodeSet loc1 = new Common.LocationCodeSet("MY");
            Common.LocationCodeSetType loc2;
            loc2.Country = "MY";
            loc2.State = "KL";

            Common.LocationCodeSetType loc3 = loc2;
            Console.WriteLine(loc3.State);
            loc3.State = "SLG";
            Console.WriteLine(loc3.State);
            Console.WriteLine(loc2.State);

            Common.LocationCodeSetType loc4 = new Common.LocationCodeSetType();
            Common.LocationCodeSetType loc5 = new Common.LocationCodeSetType("SG");
        }

        private static void Demo02()
        {
            Demo02_06();
        }

        private static void Demo02_01()
        {
            Console.WriteLine(Demo02_01_01(2));
            Console.WriteLine(Demo02_01_01(0));
        }

        private static void Demo02_02()
        {
            try
            {
                Console.WriteLine(Demo02_01_01(2));
                Console.WriteLine(Demo02_01_01(0));
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        private static void Demo02_03()
        {
            try
            {
                Console.WriteLine(Demo02_01_01(2));
                Console.WriteLine(Demo02_01_01(0));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        private static void Demo02_04()
        {
            try
            {
                Console.WriteLine(Demo02_01_01(2));
                Console.WriteLine(Demo02_01_01(0));
                Console.WriteLine(Demo02_01_01(3));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Unable to divide by zero");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }

        private static void Demo02_05()
        {
            try
            {
                Console.WriteLine(Demo02_01_01(2));
                Console.WriteLine(Demo02_01_01(0));
                Console.WriteLine(Demo02_01_01(3));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Unable to divide by zero");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            Console.WriteLine("Method End");
        }

        private static void Demo02_06()
        {
            try
            {
                Console.WriteLine(Demo02_01_01(2));
                Console.WriteLine(Demo02_01_01(0));
                Console.WriteLine(Demo02_01_01(3));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Unable to divide by zero");
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            Console.WriteLine("Method End");
        }

        private static int Demo02_01_01(int baseValue)
        {
            return 10 / baseValue;
        }

        private static void Demo01()
        {
            HR.Trainer trainer = null;
            Student[] students;
            GetSampleData(24, ref trainer, out students);

            Console.WriteLine("Trainer name is {0} {1}", trainer.firstname, trainer.lastname);
            Console.WriteLine("Trainer profile as:");
            Console.WriteLine(trainer.GetProfileInfo("\t"));
            Console.WriteLine(trainer.GetProfileInfo("==>", "\t"));
            Console.WriteLine(trainer.GetProfileInfo(indents: "\t", prefix: "==>"));
            Console.WriteLine(trainer.GetProfileInfo("==>", indents: "\t"));
            Console.WriteLine(trainer.GetProfileInfo(prefix: "==>"));

            Console.WriteLine();
            Demo01_01(students);
            Console.WriteLine();
            Demo01_02(students[0], students[1]);
            Console.WriteLine();
            Demo01_02(students[0], students[1], students[3]);
            Console.WriteLine();
            var selected = new Student[] { students[0], students[2], students[3] };
            Demo01_01(selected);
            Console.WriteLine();
            Demo01_03(selected);
            Console.WriteLine();
            Demo01_03(students[0], students[1], students[3], students[4]);
        }

        private static void Demo01_01(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("Student name is {0} {1}", student.firstname, student.lastname);
            }
        }

        private static void Demo01_02(Student s1, Student s2)
        {
            Console.WriteLine("Student name is {0} {1}", s1.firstname, s1.lastname);
            Console.WriteLine("Student name is {0} {1}", s2.firstname, s2.lastname);
        }

        private static void Demo01_02(Student s1, Student s2, Student s3)
        {
            Console.WriteLine("Student name is {0} {1}", s1.firstname, s1.lastname);
            Console.WriteLine("Student name is {0} {1}", s2.firstname, s2.lastname);
            Console.WriteLine("Student name is {0} {1}", s3.firstname, s3.lastname);
        }

        private static void Demo01_03(params Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("Student name is {0} {1}", student.firstname, student.lastname);
            }
        }

        private static bool GetSampleData(byte trainAge, ref HR.Trainer trainer,
            out Student[] students)
        {
            if (trainer == null)
                trainer = new HR.Trainer() { firstname = "James", lastname = "Hong" };
            students = new Student[] {
                               new Student() { firstname="Ali", lastname="Baba", Age=18, Country="Malaysia" },
                               new Student() { firstname="Mike", lastname="Low", Age=20, Country="Singapore" },
                               new Student() { firstname="Sline", lastname="Cow", Age=19, Country="Malaysia" },
                               new Student() { firstname="New", lastname="Age", Age=21, Country="Indonisa" },
                               new Student() { firstname="Jake", lastname="Rose", Age=20, Country="China" }
                           };
            trainer.SetAge(trainAge);
            trainer.Employ();
            return true;
        }
    }
}
