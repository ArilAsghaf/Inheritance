namespace Inheritance
{
    public class Program
    {

        static void Main(string[] args)
        {
            Person person = new Person("Iwang", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Arif", 50, "6946", "chemistry");
            teacher.GetNameAndAge();

            Student student = new Student("Annida", 20, "3301", "anidalutfi97@gmail.com");
            student.GetNameAndAge();
        }
    }
}