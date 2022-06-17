using aydos_otoyedek.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aydos_otoyedek.BL
{
   static class BLogic
    {
        public static bool MüşteriEkle(Musteri m)
        {
            try
            {
                int res = DataLayer.MusteriEkle(m);
                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet Müşterigetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.Müşterigetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool MüşteriGüncelle(Musteri m)
        {
            try
            {
                int res = DataLayer.MüşteriGüncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool SatisEkle(Satis s)
        {
            try
            {
                int res = DataLayer.SatisEkle(s);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet SatisDetay()
        {
            try
            {
                DataSet ds = DataLayer.SatisDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool MüşteriSil(string no)
        {
            try
            {
                int res = DataLayer.MüşteriSil(no);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool UrunEkle(Urun u)
        {
            try
            {
                int res = DataLayer.UrunEkle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.UrunGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return null;
            }
        }

        internal static bool UrunGüncelle(Urun u)
        {
            try
            {
                int res = DataLayer.UrunGüncelle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool UrunSil(string no)
        {
            try
            {
                int res = DataLayer.UrunSil(no);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu:" + ex.Message);
                return false;
            }
        }
    }
}
