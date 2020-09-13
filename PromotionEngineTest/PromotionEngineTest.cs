
using Promotion_Engine;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PromotionEngineTest
{
    public class PromotionEngineTest
    {
        [Fact]
        public void Invalid_Product_Type_Test()
        {
            //Arrange
            string type = "F";
        
            //Act
            var response= PromotionClass.GetProductPrice(type);

            //Assert
            Assert.Equal(0,response.Price);

        }
    }
}
