namespace MoodAnalyzerProject
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {

            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.EMPTY_MESSAGE, "Mood Should Not Be Empty");
                }

                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new ExceptionTest(ExceptionTest.ExceptionType.NULL_MESSAGE, "Mood Should Not Be Null");
            }
        }
    }
}