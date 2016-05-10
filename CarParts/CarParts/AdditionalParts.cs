using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParts
{
    class AdditionalParts : CarPartsMethods
    {
        string Model;
        int Year;
        public AdditionalParts()
        {

        }
        public AdditionalParts(string pParts, int pQyt, double pPrice, string pModel, int pYear)
       {
           this.setPrice(pPrice);
           this.setParts(pParts);
           this.setQyt(pQyt);
           this.Model = pModel;
           this.Year = pYear;
       }

        public void setModel(string pModel)
        {
            this.Model = pModel;
        }
        public string returnModel()
        {
            return Model;
        }
        public void setYear(int pYear)
        {
            this.Year = pYear;
        }
        public int returnYear()
        {
            return Year;
        }
    }
}
