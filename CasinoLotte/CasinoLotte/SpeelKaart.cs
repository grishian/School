using System;
using System.Collections.Generic;
using System.Text;

namespace CasinoLotte
{
    class SpeelKaart
    {
        //fields
        private string kaartId;
        private string spelerId;
        private double saldo;
        private List<double> transactieLijst = new List<double>();

        //getters en setters
        public string KaartId
        {
            get { return kaartId; }
            set { kaartId = value; }
        }

        public string SpelerId
        {
            get { return spelerId; }
            set { spelerId = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public List<double> TransactieLijst
        {
            get { return transactieLijst; }
            set { transactieLijst = value; }
        }

        //methods

    }
}
