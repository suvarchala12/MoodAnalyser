using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProject;
using System.Text;
using System.Collections.Generic;

namespace MoodAnalyzerMSTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null)] //null input

        public void GivensadMoodShouldReturnSad()
        {
            //Arrange
            string message = "I am in sad mood";
            string expected = "SAD";

            MoodAnalyser moodAnalyse = new MoodAnalyser(message); //create instance

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }


    }

}