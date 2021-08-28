using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comperer_And_Extensions_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("aon", "patashnik", 55); // student code check
            Student s2 = new Student("bon", "patashnik", 0);
            Student s3 = new Student("Don", "Patashnik", 96);
            Student s4 = new Student("con", "Catashnik", 60);
            Student s5 = new Student("don", "aatashnik", 96);
            Student s6 = new Student("eon", "gatashnik", 96);

            List<Student> students = new List<Student>()
            { s1,s2,s3,s4,s5,s6};

            students.Sort(new StudentCompByGrade()); // End of student code check


            MeasureDetails MD1 = new MeasureDetails("BeerSheve"); // Measurments Check
            MeasureDetails MD2 = new MeasureDetails("Tel Aviv");
            MeasureDetails MD3 = new MeasureDetails("Jerus");
            MeasureDetails MD4 = new MeasureDetails("Eilat");
            MeasureDetails MD5 = new MeasureDetails("Patashville");

            List<MeasureDetails> measureDetailsList = new List<MeasureDetails>() {MD1,MD2,MD3,MD4,MD5 };


            measureDetailsList.Sort(new MeasCompareByHumidTempAndCity()); // End of Measurments Check


            string s = "Ron Patashnik";
            bool B = s.HasLowerCase();
            string News = s.ReverseCase();

            int i = 78;
            int x = 25;
            Console.WriteLine(x.MultiBy(10));
            object O = "10";
            B = O.IsNull();

            string IdS = "206270928";

            
            
            B = IdS.IsValidIsraeliId();

            Console.WriteLine(x.Print());
        }
    }
}
