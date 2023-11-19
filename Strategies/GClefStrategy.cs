namespace NotesInSheet.Strategies
{
    public class GClefStrategy : IClefStrategy
    {
        private readonly int PositionsToTakeOutOfTheStaffIndex = 8;

        private readonly static Dictionary<int, string> _gClefNotesPositions = new Dictionary<int, string>()
        {
            //ledger lines
            { 12, "E" },
            { 11, "D" },
            { 10, "C"},
            { 9, "B"},
            { 8, "A"},
            { 7, "G"},
            //staff
            { 6, "F" },
            { 5, "E" },
            { 4, "D" },
            { 3, "C" },
            { 2, "B" },
            { 1, "A" },
            { 0, "G" },
            { -1, "F" },
            { -2, "E" }, 
            //ledger lines
            { -3, "D" },
            { -4, "C" },
            { -5, "B" },
            { -6, "A" },
            { -7, "G" },
            { -8, "F" }
        };

        public string GetClefName() =>
            "G";

        public void ValidateAnswer(string answer, int randomNumber)
        {
            if (answer.ToLower() == _gClefNotesPositions[randomNumber - PositionsToTakeOutOfTheStaffIndex].ToLower())
                Console.WriteLine("Correct!");
            else
                Console.WriteLine($"Wrong, the right note is {_gClefNotesPositions[randomNumber - PositionsToTakeOutOfTheStaffIndex]}!");
        }
    }
}