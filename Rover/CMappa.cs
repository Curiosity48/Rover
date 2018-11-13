using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover
{

    //Peduzzi Samuele 
    class CMappa
    {
        //Attributi
        //Punto contentente la posizione del rover 
        private Point pStart;
        //Vettori per la memorizzazione delle distanze
        private Point[] pDx, pSx;
        private int numEl;
        //Metodi
        public CMappa()
        {
            numEl = 0;
            pStart = new Point(0, 0);
        }
        //Permette di aggiungere due nuovi punti date la distanza da Dx e da Sx
        public void add(int distanzaDx, int distanzaSx)
        {
            pDx[numEl] = new Point(-distanzaDx, 0);
            pSx[numEl] = new Point(distanzaSx, 0);
            numEl++; //Viene incrementato il numero di punti salvati
        }
        //Metodo che permetto di variare gli attributi nel momento in cui il drone si muove 
        public void spostamentoRover(int distanza , int grado, int spostamento)
        {
            //TO DO
        }

    }
}
