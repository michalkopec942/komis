using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private float fCenaZakupu;
        private float fMarza;
        private int iRokProdukcji;
       

        private float Marza
        {
            get
            {
                return fMarza;
            }
        }

        private float CenaZakupu
        {
            get
            {
                return fCenaZakupu;
            }
        }

        private int RokProdukcji
        {
            get
            {
                return iRokProdukcji;
            }
        }
       void WyswietlRok()
        {

        }
       float podajCenaKoncowa()
        {
            float cenakoncowa;
            cenakoncowa = CenaZakupu + Marza;

            return cenakoncowa;
        }
        public abstract string 



    }

}
      
