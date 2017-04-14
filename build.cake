var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");
var outputDir = "./artifacts/";
var solutionPath = System.IO.Directory.GetFiles(".", "*.sln", SearchOption.AllDirectories).First();

Task("Clean")
  .Does(() => {
    if (DirectoryExists(outputDir))
    {
      DeleteDirectory(outputDir, recursive:true);
    }
    CreateDirectory(outputDir);
  });

Task("Restore")
  .Does(() => {
    DotNetCoreRestore(solutionPath);
  });

Task("Build")
  .IsDependentOn("Clean")
  .IsDependentOn("Restore")
  .Does(() => {
    var settings =  new DotNetCoreBuildSettings
    {
      Configuration = configuration
    };
    DotNetCoreBuild(solutionPath, settings);
  });

Task("Default")
  .IsDependentOn("Build");

RunTarget(target);