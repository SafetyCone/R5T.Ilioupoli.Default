using System;using R5T.T0064;


namespace R5T.Ilioupoli.Default
{[ServiceImplementationMarker]
    public class TestingDataDirectoryContentConventions : ITestingDataDirectoryContentConventions,IServiceImplementation
    {
        public const string BasicTextFileNameValue = "Basic Text File.txt";

        // Visual Studio solution files.
        public const string ExampleVisualStudioSolutionFileNameValue = "R5T.Canterbury.Standard.sln";
        public const string NewVisualStudio2017SolutionFileNameValue = "New Solution-VS2017.sln";
        public const string NewVisualStudio2019SolutionFileNameValue = "New Solution-VS2019.sln";

        // Visual Studio project files.
        public const string ExampleVisualStudioProjectFileName01Value = "R5T.Kefalonia.Construction.csproj";
        public const string ExampleVisualStudioProjectFileName02Value = "R5T.Pickwich.Standard.Testing.csproj";


        public string BasicTextFileName => TestingDataDirectoryContentConventions.BasicTextFileNameValue;

        // Visual Studio solution files.
        public string ExampleVisualStudioSolutionFileName => TestingDataDirectoryContentConventions.ExampleVisualStudioSolutionFileNameValue;
        public string NewVisualStudio2017SolutionFileName => TestingDataDirectoryContentConventions.NewVisualStudio2017SolutionFileNameValue;
        public string NewVisualStudio2019SolutionFileName => TestingDataDirectoryContentConventions.NewVisualStudio2019SolutionFileNameValue;

        // Visual Studio project files.
        public string ExampleVisualStudioProjectFileName01 => TestingDataDirectoryContentConventions.ExampleVisualStudioProjectFileName01Value;
        public string ExampleVisualStudioProjectFileName02 => TestingDataDirectoryContentConventions.ExampleVisualStudioProjectFileName02Value;
    }
}
