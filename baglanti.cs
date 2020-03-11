using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAT
{
    public class baglanti
    {
        OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + "KutuphaneO1.accdb");
        public OleDbConnection bglantiac()
        {
            Baglanti.Open();
            return Baglanti;
        }
        public OleDbConnection baglantikapat()
        {
            Baglanti.Close();
            return Baglanti;
        }
    }
}
