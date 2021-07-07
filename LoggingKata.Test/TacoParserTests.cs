using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        // test--   all four parts of the parser ( turn to string, lat, long, name all set correctly)
        // test--   use File.ReadAllLines(path) to grab all the lines from your csv file +  Log and error if you get 0 lines and a warning if you get 1 line
        // test--   Create two ITrackable variables with initial values of null. These will be used to store your two taco bells that are the farthest from each other.
        //          Create a double variable to store the distance
        //          Include the Geolocation toolbox, so you can compare locations: using GeoCoordinatePortable;

        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var parsed = tacoParser.Parse(line);
            var actual = parsed.Location.Longitude;

            //Assert
            Assert.Equal(expected, actual);
        }

        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Latitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var parsed = tacoParser.Parse(line);
            var actual = parsed.Location.Latitude;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseName(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Name.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var parsed = tacoParser.Parse(line);
            var actual = parsed.Location.Name;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GrabsCSVFile()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }
        
        [Theory]
        [InlineData()]
        public void ShouldLogCorrectly()
        {


            //Arrange

            //Act

            //Assert
        }

        [Theory]
        [InlineData()]
        public void ShouldCreateTwoWorkingVariables()
        {
            // Create two ITrackable variables with initial values of null. These will be used to store your two taco bells that are the farthest from each other.
            //          Create a double variable to store the distance
            //          Include the Geolocation toolbox, so you can compare locations: using GeoCoordinatePortable;

            //Arrange

            //Act

            //Assert
        }
    }
}
