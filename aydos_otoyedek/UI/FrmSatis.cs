using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aydos_otoyedek.UI
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }
       
        public Satis Satis { get; set; }

  

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (nmFiyat.Value == 0)
            {
                errorProvider1.SetError(nmFiyat, "Lütfen Fiyat Giriniz");
                nmFiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }
            Satis.Tarih = dtTarih.Value;
            Satis.Fiyat = (double)nmFiyat.Value;
            Satis.UrunNO = Guid.Parse(txtUrun.Text);
            Satis.MusteriNO = Guid.Parse(txtMusteri.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
            DialogResult = DialogResult.Cancel;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            txtID.Text = Satis.NO.ToString();
            
            
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Müşteriler frm = new Müşteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
                txtMusteri.Text = frm.Musteri.NO.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ürünler frm = new Ürünler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
                txtUrun.Text = frm.Urun.NO.ToString();
            }

        }
    }
}
