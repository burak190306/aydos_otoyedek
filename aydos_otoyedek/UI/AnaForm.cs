using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aydos_otoyedek.BL;
using aydos_otoyedek.UI;

namespace aydos_otoyedek.UI
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        Müşteriler mf = new Müşteriler();
        Ürünler uf = new Ürünler();

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();

        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            FrmSatis frm = new FrmSatis()
            {
                Text = "Satış Yap",
                Satis = new Satis()
                {
                    NO = Guid.NewGuid()
                }
            };


        
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisEkle(frm.Satis);
                //    if (b)
                //    {


                //        DataSet ds = BLogic.Müşterigetir("");
                //        if (ds != null)
                //            dataGridView1.DataSource = ds.Tables[0];


                //    }
                //    else
                //        goto tekrar;
                //}
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SatisDetay();
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
        }
    }
}

