using System;


namespace R5T.Ilioupoli.Default
{
    public class TestingDataDirectoryContentConventions : ITestingDataDirectoryContentConventions
    {
        public const string BasicTextFileNameValue = "Basic Text File.txt";

        public const string ExampleVisualStudioSolutionFileNameValue = "R5T.Canterbury.Standard.sln";
        public const string NewVisualStudio2017SolutionFileNameValue = "New Solution-VS2017.sln";
        public const string NewVisualStudio2019SolutionFileNameValue = "New Solution-VS2019.sln";


        public string BasicTextFileName => TestingDataDirectoryContentConventions.BasicTextFileNameValue;

        public string ExampleVisualStudioSolutionFileName => TestingDataDirectoryContentConventions.ExampleVisualStudioSolutionFileNameValue;
        public string NewVisualStudio2017SolutionFileName => TestingDataDirectoryContentConventions.NewVisualStudio2017SolutionFileNameValue;
        public string NewVisualStudio2019SolutionFileName => TestingDataDirectoryContentConventions.NewVisualStudio2019SolutionFileNameValue;
    }
}
