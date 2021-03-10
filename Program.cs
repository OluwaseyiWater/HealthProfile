using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            HealthProfile healthProfile = new HealthProfile(null, null, null, null, 0, 0, 0, 0, 0);

            Console.WriteLine("Enter First Name:");
            healthProfile.FirstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Last Name:");
            healthProfile.LastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Gender:");
            healthProfile.Gender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Month of Birth:");
            healthProfile.MonthOfBirth = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter day of birth:");
            healthProfile.DayOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year of birth:");
            healthProfile.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height in inches:");
            healthProfile.HeightInInches = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter weight in pounds:");
            healthProfile.WeightInPounds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Current Year:");
            healthProfile.CurrentYear = Convert.ToInt32(Console.ReadLine());


            healthProfile.DisplayFirstName();
            healthProfile.DisplayLastName();
            healthProfile.DisplayGender();
            healthProfile.DisplayMonthOfBirth();
            healthProfile.DisplayDayOfBirth();
            healthProfile.DisplayYearOfBirth();
            healthProfile.DisplayHeightInInches();
            healthProfile.DisplayWeightInPounds();
            healthProfile.DisplayCurrentYear();
            healthProfile.DisplayAge();
            healthProfile.DisplayMaxHeartRate();
            healthProfile.DisplayTargetHeartRate();
            healthProfile.DisplayBodyMassIndex();
            healthProfile.DisplayBMIOutput();
            healthProfile.DisplayBMIChart();

            Console.ReadKey();
        }
    }
}
