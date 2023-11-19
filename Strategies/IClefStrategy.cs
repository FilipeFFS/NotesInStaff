namespace NotesInSheet.Strategies
{
    public interface IClefStrategy
    {
        string GetClefName();
        void ValidateAnswer(string answer, int randomNumber);
    }
}