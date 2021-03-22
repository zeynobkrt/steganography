using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Steganografi_bitirme
{
    public partial class Form1 : Form
    {
        #region Properties
        //lsb
        private Bitmap bmp = null;
        String dyolu;
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods

        // algo
        public int[] SayiUret(int uzunluk)
        {
            int[] dizi = new int[uzunluk];
            Random rndm = new Random();
            for (int i = 0; i < uzunluk; i++)
            {
                dizi[i] = rndm.Next(1, 9);
            }
            return dizi;

        }
        //algo bitiş

        public static Bitmap resizeImage(Bitmap imgToResize, Size size)
        {
            return (new Bitmap(imgToResize, size));
        }

        private void Sifreleme()
        {
            int[] sifre = SayiUret(txtMesaj.TextLength);
            try
            {
                int seviye = combo_seviye.SelectedIndex;
                Bitmap image = new Bitmap(dyolu);
                image = resizeImage(image, new Size(387, 244));
                picIsleme.Image = (Image)image;

                //kaydırmalı algoritmalar 
                switch (seviye)
                {
                    case 1:
                        for (int i = 0; i < image.Width; i++)
                        {
                            for (int j = 0; j < image.Height; j++)
                            {
                                Color piksel = image.GetPixel(i, j);
                                if (i < 1 && j < txtMesaj.TextLength)
                                {
                                    char mesaj = Convert.ToChar(txtMesaj.Text.Substring(j, 1));
                                    int AsciDeger = Convert.ToInt32(mesaj) + sifre[j];
                                    image.SetPixel(i, j, Color.FromArgb(piksel.R, piksel.G, AsciDeger));
                                }

                                if (i == image.Width - 1 && j == image.Height - 1)
                                {
                                    image.SetPixel(i, j, Color.FromArgb(piksel.R, piksel.G, txtMesaj.TextLength));
                                }
                            }
                        }

                        for (int j = 0; j < txtMesaj.TextLength; j++)
                        {
                            Color piksel = image.GetPixel(image.Width - 1, j);
                            image.SetPixel(image.Width - 1, j, Color.FromArgb(piksel.R, piksel.G, sifre[j]));
                        }

                        break;

                    case 2:
                        Random random = new Random();
                        for (int i = 0; i < txtMesaj.TextLength; i++)
                        {
                            int satir = random.Next(1, 256);
                            int sutun = random.Next(1, 256);
                            Color piksel = image.GetPixel(satir, sutun);
                            char mesaj = Convert.ToChar(txtMesaj.Text.Substring(i, 1));
                            int AsciDeger = Convert.ToInt32(mesaj);
                            image.SetPixel(satir, sutun, Color.FromArgb(piksel.R, AsciDeger, piksel.B));

                            txtAnahtar.Text += Convert.ToChar(satir);
                            txtAnahtar.Text += Convert.ToChar(sutun);
                        }

                        MessageBox.Show("Fotoğrafı Kaydettikten sonra Anahtar Değerini mutlaka bir yere Kaydediniz");
                        break;

                    default:
                        MessageBox.Show("Lütfen şifreleme Seviyesi giriniz");
                        break;
                }

                if (combo_seviye.SelectedIndex != 0)
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    saveFile.Filter = "Image Files(*.png,*.jpg) | *.png;*.jpg";

                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        dyolu = saveFile.FileName.ToString();
                        picIsleme.ImageLocation = dyolu;

                        image.Save(dyolu);
                    }

                    txtAnahtar.Visible = true;
                    lbl_anahtar.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SifreCoz()
        {
            label2.Text = "";
            switch (combo_seviye.SelectedIndex)
            {
                case 1:
                    try
                    {
                        Bitmap image = new Bitmap(dyolu);
                        string anamesaj = "";
                        Color sonpiksel = image.GetPixel(image.Width - 1, image.Height - 1);
                        int mesajuzunlugu = sonpiksel.B;
                        int[] sifre = new int[mesajuzunlugu];
                        for (int j = 0; j < mesajuzunlugu; j++)
                        {
                            Color piksel = image.GetPixel(image.Width - 1, j);
                            sifre[j] = piksel.B;
                        }

                        for (int i = 0; i < image.Width; i++)
                        {
                            for (int j = 0; j < image.Height; j++)
                            {
                                Color piksel = image.GetPixel(i, j);
                                if (i < 1 && j < mesajuzunlugu)
                                {
                                    int deger = piksel.B;
                                    char c = Convert.ToChar(deger - sifre[j]);
                                    string harf = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                                    anamesaj = anamesaj + harf;
                                }
                            }
                        }


                        txtMesaj.Text = anamesaj;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
                case 2:
                    if (txtAnahtar.Text != "")
                    {
                        try
                        {
                            Bitmap image = new Bitmap(dyolu);
                            for (int i = 0; i < txtAnahtar.TextLength; i += 2)
                            {
                                char satir = Convert.ToChar(txtAnahtar.Text.Substring(i, 1));
                                char sutun = Convert.ToChar(txtAnahtar.Text.Substring(i + 1, 1));
                                Color piksel = image.GetPixel(Convert.ToInt32(satir), Convert.ToInt32(sutun));
                                char c = Convert.ToChar(piksel.G);
                                string harf = System.Text.Encoding.ASCII.GetString(new byte[] { Convert.ToByte(c) });
                                label2.Text += harf;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Anahtar Değerini giriniz");
                    }

                    break;
                default:
                    MessageBox.Show("Şifrelenme Seviyesini Seçiniz Bilmiyorsanız resmi gönderen kişi ile temasa geçiniz");
                    break;
            }
        }

        #endregion

        #region Clicks

        private void btn_ac_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Resim Dosyaları (*.png,*.bmp,*.jpg)|*.png;*.bmp;*.jpg";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picIsleme.Image = Image.FromFile(dialog.FileName);
                btn_gizle.Enabled = true;
            }
            int lsb1, lsb2;
            for (int i = 0; i < picIsleme.Height; i++)
            {
                for (int j = 0; j < picIsleme.Width; j++)
                {
                    lsb1 = picIsleme.Height * picIsleme.Width * 3;
                    lsb2 = lsb1 / 8;
                    toolStripSayi.Text = lsb2.ToString();
                }
            }
        }

        private void btn_gizle_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Açılmıyor");
            bmp = (Bitmap)picIsleme.Image;
            string yazi = txtMesaj.Text;
            bmp = stego_lsb.yaziGizle(yazi, bmp);
            MessageBox.Show("İşlendi.");
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }

            }
        }

        private void btnCoz_Click_1(object sender, EventArgs e)
        {
            bmp = (Bitmap)picIsleme.Image;
            string coz = stego_lsb.Coz(bmp);
            txtMesaj.Text = "";
            txtMesaj.Text = coz;
        }

        /*Algoritmalar*/
        private void combo_seviye_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (combo_seviye.Text == "1")
            {
                txtAnahtar.Visible = false;
            }
            else
            {
                txtAnahtar.Visible = true;
            }
            //txtAnahtar.Visible = true;
            lbl_anahtar.Visible = true;
        }

        private void btn2_Ac_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.png,*.jpg) | *.png;*.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dyolu = dialog.FileName.ToString();
                Bitmap image = new Bitmap(dyolu);
                image = resizeImage(image, new Size(387, 244));
                picIsleme.Image = (Image)image;
                //dosyayolu.Enabled = false;
            }
        }

        private void btn_Sifrele_Click_1(object sender, EventArgs e)
        {
            Sifreleme();
        }

        private void btn_Sifre_Coz_Click_1(object sender, EventArgs e)
        {
            SifreCoz();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinize emin misiniz? ", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
            else return;
        }

        #endregion
    }
}
