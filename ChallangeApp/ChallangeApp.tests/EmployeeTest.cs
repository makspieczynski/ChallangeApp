namespace ChallangeApp.tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectMax()
        {
            //arange
            var employee = new Employee ("Maks", "Pieczyñski");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(9);



            //act
            var statistics = employee.GetStatistics();

            


            //assert
            Assert.AreEqual(9.0f, statistics.Max);

        }
        [Test]

        public void WhenGetStatistics_ShouldReturnCorrectMin()
        {
            //arange
            var employee = new Employee("Maks", "Pieczyñski");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(9);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(9, statistics.Max);

        }
        [Test]

        public void WhenGetStatistics_ShouldReturnCorrectAverage()
        {
            //arange
            var employee = new Employee("Maks", "Pieczyñski");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(9);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5.33333349f, statistics.Average) ;

        }
    }
}