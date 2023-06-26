

namespace ChallangeApp.tests
{
    public class TypeTests
    {
        [Test]
        public void NumbersShouldNotBeEqual()
        {
            //arange
            int number1 = 1;
            int number2 = 2;
            //act
            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void NameShouldBeEqual()
        {
            string name1 = "Dave";
            string name2 = "Dave";
            Assert.AreEqual(name1, name2);
        }
        [Test]
        public void WeightShouldBeEqual()
        {
            float weight1 = 2.2f;
            float weight2 = 2.2f;

            Assert.AreEqual(weight1, weight2);
        }

        [Test]
        public void EmployeeShouldReturnDifferentObjects()
        {
            //arange
            var employee1 = GetEmployee("Maks", "Pieczyński");
            var employee2 = GetEmployee("Maks", "Pieczyński");

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}
