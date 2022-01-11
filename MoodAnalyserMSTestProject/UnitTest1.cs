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
        //Test Case 3.2 Given empty Mood should throw MoodException indicating Empty Mood.
        //Given-When-Then
        [TestMethod]
        public void Given_Empty_Should_Throw_MoodAnalyserException_Indication_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Mood should not be empty", ex.Message);
            }

        }
        //Test Case 3.3 Given Null Mood should throw MoodException indicating Null Mood.
        //Given-When-Then
        [TestMethod]
        public void Given_Null_Should_Throw_MoodAnalyserException_Indication_NullMood()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }
        //Test 4.1
        //To check objects we have created are same or not
        [TestMethod]
        public void Given_Mood_Analyzer_ClassName_Should_Return_Object()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
            //Assert.AreEqual(expected, obj); to check strings are equal or not
        }

        //Test 5.1
        [TestMethod]
        public void Given_Mood_Analyser_ClassName_Should_Return_Object_Using_Parameterised_Constructor()
        {
            //string message = "happy";
            object expected = new MoodAnalyser("sad");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserWithParameterizedConstructor("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser", "happy");
            expected.Equals(obj);
        }
    }

}