﻿namespace MoodAnalyzerProject
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

                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}