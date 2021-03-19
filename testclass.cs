using System;
using Xunit;
using System.IO;

public class UnitTest1
{
    private const string Oczekiwane = "Hello World!";
    [Fact]
    public void Test1()
    {
        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);
            kartk2.Program.Main();

            var result = sw.ToString().Trim();
            Assert.Equal(Oczekiwane, result);
        }
    }
}