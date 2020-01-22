using System;


namespace R5T.Ilioupoli.Default
{
    public class TestingDataDirectoryContentConventions : ITestingDataDirectoryContentConventions
    {
        public const string BasicTextFileNameValue = "Basic Text File.txt";


        public string BasicTextFileName => TestingDataDirectoryContentConventions.BasicTextFileNameValue;
    }
}
