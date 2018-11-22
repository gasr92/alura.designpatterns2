using DesignPatterns2.Cap2;
using System.Collections.Generic;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cap2(); // Flyweight
        }

        private static void Cap2()
        {
            // Forma errada
            //new List<INota>()
            //{
            //    new Do (), new Re(), new Mi(), new Fa(), new Fa(), new Fa()
            //};

            var notas = new NotasMusicais();
            var musica = new List<INota>()
            {
                notas.Pega("sol"),
                notas.Pega("la"),
                notas.Pega("si"),
                notas.Pega("do"),
            };

            var piano = new Piano();
            piano.Tocar(musica);
        }
    }
}