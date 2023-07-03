using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace ChallangeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }




        public void AddGrade(float grade)
        {


            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }


        public void AddGrade(double grade)
        {
            float doubleToFloat = (float)grade;
            this.AddGrade(doubleToFloat);
        }

        public void AddGrade(long grade)
        {
            float longToFloat = (float)grade;
            this.AddGrade(longToFloat);
        }
        public void AddGrade(string grade)

        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
            }

        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;



            foreach (var grade in this.grades)
            {

                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average = statistics.Average + grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;

            for (var index = 0; index < this.grades.Count; index++)
            {
                statistics2.Max = Math.Max(statistics2.Max, grades[index]);
                statistics2.Min = Math.Min(statistics2.Min, grades[index]);
                statistics2.Average = statistics2.Average + grades[index];
            }

            statistics2.Average /= this.grades.Count;
            return statistics2;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;

            var index = 0;
            do
            {
                statistics3.Max = Math.Max(statistics3.Max, grades[index]);
                statistics3.Min = Math.Min(statistics3.Min, grades[index]);
                statistics3.Average = statistics3.Average + grades[index];
                index++;
            }
            while (index < this.grades.Count);

            statistics3.Average /= this.grades.Count;
            return statistics3;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Average = 0;
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistics4.Max = Math.Max(statistics4.Max, grades[index]);
                statistics4.Min = Math.Min(statistics4.Min, grades[index]);
                statistics4.Average = statistics4.Average + grades[index];
                index++;
            }
            statistics4.Average /= this.grades.Count;
            return statistics4;
        }

    }
}
