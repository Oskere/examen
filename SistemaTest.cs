using System;
using Xunit;
using Metaverso;
namespace MetaversoTests
{
    public class SistemaTest
    {   
        Sistema sis = new Sistema();
        [Theory]
       
        [InlineData(16,"16")]
        [InlineData(12,"Meta")]
        [InlineData(25,"Verso")]
        [InlineData(45,"Metaverso")]
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
