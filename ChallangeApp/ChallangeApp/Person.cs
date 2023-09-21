namespace ChallangeApp
{
    public class Person : System.Object
    {
        public Person(string name, string surname, char gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Person(string name)
        {
            this.Name = name;
        }
        public Person()
        {

        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }
    }
}
