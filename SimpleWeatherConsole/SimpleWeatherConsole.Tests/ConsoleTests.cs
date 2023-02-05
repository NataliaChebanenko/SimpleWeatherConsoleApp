using System.Globalization;

namespace SimpleWeatherConsole.Tests;

public class ConsoleTests
{
    [Theory]
    [InlineData("55.55", 55.55f)]
    [InlineData("not a number", 0f)]
    public void TestConsoleFloatInput(string input, float expected)
    {
        // Arrange


        using (var inputStream = new StringReader(input))
            using (var outputStream = new StringWriter())
        {
            Console.SetIn(inputStream);
            Console.SetOut(outputStream);
            var output = GetFloatInput(input);
            Assert.Equal(Math.Round(expected, 2), Math.Round(output, 2));

        }

       
    }

    public static float GetFloatInput(string input)
    {
        while (true)
        {
            if (float.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out float result))
            {
                return result;
            }
            else
            {
                throw new Exception("Invalid input");
            }

        }
    }
}
