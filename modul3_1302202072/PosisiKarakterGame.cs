using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul3_1302202072
{
    public enum stateKarakter
    {
        Jongkok,
        Berdiri,
        Tengkurap,
        Terbang
    }
    public enum tombol
    {
        TombolW,
        TombolS,
        TombolX
    }
    public class PosisiKarakterGame
    {
  

        public stateKarakter prevState;
        public stateKarakter nextState;
        public stateKarakter currentState;

        public tombol tombolPencet;
        
        public PosisiKarakterGame()
        {
            currentState = stateKarakter.Berdiri;
        }
        
        public PosisiKarakterGame(stateKarakter prevState, stateKarakter nextState, tombol tombolPencet)
        {
            this.prevState = prevState;
            this.nextState = nextState;
            this.tombolPencet = tombolPencet;

        }

        PosisiKarakterGame[] posisiKarakterGames =
        {
            new PosisiKarakterGame(stateKarakter.Berdiri, stateKarakter.Terbang, tombol.TombolW),
            new PosisiKarakterGame(stateKarakter.Berdiri, stateKarakter.Jongkok, tombol.TombolS),
            new PosisiKarakterGame(stateKarakter.Jongkok, stateKarakter.Berdiri, tombol.TombolW),
            new PosisiKarakterGame(stateKarakter.Jongkok, stateKarakter.Tengkurap, tombol.TombolS),
            new PosisiKarakterGame(stateKarakter.Tengkurap, stateKarakter.Jongkok, tombol.TombolW),
            new PosisiKarakterGame(stateKarakter.Terbang, stateKarakter.Berdiri, tombol.TombolS),
            new PosisiKarakterGame(stateKarakter.Terbang, stateKarakter.Jongkok, tombol.TombolX)
        };

        public stateKarakter gerak(stateKarakter prevState, tombol Tombol)
        {
            stateKarakter nextState = prevState;

            for (int i = 0; i < posisiKarakterGames.Length; i++)
            {
                if(posisiKarakterGames[i].prevState == prevState && posisiKarakterGames[i].tombolPencet == Tombol)
                {
                    nextState = posisiKarakterGames[i].nextState;
                }


            }
            return nextState;
        }

        public void activateGerak(tombol Tombol)
        {
            nextState = gerak(currentState, Tombol);
            currentState = nextState;

        }




    }
}
