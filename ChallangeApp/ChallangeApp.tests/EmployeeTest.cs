namespace ChallangeApp.tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenUserCollectGrades_ShouldCorrectResult()
        {
            //arange
            var employee = new Employee ("Maks", "Pieczyñski", "30");
            employee.AddGrade(5);
            employee.AddGrade(6);
            


            //act
            var result= employee.Result;
            

            //assert
            Assert.AreEqual(11, result);

        }
    }
}