using System;
using Xunit;
using Metaverso;
namespace MetaversoTest
{
    public class SistemaTest
    {   
        Sistema sis = new Sistema();
        [Theory]
       
        [InlineData(15,"Metaverso")]
        [InlineData(5,"Verso")]
        [InlineData(3,"Meta")]
        [InlineData(2,"2")]
        public void Testmetaverso(int numero,string expected)
        {
            
            
            String resultado = sis.metaverso(numero);

            Assert.Equal(resultado,expected);
        }
        [Theory]
        [InlineData(new int[0],"")]
        [InlineData(new int[]{15,1},"Metaverso1")]
        public void Testmetaverso2(int[] numero, string expected){

            String resultado = sis.metaverso(numero);
            Assert.Equal(resultado,expected);

        }
    }
}