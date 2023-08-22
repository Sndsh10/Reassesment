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
    public class TestBMICalculator{
        [Fact]
        public void TestBMIImperial()
        {

            Assert.Equal(21.426311728395063, BMICalculator.returnBMIImperial(6.0,0.0,11.0,4.0));
        }
        [Fact]
        public void TestBMIMetric()
        {
            Assert.Equal(18.591130340724717, BMICalculator.returnBMIMetric(1.72,55));
        }
    }
    public class TestStudentMarks{
        [Fact]
        public void TestReturnGrade()
        {
            Assert.Equal('A', StudentMarks.returnGrade(79.0));
        }
        [Fact]
        public void TestReturnGradeClassification()
        {
            Assert.Equal("Third class", StudentMarks.returnGradeClassification(45.0));
        }
    }
}

