namespace WannwirstduAlt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie alt sind sie?: ");
            int Alter = Convert.ToInt32(Console.ReadLine());

            double Summe = 46 - Alter;
            double Altesalter = Summe + Alter;
            Console.WriteLine("In " + Summe + " werden sie " + Altesalter + " alt:");
        }
    }
}