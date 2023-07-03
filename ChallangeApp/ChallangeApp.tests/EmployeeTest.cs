namespace ChallangeApp.tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectMax()
        {
            //arange
            var employee = new Employee("Maks", "Pieczyñski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);



            //act
            var statistics = employee.GetStatistics();




            //assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]

        public void WhenGetStatistics_ShouldReturnCorrectMin()
        {
            //arange
            var employee = new Employee("Maks", "Pieczyñski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Min);

        }
        [Test]

        public void WhenGetStatistics_ShouldReturnCorrectAverage()
        {
            //arange
            var employee = new Employee("Maks", "Pieczyñski");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));

        }
    }
}