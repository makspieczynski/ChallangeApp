namespace ChallangeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddGrade(float grade);
        public void AddGrade(double grade);
        public void AddGrade(int grade);
        public void AddGrade(string grade);
        public void AddGrade(char grade);
        Statistics GetStatistics();
    }
}
