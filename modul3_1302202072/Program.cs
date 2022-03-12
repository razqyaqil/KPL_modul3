// See https://aka.ms/new-console-template for more information
using System;

namespace modul3_1302202072 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public void Main(string[] args)
        {
            
            Console.WriteLine("PISANG :",kodeBuah.getKodeBuah(kodeBuah.buah.Pisang));


            PosisiKarakterGame posisiChar = new PosisiKarakterGame();

            posisiChar.activateGerak(tombol.TombolW);
            Console.WriteLine(posisiChar.currentState);

            posisiChar.activateGerak(tombol.TombolX);
            Console.WriteLine(posisiChar.currentState);

            posisiChar.activateGerak(tombol.TombolS);
            Console.WriteLine(posisiChar.currentState);

            posisiChar.activateGerak(tombol.TombolW);
            posisiChar.activateGerak(tombol.TombolW);
            Console.WriteLine(posisiChar.currentState);




        }
    }
}
