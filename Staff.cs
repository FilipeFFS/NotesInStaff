namespace NotesInSheet
{
    public class Staff
    {
        private static string[] _staff = GetEmptyStaff();
        public int QuantityOfLinesAndSpaces { get { return 20; } }

        public void PrintStaff(int randomNumber)
        {
            var positionOnStaff = randomNumber;
            var positionToSetNoteInStaff = 28;
            var staff = new string[_staff.Length];
            _staff.CopyTo(staff, 0);

            var lineToReplaceInStaff = staff[positionOnStaff].Remove(positionToSetNoteInStaff, 1).Insert(positionToSetNoteInStaff, "O");
            staff[positionOnStaff] = lineToReplaceInStaff;

            for (int i = staff.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(staff[i]);
            }
        }

        private static string[] GetEmptyStaff()
        {
            var ledgerLine = "                     ---------------";
            var ledgerSpace = "                                    ";

            var downLedgerLines = new string[6]
            {
                ledgerLine, ledgerSpace, ledgerLine, ledgerSpace, ledgerLine, ledgerSpace
            };

            var topLedgerLines = new string[6]
            {
                ledgerSpace, ledgerLine, ledgerSpace, ledgerLine, ledgerSpace, ledgerLine
            };

            var line = "|-------------------------------------------------------------------------|";
            var space = "|                                                                         |";
            var defaultStaff = new string[]
            {
                line, space, line, space, line, space, line, space, line
            };
            var staff = new List<string>();
            staff.AddRange(downLedgerLines);
            staff.AddRange(defaultStaff);
            staff.AddRange(topLedgerLines);
            return staff.ToArray();
        }
    }
}