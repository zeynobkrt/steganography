using System;
using System.Drawing;

namespace Steganografi_bitirme
{
    class stego_lsb
    {
        public enum Durum
        {
            Gizle, sifirUzunluk
        };
        public static Bitmap yaziGizle(string yazi, Bitmap bmp)
        {
            Durum durum = Durum.Gizle;
            int charIndex = 0; 
            int charValue = 0;
            long pixelElementIndex = 0;
            int sifirSayisi = 0;
            int R = 0, G = 0, B = 0;

            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);
                    R = pixel.R - pixel.R % 2;//010001 değeri 101 ise 010000 değeri 100 olacaktır gibi
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    for (int n = 0; n < 3; n++) 
                    {
                        if (pixelElementIndex % 8 == 0)
                        {
                            if (durum == Durum.sifirUzunluk && sifirSayisi == 8)
                            {
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                return bmp;
                            }
                            if (charIndex >= yazi.Length)
                            {
                                durum = Durum.sifirUzunluk;
                            }
                            else
                            {
                                charValue = yazi[charIndex++];

                                Console.WriteLine(charValue);
                            }
                        }

                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (durum == Durum.Gizle)
                                    {
                                        R += charValue % 2;
                                        charValue /= 2;

                                        Console.WriteLine(R.ToString());
                                    }
                                    break;
                                }

                            case 1:
                                {
                                    if (durum == Durum.Gizle)
                                    {
                                        G += charValue % 2;
                                        charValue /= 2;

                                        Console.WriteLine(G.ToString());
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    if (durum == Durum.Gizle)
                                    {
                                        B += charValue % 2;
                                        charValue /= 2;

                                        Console.WriteLine(B.ToString());
                                    }
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        pixelElementIndex++;
                        if (durum == Durum.sifirUzunluk)
                        {
                            sifirSayisi++;
                        }
                    }

                }

            }

            return bmp;
        }

        //Çözümleme Kısmı
        public static string Coz(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charVal = 0;
            string cikarilanYazi = "";
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    for (int n = 0; n < 3; n++)//Her piksel için kontrol etmek
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    charVal = charVal * 2 + pixel.R % 2;//Kırmızı pikselde bulunan en önemsi bit. Bu bit işlenmiş bittir
                                }
                                break;
                            case 1:
                                {
                                    charVal = charVal * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charVal = charVal * 2 + pixel.B % 2;
                                }
                                break;
                        }
                        colorUnitIndex++;

                        //8 bit eklenmişse

                        if (colorUnitIndex % 8 == 0)
                        {
                            charVal = reverseBits(charVal);
                            Console.WriteLine(charVal);
                            if (charVal == 0)
                            {
                                return cikarilanYazi;
                            }
                            #region Türkçe Karakter Hatasını Önlemek İçin
                            if (charVal == 94)/*Ü=220 Ç=*/
                            {
                                charVal = 350;

                            }
                            else if (charVal == 95)
                            {
                                charVal = 351;
                            }
                            else if (charVal == 48)
                            {
                                charVal = 304;
                            }
                            #endregion
                            char c = (char)charVal;

                            cikarilanYazi += c.ToString();
                        }
                    }
                }

            }

            return cikarilanYazi;
        }


        public static int reverseBits(int n)
        {
            int sonuc = 0;
            for (int i = 0; i < 8; i++)
            {
                sonuc = sonuc * 2 + n % 2;
                n /= 2;
            }
            return sonuc;
        }
    }
}
