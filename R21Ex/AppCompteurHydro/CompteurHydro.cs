using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCompteurHydro
{
<<<<<<< HEAD
    public class CompteurHydro : ICompteurHydro
    {
        //Stocker la consommation actuelle exprimée en Kwh
        private int m_consommationActuelle;


        public int ConsommationActuelle
        {
            get { return m_consommationActuelle; }
        }


        public CompteurHydro()
        {
            m_consommationActuelle = 0;
        }
        /// <summary>
        /// Mettre a jour la consommation actuelle selon la qualité consomée
        /// </summary>
        /// <param name="pQuantitéKwh"></param>
        public void Consommer(int pQuantitéKwh)
        {
            m_consommationActuelle += pQuantitéKwh;
        }
=======
    internal class CompteurHydro
    {
>>>>>>> 718203c06c33580d0ee8e7b2dcdd5f8f979e576a
    }
}
