using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class sepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi..." + urun.Adi);
        }
    }
}
