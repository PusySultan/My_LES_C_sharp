namespace Delege_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextFileProceser tx = new TextFileProceser("..\\..\\..\\Data\\Data.txt");
            tx.GenerateList(count: 10);

            Filtre filtre = new Filtre(tx.ReadDataLine());

            filtre.NoFiltre();
            filtre.GetEvenNumber();

        }
    }
}
