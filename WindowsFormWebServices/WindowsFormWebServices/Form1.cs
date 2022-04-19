using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormWebServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btn_Gönder_Click(object sender, EventArgs e)
        {
            /*
             * WEB SERVİSLER HTTP PROTOKOLUNU KULLANARAK HİZMET SAĞLARLAR
             * İSTEMCİ YANİ CLİENT İSTEK ATAR VE BİR GERİ DÖNÜŞ GERÇEKLEŞİR
             * BU GERİ DÖNÜŞŞTE KULLANILAN SERVİSE GÖRE XML,JSON VB YAPILAR KULLANILABİLİR
             * VE BİLGİ ALIŞVERİŞİ SAĞLANMIŞ OLUR
             * BURADA TEXTBOXLAR ÜZERİNDEN GİRİLEN VERİLER ALINIP SORGULAMA YAPILIR VE GERİ DÖNÜŞ OLARAK
             * TRUE YADA FALSE OLAN BOOL DEĞER DÖNDÜRDÜK.
             * AYRICA PROJEMİZE ADD SERVİCE REFERENCE DİYEREK DE URL MİZİ ALDIK
              */


            long kimlikno = long.Parse(txt_tc.Text);
            int yil = int.Parse(txt_yil.Text);
            bool durum;

            try
            {
                using (TcDogrula.KPSPublicSoapClient service = new TcDogrula.KPSPublicSoapClient { })
                {
                    durum = service.TCKimlikNoDogrula(kimlikno, txt_iaim.Text, TXT_sisim.Text, yil);
                }
            }

            catch(Exception)
            {
                throw;
            }
            MessageBox.Show(durum.ToString());
        }
    }
}
