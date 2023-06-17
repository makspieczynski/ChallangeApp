namespace ChallangeApp.tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectGrades_ShouldCorrectResult()
        {
            //arange
            var employee = new Employee ("Maks", "Pieczyñski", "30");
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(-3);

            var employee1 = new Employee("Jan", "Kowalski", "37");
            employee1.AddGrade(8);
            employee1.AddGrade(9);
            employee1.AddGrade(-17);
            //act
            var result= employee.Result;
            var result1 = employee1.Result;

            //assert
            Assert.AreEqual(8, result);

        }
    }
}