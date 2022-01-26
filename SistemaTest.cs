using System;
using Xunit;
using Metaverso;
namespace MetaversoTests
{
    public class SistemaTest
    {   
        Sistema sis = new Sistema();
        [Theory]
       
        [InlineData(15,"Metaverso")]
        [InlineData(5,"Verso")]
        [InlineData(3,"Meta")]
        [InlineData(8,"ocho")]
        public void Testmetaverso(int numero,string expected)
        {
            String resultado = sis.metaverso(num);
            Assert.Equal(resultado,expected);
        }
        [Theory]
        [InlineData(new int[0],"")]
        [InlineData(new int[]{15,1},"Metaverso")]
        
        
        public void MetaversoTest2(int[] numero, string expected){

            String resultado = sis.metaverso(num);
            Assert.Equal(resultado,expected);

        }
    }
}