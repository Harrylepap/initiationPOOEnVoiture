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
            Voiture evoque = new Voiture();
            Voiture bmw = new Voiture(10);

            ///TRAITEMENT


            ///OUTPUT
            Console.WriteLine("Vitesse de mon evoque de depart : "+evoque.Vitesse);
            Console.WriteLine("Vitesse de ma BMW de depart : "+bmw.Vitesse);
            evoque.ralentir();
            bmw.avancer();
            Console.WriteLine("Soudain, la BMW accelere rapidement");
            bmw.avancer();
            bmw.avancer();
            Console.WriteLine("Vitesse de mon evoque après ralentissement : " + evoque.Vitesse);
            Console.WriteLine("Vitesse de mon BMW après ralentissement : " + evoque.Vitesse);

            Console.ReadLine();
        }

        public int avancer()
        {
            return this.Vitesse = this.Vitesse + 10;
        }
        public int ralentir()
        {
            return this.Vitesse = this.Vitesse - 10;
        }
    }
}
