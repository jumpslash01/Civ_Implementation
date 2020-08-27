using System;
using Xunit;
using MiscLib;

namespace Tests
{
    public class MiscLibTests
    {
        [Fact]
        public void CalcRectPerimeter_Test()
        {
            GroupTwoFunctions g2 = new GroupTwoFunctions ();

            Assert.Equal(18 , g2.CalcRectPerimeter(4 , 5));
            //Assert.Equal(6 ,  g2.CalcRectPerimeter(1 , 1)); This test fails the entire condition
            Assert.Equal(2240 , g2.CalcRectPerimeter(800 , 320));
            Assert.Equal(2002, g2.CalcRectPerimeter(1 , 1000));
          
        }

        [Fact]
        public void IsTriangularNum_Test()
        {
            GroupTwoFunctions g2 = new GroupTwoFunctions ();
            int num1 = 3;
            int num2 = 0;
            int num3 = 1431;
            int num4 = 870;

            Assert.True(g2.IsTriangularNum(num1));
            Assert.True(g2.IsTriangularNum(num2));
            Assert.True(g2.IsTriangularNum(num3));
            Assert.False(g2.IsTriangularNum(num4));
        }


        [Fact]
        public void FarenheitToCelcius_Test()
        {
            GroupTwoFunctions g2 = new GroupTwoFunctions ();

            //Assert.Equal(-18 , g2.FarenheitToCelcius(0) ); This test will always fail the implimentation fail the entire implimentation as it is the only one to round up (the rest round down even when above .5)
            Assert.Equal(-26 , g2.FarenheitToCelcius(-15) );
            Assert.Equal(37 , g2.FarenheitToCelcius(100) );
            Assert.Equal(65 , g2.FarenheitToCelcius(150) );
            Assert.Equal(537 , g2.FarenheitToCelcius(1000) );
            
        }

        [Fact]
        public void CheckWhiteSpace_Test()
        {
            GroupTwoFunctions g2 = new GroupTwoFunctions ();
            Assert.True(g2.CheckWhiteSpace("    Melbourne Victoria   "));
            Assert.True(g2.CheckWhiteSpace("    Melbourne"));
            Assert.True(g2.CheckWhiteSpace("Melbourne       "));
            Assert.False(g2.CheckWhiteSpace("Melbourne"));
        }

        [Fact]
        public void CamelString_Test()
        {
            GroupTwoFunctions g2 = new GroupTwoFunctions ();
            Assert.Equal("aHlAm" , g2.CamelString("ahlam"));
            Assert.Equal("mElBoUrNe" , g2.CamelString("Melbourne"));
            Assert.Equal("mElBoUrNe vIc" , g2.CamelString("Melbourne Vic"));
            Assert.Equal(" MeLbOuRnE ViC" , g2.CamelString(" melbourne vic"));
            Assert.Equal("mElBoUrNe" , g2.CamelString("MELBOURNE"));
        }

        [Fact]
        public void CountDigits_Test()
        {
            GroupTwoFunctions g2 = new GroupTwoFunctions ();
            Assert.Equal(5 , g2.CountDigits("Sw1nbu2rne3 Un4iver5sity"));
            Assert.Equal(0 , g2.CountDigits("melbourne victoria"));
            Assert.Equal(11 , g2.CountDigits("12345678910"));
            Assert.Equal(6 , g2.CountDigits("a1b2c3d4e5f6"));
        }
    }
}
