using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Factory
    {
        public static Product SetMilkFactory(this Product baseProduct, int codeFactory)
        {
            switch (codeFactory)
            {
                case 1:
                    baseProduct.Factory= "INTI";
                    break;
                case 2:
                    baseProduct.Factory = "NESTLE";
                    break;
                case 3:
                    baseProduct.Factory = "BAGO";
                    break;
            }
            return baseProduct;
        }

        public static Product SetShampooFactory(this Product baseProduct, int codeFactory)
        {
            
            switch (codeFactory)
            {
                case 1:
                    baseProduct.Factory = "UNILEVER";
                    break;
                case 2:
                    baseProduct.Factory = "WELLA";
                    break;
                case 3:
                    baseProduct.Factory = "Loreal";
                    break;
            }
            return baseProduct;
        }
    }
}
