
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("Hello, World!");
Console.WriteLine($"OS: {Environment.OSVersion}");
Console.WriteLine($"App Version: {version}");