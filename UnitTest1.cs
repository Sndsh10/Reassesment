using Xunit;

namespace DistanceConverter{
    public class TestDistanceConverter
    {
        [Fact]
        public void TestFeetToMiles()
        {
            Assert.Equal("2.0", DistanceConverterClass.convertFeetToMiles(10560));
        }
        [Fact]
        public void TestFeetToMetres()
        {
            Assert.Equal("2.0", DistanceConverterClass.convertFeetToMetres(6.56168));
        }
        [Fact]
        public void TestMilesToFeet()
        {
            Assert.Equal("10560", DistanceConverterClass.convertMilesToFeet(2.0));
        }
        [Fact]
        public void TestMilesToMetres()
        {
            Assert.Equal("3218.69", DistanceConverterClass.convertMilesToMetres(2.0));
        }
        [Fact]
        public void TestMetresToMiles()
        {
            Assert.Equal("2.0", DistanceConverterClass.convertMetresToMiles(3218.69));
        }   
        [Fact]
        public void TestMetresToFeet()
        {
            Assert.Equal("6.56168", DistanceConverterClass.convertMetresToFeet(2.0));
        }
    }
}

