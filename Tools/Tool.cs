using ModelContextProtocol.Server;
using System.ComponentModel;

[McpServerToolType]
public static class Tools
{
    [McpServerTool, Description("Adds two numbers.")]
    public static string Add(int a, int b) => $"The answer is {a + b}";

    [McpServerTool, Description("Reverses the message.")]
    public static string Reverse(string message) => new string(message.Reverse().ToArray());
}