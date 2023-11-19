namespace NotesInSheet.Strategies
{
    public class ClefContext
    {
        private IClefStrategy _strategy;

        public void SetStrategy()
        {
            Console.WriteLine("Select a clef: G or F");
            var selectedClef = Console.ReadLine().ToUpper();

            if (selectedClef.Equals("G"))
                _strategy = new GClefStrategy();
            else if (selectedClef.Equals("F"))
                _strategy = new FClefStrategy();
            else
                throw new ArgumentException();
        }

        public void TryNoteInStaff()
        {
            var random = new Random();
            var staff = new Staff();

            var randomNumber = random.Next(staff.QuantityOfLinesAndSpaces);

            Console.WriteLine($"Clef: {_strategy.GetClefName()}.");
            staff.PrintStaff(randomNumber);

            Console.WriteLine("What is the note?");
            var answer = Console.ReadLine();

            _strategy.ValidateAnswer(answer, randomNumber);
        }
    }
}