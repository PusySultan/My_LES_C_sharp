namespace Interface_DS_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Developer = new Employee(name: "Kirill", surname: "Solodukhin");
            Developer.GetInfo();

            Employee Developer_1= new Employee(name: "Igor", surname: "Solodukhin");
            Developer_1.GetInfo();

            Employee Developer_2 = new Employee(name: "Egor", surname: "Ivushkin");
            Developer_1.GetInfo();

            Developer.AddSubordinates(Developer_1);
            Developer.AddSubordinates(Developer_2);
            Developer.GetInfo();

            Developer.RemoveAllSubordinates();
            Developer.GetInfo();

            Developer.AddSubordinates(Developer_1);
            Developer.AddSubordinates(Developer_2);
            Developer.RemoveSubordinates(Developer_1);
            Developer.GetInfo();
        }
    }
}
