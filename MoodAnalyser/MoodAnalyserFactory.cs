﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MoodAnalyzerProject
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (Exception ex)
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
            {
                throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
            }

        }
        public static object CreateMoodAnalyserWithParameterizedConstructor(string Classname, string ConstructorName, string message)
        {

            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(Classname) || type.FullName.Equals(Classname))
            {
                if (type.Name.Equals(ConstructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    Object instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");

                }
            }
            else
            {
                throw new ExceptionTest(ExceptionTest.ExceptionType.NO_SUCH_CLASS, "Class Not Found");

            }
        }
    }
}