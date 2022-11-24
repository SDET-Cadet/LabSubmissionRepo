namespace File_IO
{
    abstract class Person
    {
        public string? firstName;
        public string? lastName;
        public string? gender;
        public int age;

        // public methods
        public virtual void eat()
        {
            Console.WriteLine("slurping");
        }

        public void sleep()
        {
            Console.WriteLine("Snoring");
        }

        public void InputValues(string prompt)
        {
            
            Console.ReadLine();

            Console.WriteLine("Enter the student's first name.");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter the student's last name.");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter the student's gender.");
            gender = Console.ReadLine();

            Console.WriteLine("Enter the student's age.");
            age = Convert.ToInt32(Console.ReadLine());
        }

        abstract public void SaveToFile();
        public virtual void InputValues()
        {
            InputValues("Enter the ");
        }
    }
}
