using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAFE
{
    public class MenuDarurat
    {
        public int noTelpInstansi;
        public string keadaanDarurat;
        public string solusiPenanganan;
        public string infoKeadaan;  
    }

    class KeadaanDarurat : MenuDarurat
    {
        public void tampilkan_info(string infoKeadaan)
        {
            Console.WriteLine(infoKeadaan);
        }

        public void tampilkan_penanganan (string solusiPenanganan)
        {
            Console.WriteLine(solusiPenanganan);
        }
    }
}
