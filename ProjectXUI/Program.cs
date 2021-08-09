using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectXBL;
using ProjectXDTO;

namespace ProjectXUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Projectxbl obj = new Projectxbl();
            Console.WriteLine("Enter PSNo:");
            int inputPSNo1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string inputName1 = Console.ReadLine();
            FacultyDTO facObj1 = new FacultyDTO
            {
                FacultyName = inputName1,
                PSNo = inputPSNo1,
            };

            int returnValue1 = obj.UpdateFaculty(facObj1);

            if (returnValue1 == 1)
            {
                Console.WriteLine("Data Updated Successfully");
                Console.WriteLine("List of Faculties");
                var output = obj.GetFaculties();
                foreach (var item in output)
                {
                    Console.WriteLine(item.FacultyName);
                }
            }
            else
            {
                Console.WriteLine("Oops! Something went wrong ! ");
            }
        }
    }
}
