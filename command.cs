using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAT
{
    public class command
    {
        baglanti baglanti = new baglanti();
        public OleDbCommand komut(string sorgu)
        {
            OleDbCommand kmt = new OleDbCommand(sorgu,baglanti.bglantiac());
            return kmt;

        }
    }
}
