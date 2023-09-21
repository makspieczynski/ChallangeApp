﻿using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace ChallangeApp
{
    public class Employee : Person
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, char gender)
          : base(name, surname, gender)
        {

        }
        public Employee()
          : base("no name")
        {

        }
        public Employee(string name)
           : base(name, "no surname")
        {

        }
        public Employee(string name, string surname)
            : base(name, surname)
        {

        }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {


            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }


        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(string grade)

        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("string is not float");
            }

        }

        public void AddGrade(char grade)
        {

            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
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
                if (grade >= 0)
                {

                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average = statistics.Average + grade;
                }
            }

            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;

        }



    }
}
