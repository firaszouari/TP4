using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Produit
    {
        public string ref_prod { get; set; }
        public string desig_prod { get; set; }
        public string categ_prod { get; set; }
        public decimal prixv_prod { get; set; }

        public int qte_stk_prod { get; set; }
    }
}
