using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employ
    {
        delegate string addDept(string qual);                 //Used delegate.
        String Name, Qualification, Department, FilePath = "C:\\Users\\My_Pc\\Desktop\\record.txt";
        internal int ID = 1000, Salary, check = 0;
        addDept addDep = new addDept(AddDept);
        
        

        private static string AddDept(string Qualification)
        {
            string Department = "";
            if ((Qualification == "BE") || (Qualification == "BCA") || (Qualification == "BSC"))
            {
                Department = "IT";
                Console.WriteLine("\nEmployee added under IT department.");
            }
            else if ((Qualification == "BCom") || (Qualification == "MCom") || (Qualification == "CA"))
            {
                Department = "Accounts";
                Console.WriteLine("\nEmployee added under accounts department.");
            }
            else
            {
                throw new UserDefinedException(string.Format("Invalid Qualification!"));
            }
            return Department;
        }

        public Employ(int count)
        {
            try                                                                //used try
            {
                Console.WriteLine("Enter name :");
                Name = Console.ReadLine();
                if (String.IsNullOrEmpty(Name))
                {
                    throw new ArgumentException("Empty field!");
                }
                Console.WriteLine("Enter Qualification :");
                Qualification = Console.ReadLine();
                if (String.IsNullOrEmpty(Qualification))
                {
                    Console.WriteLine("Qualification field cannot be empty");
                    throw new ArgumentException("Empty field!");
                }
                ID = ID + count;
                string dep=addDep(Qualification);
                check = 1;
            }
            catch (ArgumentException ex)                                            //used catch
            {
                Console.WriteLine("This field cannot be empty");
                using (StreamWriter writer = new StreamWriter(FilePath, true))      //used using
                {
                    writer.WriteLine("Message :" + ex.Message + " " + Environment.NewLine + "StackTrace :" + ex.StackTrace + " " + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                }
            }
            catch (UserDefinedException ex2)
            {
                Console.WriteLine("Invalid Qualification!");
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.WriteLine("Message :" + ex2.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex2.StackTrace + " " + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                }
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Invalid entry!");
                //log this
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.WriteLine("Message :" + ex1.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex1.StackTrace + " " + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                }
            }
            finally                                                            //used finally
            {
                Console.WriteLine("Done");
            }
        }

    }
}
