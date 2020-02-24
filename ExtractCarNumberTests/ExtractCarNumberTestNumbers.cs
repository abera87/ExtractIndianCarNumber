using Xunit;
using System.Collections.Generic;
using CarNumberExtractorHelper;

namespace ExtractCarNumberTests
{
    public class ExtractCarNumberTestsNumbers
    {
        [Theory]
        [InlineData("AP87H6792")]
        [InlineData("WB89BB4573")]
        public void IsValidCarNumber(string carNumber)
        {
            List<string> r = CarNumberExtractor.NumberExtractorRegEx(carNumber);
            var a = r[0];
            Assert.Equal(carNumber, a);
        }
        [Fact]
        public void IsContainAllNumbers()
        {
            List<string> actualNumbers = new List<string> { 
                                                "WB09J3487", 
                                                "WB89BB4573", 
                                                "WB77AP4571", 
                                                "AP87H6792" 
                                                };
            List<string> r = CarNumberExtractor.NumberExtractorRegEx("WB09J3487WB89BB4573 WB77AP4571  ;AP87H6792");
            Assert.All(actualNumbers,n=>Assert.Contains<string>(n,r));
        }
    }
}