namespace Notenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Willkommen beim Notenrechner");
            double BenutzerNote = Noteneingabe();





        }
        static double Noteneingabe()
        {
            double Note = 0;
            Boolean isCorrectInput = false;
            while (!isCorrectInput)
            {
                try
                {
                    Console.WriteLine("Geben sie ihre Note ein: ");
                    Note = Convert.ToDouble(Console.ReadLine());

                    if (Note < 1 || Note > 6)
                    {
                        throw new Exception();
                    } else
                    {
                        isCorrectInput = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
            }
            return Note;

        }
    }
}

