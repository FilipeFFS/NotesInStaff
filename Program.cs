using NotesInSheet.Strategies;
namespace NotesInSheet
{
    public class Program
    {
        static void Main(string[] args)
        {
            var clefContext = new ClefContext();

            clefContext.SetStrategy();

            var continuePlaying = true;
            do
            {
                clefContext.TryNoteInStaff();

                Console.WriteLine("_____________________________________________\n");

                Console.WriteLine("Type 'y' to continue or anything else to stop");
                continuePlaying = Console.ReadLine() == "y";

                Console.Clear();
            } while (continuePlaying);
        }
    }
}