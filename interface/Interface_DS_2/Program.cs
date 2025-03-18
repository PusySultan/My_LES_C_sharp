namespace Interface_DS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            IVehicle[] array =
            {
                new Car(),
                new Bicycle(),
                new Car(),
                new Bicycle(),
                new Car(),
                new Bicycle(),
            };

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Speed = array[i] is Car ? random.Next(-250, 250) + i : random.Next(-20, 20) + i;
            }

            foreach (IVehicle v in array)
            {
                v.drive();
            }
        }
    }
}
