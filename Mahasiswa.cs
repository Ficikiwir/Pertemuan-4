using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Input_Data_Mahasiswa
{
    class Mahasiswa
    {
        public String Nim;
        public String Nama;
        public String Kelas;
        private int nilai;
        public String nilaihuruf;

        public int Nilai
        {
            get { return nilai; }
            set
            {
                int val = value;
                nilai = val;
                if (val > 81)
                {
                    nilaihuruf = "A";
                }
                else if (val > 61)
                {
                    nilaihuruf = "B";
                }
                else if (val > 41)
                {
                    nilaihuruf = "C";
                }
                else if (val > 21)
                {
                    nilaihuruf = "D";
                }
                else if (val > 0)
                {
                    nilaihuruf = "E";
                }
            }
        }



    }
}
