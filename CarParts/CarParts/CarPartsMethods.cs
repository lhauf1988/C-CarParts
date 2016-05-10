//Lucas Hauf
//Pos 409
//12/22/2015
//this program was made to allow the user to calcualte thier car part based on the constructor they choose to use 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParts
{
    class CarPartsMethods
    {
        string Parts;
        int Qyt;
        double Price;

       public CarPartsMethods()
        {

        }
       public CarPartsMethods(string pParts, int pQyt, double pPrice)
       {
           this.Price = pPrice;
           this.Parts = pParts;
           this.Qyt = pQyt;
       }
        public void setParts(string pParts)
        {
            this.Parts = pParts;
        }
        public string returnParts()
        {
            return Parts;
        }
        public void setQyt(int pQyt)
        {
            this.Qyt = pQyt;
        }
        public int returnQyt()
        {
            return Qyt;
        }
        public void setPrice(double pPrice)
        {
            this.Price = pPrice;
        }
        public double TotalWithTax()
        {
            double Total = 0;
            Total = Qyt * Price ;
            return Total;
        }
    }
}
