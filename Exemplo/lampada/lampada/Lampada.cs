using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lampada
{
    public class Lampada
    {
        private bool ligada { get; set; }
        private string? Cor { get; set; }
        private int Potencia { get; set; }

        public void ligar()
        {

            ligada = true;

        }

        public void Desligar()
        {

            ligada = false;

        }

        public bool estaLigada()
        {

            return ligada;

        }

        //COR

        public void Cores()
        {
            Cor = "red";
        }

        public string qualCor()
        {

            return Cor;

        }

        //Potencia

        public void Pot()
        {

            Potencia = 120;

        }

        public int qualPot()
        {

            return Potencia;

        }


    }
}
