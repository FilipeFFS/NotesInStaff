namespace NotesInSheet.Strategies
{
    public class FClefStrategy : IClefStrategy
    {
        private readonly int PositionsToTakeOutOfTheStaffIndex = 12;

        private readonly static Dictionary<int, string> _fClefNotesPositions = new Dictionary<int, string>()
        {
            //ledger lines
            { 8, "G" },
            { 7, "F" },
            { 6, "E"},
            { 5, "D"},
            { 4, "C"},
            { 3, "B"},
            //staff
            { 2, "A" },
            { 1, "G" },
            { 0, "F" },
            { -1, "E" },
            { -2, "D" },
            { -3, "C" },
            { -4, "B" },
            { -5, "A" },
            { -6, "G" }, 
            //ledger lines
            { -7, "F" },
            { -8, "E" },
            { -9, "D" },
            { -10, "C" },
            { -11, "B" },
            { -12, "A" }
        };

        public string GetClefName() =>
            "F";

        public void ValidateAnswer(string answer, int randomNumber)
        {
            if (answer.ToLower() == _fClefNotesPositions[randomNumber - PositionsToTakeOutOfTheStaffIndex].ToLower())
                Console.WriteLine("Correct!");
            else
                Console.WriteLine($"Wrong, the right note is {_fClefNotesPositions[randomNumber - PositionsToTakeOutOfTheStaffIndex]}!");
        }
    }
}