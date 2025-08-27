using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Marché_RomainSchertenleib
{
    public class Product
    {
        public int emplacement { get; set; }
        public string Producteur { get; set; }
        public string Produit { get; set; }
        public int Quantité { get; set; }
        public int Unité { get; set; }
        public double prixparunité { get; set; }
    }
}
