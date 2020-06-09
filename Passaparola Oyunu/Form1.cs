using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int soruno = 0, dogru = 0, yanlis = 0,bos=0;
        int counter = 0;
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "Ankara")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnA.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            LblDogru.ForeColor = Color.Green;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                            
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnA.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnA.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnB.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnB.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnB.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "Cağ Kebap")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnC.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnC.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnC.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 4:
                        if (textBox1.Text == "Data")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnD.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnD.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnD.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 5:
                        if (textBox1.Text == "Eczane")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnE.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnE.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnE.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "Farad")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnF.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnF.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnF.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "Gazel")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnG.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnG.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnG.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 8:
                        if (textBox1.Text == "Hilaf")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnH.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnH.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnH.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 9:
                        if (textBox1.Text == "İkbal")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnI.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnI.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnI.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 10:
                        if (textBox1.Text == "Kayısı")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnK.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnK.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnK.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 11:
                        if (textBox1.Text == "Lale")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnL.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnL.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnL.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 12:
                        if (textBox1.Text == "Mart")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnM.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnM.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnM.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 13:
                        if (textBox1.Text == "Ozan")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnO.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnO.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnO.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 14:
                        if (textBox1.Text == "Pırasa")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnP.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnP.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnP.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 15:
                        if (textBox1.Text == "Ramazan")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnR.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnR.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnR.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 16:
                        if (textBox1.Text == "Snake")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnS.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnS.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnS.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 17:
                        if (textBox1.Text == "Tarkan")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnT.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnT.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnT.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 18:
                        if (textBox1.Text == "Umut")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnU.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnU.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnU.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 19:
                        if (textBox1.Text == "Van")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnV.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnV.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnV.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 20:
                        if (textBox1.Text == "Yaramaz")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnY.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnY.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnY.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;

                    case 21:
                        if (textBox1.Text == "Zeytin")
                        {
                            dogru++;
                            LblDogru.Text = dogru.ToString();
                            BtnZ.BackColor = Color.Green;
                            label4.Visible = true;
                            LblDogru.Visible = true;
                            textBox1.Enabled = false;
                            counter += 500;
                            LblKasa.Text = counter.ToString();
                        }
                        else if (textBox1.Text == "")
                        {
                            bos++;
                            LblBos.Text = bos.ToString();
                            BtnZ.BackColor = Color.LightYellow;
                            label6.Visible = true;
                            LblBos.Visible = true;
                            textBox1.Enabled = false;
                        }
                        else
                        {
                            yanlis++;
                            LblYanlis.Text = yanlis.ToString();
                            BtnZ.BackColor = Color.Red;
                            label5.Visible = true;
                            LblYanlis.Visible = true;
                            textBox1.Enabled = false;
                        }
                        break;
                        
                }
                
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {
                textBox1.Enabled = true;
                richTextBox1.Text = "Ülkemizin başkenti neresidir?";
                BtnA.BackColor = Color.Yellow;
                textBox1.Focus();
               
            }
            if (soruno == 2)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Yeşilliğiyle ünlü ilimiz neresidir?";
                BtnB.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 3)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Erzurum'a ait meşhur kebap?";
                BtnC.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 4)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Veri kelimesinin ingilizcesi?";
                BtnD.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 5)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Günümüzde ilaçların satıldığı yer?";
                BtnE.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 6)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Elektrik sığa birimi nedir?";
                BtnF.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 7)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Divan edebiyatında beş ile on beş beyit arasında değişen, ilk beytinin dizeleri birbiriyle, sonraki beyitlerinin ikinci dizeleri birinci beyitle uyaklı, genellikle lirik konularda yazılan nazım biçimi nedir?";
                BtnG.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 8)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Aykırı, karşıt, ters =...?";
                BtnH.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 9)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Baht açıklığı veya yüksek bir makama, duruma erişmiş olma durumu?";
                BtnI.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 10)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Malatya'nın meşhur meyvesi?";
                BtnK.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 11)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                BtnL.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 12)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Yılın 3. ayı?";
                BtnM.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 13)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Halk şairi?";
                BtnO.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 14)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Çocukların pek sevmediği havuç, pirinç gibi malzemelerden yapılan yemek?";
                BtnP.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 15)
            {
                textBox1.Text = "";
                richTextBox1.Text = "11 ayın sultanı?";
                BtnR.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 16)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Yılan kelimesinin ingilizce de anlamı?";
                BtnS.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 17)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Türkiye'nin mega starı?";
                BtnT.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 18)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                BtnU.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 19)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                BtnV.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 20)
            {
                textBox1.Text = "";
                richTextBox1.Text = "(çocuk için) kendisine yasaklanan şeyleri yapmakta direnen, söz dinlemeyen, uslu durmayan?";
                BtnY.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
            }
            if (soruno == 21)
            {
                textBox1.Text = "";
                richTextBox1.Text = "Ağacı en çok Ege bölgesinde bulunan ve yağı da yapılan meyve?";
                BtnZ.BackColor = Color.Yellow;
                label4.Visible = false;
                LblDogru.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                LblBos.Visible = false;
                LblYanlis.Visible = false;
                textBox1.Enabled = true;
                textBox1.Focus();
                linkLabel1.Text = "Bitir";
            }
            if (soruno==22)
            {
                soruno=21;
                LblSoruNo.Text = soruno.ToString();

                if (dogru == 21)
                {
                    MessageBox.Show("Tüm soruları doğru cevapladığınız için ekstra 5000 TL daha kazandınız:)");
                    counter += 5000;
                    LblKasa.Text = counter.ToString();
                }
                linkLabel1.Enabled = false;
                textBox1.Enabled = false;
                
            }
           
        }
    }
}
