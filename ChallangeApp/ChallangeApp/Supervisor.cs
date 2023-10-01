namespace ChallangeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public string Name => "Adam";

        public string Surname => "Kowalski";

        public void AddGrade(float grade)
        {


            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new NotImplementedException("invalid grade value");
            }
        }


        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6":
                    this.AddGrade(95);
                    break;
                case "6-":
                    this.AddGrade(95);
                    break;
                case "5+":
                    this.AddGrade(85);
                    break;
                case "+5":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "-5":
                    this.AddGrade(75);
                    break;
                case "5-":
                    this.AddGrade(75);
                    break;
                case "4+":
                    this.AddGrade(65);
                    break;
                case "+4":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "-4":
                    this.AddGrade(55);
                    break;
                case "4-":
                    this.AddGrade(55);
                    break;
                case "+3":
                    this.AddGrade(45);
                    break;
                case "3+":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "-3":
                    this.AddGrade(35);
                    break;
                case "3-":
                    this.AddGrade(35);
                    break;
                case "2+":
                    this.AddGrade(25);
                    break;
                case "+2":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "-2":
                    this.AddGrade(15);
                    break;
                case "2-":
                    this.AddGrade(15);
                    break;
                case "+1":
                    this.AddGrade(5);
                    break;
                case "1+":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    if (float.TryParse(grade, out float number))
                    {
                        this.AddGrade(number);
                    }
                    else if (grade.Length == 1)
                    {
                        char a = char.Parse(grade);
                        this.AddGrade(a);
                    }
                    else
                    {
                        throw new NotImplementedException("Wrong value");
                    }
                    break;
            }

            void AddGrade(char grade)
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
                        throw new NotImplementedException("Wrong Letter");
                }

            }

            Statistics GetStatistics()
            {
                return new Statistics();
            }
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}

