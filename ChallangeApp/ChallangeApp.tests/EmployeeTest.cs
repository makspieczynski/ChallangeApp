namespace ChallangeApp.tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatistics_ShouldReturnCorrectStatistics()
        {
            //arange
            var employee = new Employee();
            var employee2 = new Employee();

            employee.AddGrade(10);
            employee.AddGrade(20);
            employee.AddGrade(40);
            employee.AddGrade(80);

            employee2.AddGrade(2);
            employee2.AddGrade(8);
            employee2.AddGrade(10);
            employee2.AddGrade(40);



            //act
            var statistics = employee.GetStatistics();
            var statistics2 = employee2.GetStatistics();




            //assert
            Assert.AreEqual(80, statistics.Max);
            Assert.AreEqual(10, statistics.Min);
            Assert.AreEqual(37,5, statistics.Average);
            Assert.AreEqual('D', statistics.AverageLetter);

            Assert.AreEqual(40, statistics2.Max);
            Assert.AreEqual(2, statistics2.Min);
            Assert.AreEqual(15, statistics2.Average);
            Assert.AreEqual('E', statistics2.AverageLetter);

        }
        
       
    }
}