using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProject
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OkulProjectDBEntities ef = new OkulProjectDBEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci yeniOgr = new Ogrenci();

            yeniOgr.ogrenciNo = txtOgrNo.Text;
            yeniOgr.adSoyad = txtAdSoyad.Text;
            yeniOgr.Adres = txtAdres.Text;

            ef.Ogrenci.Add(yeniOgr);
            ef.SaveChanges();
        }
    }
}
