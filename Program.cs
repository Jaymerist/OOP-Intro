/*
 * Purpose: Demonstrate how to create and use a simple class
 * Input: n/a
 * Output: StudentData values
 * Author: Mihiri Kamiss
 * Date: November 4, 2022
 * 
 * */

namespace OOP_Intro
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                //Create a default instance of StudentData
                StudentData student1 = new StudentData();

                //Create a non-default instance of StudentData
                StudentData student2 = new StudentData("Mihiri Kamiss", 98);

                //Display the properties of the objects
                Console.WriteLine($"Name: {student1.Name}, Grade: {student1.Grade}");
                Console.WriteLine($"Name: {student2.Name}, Grade: {student2.Grade}");

                //Display the instances/objects
                Console.WriteLine(student1);
                Console.WriteLine(student2);

                //Try to write to an object's property
                student2.Grade = 30;
                Console.WriteLine(student2);

                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            } 
          
        }//end of Main
    }
}