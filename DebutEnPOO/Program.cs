using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebutEnPOO
{
    class Voiture
    {
        private int _vitesse = 50;
        private int _annee;
        private string _immatriculation;
        private string _marque;

        ///Constructeur
        public Voiture()
        {
            this.Vitesse = 50;
        }
        public Voiture(int vitesse)
        {
            this.Vitesse = vitesse;
        }
        public Voiture(int vitesse, int annee)
        {
            this.Annee = annee;
            this.Vitesse = vitesse;
        }

        ///Getters and Setters
        public int Vitesse
        {
            get { return _vitesse; }
            set { _vitesse = value; }
        }
        public int Annee
        {
            get { return _annee; }
            set { _annee = value; }
        }
        public string Immatriculation
        {
            get { return _immatriculation; }
            set { _immatriculation = value; }
        }
        public string Marque
        {
            get { return _marque; }
            set { _marque = value; }
        }


        static void Main(string[] args)
        {
            ///DATA
            ///TRAITEMENT
            ///OUTPUT
        }
    }
}
