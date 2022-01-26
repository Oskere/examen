using System;

namespace Metaverso
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new Sistema();
            Console.WriteLine(sistema.Saludo("Hola, bienvenido al programa del Metaverso"));
        }
    }
}
