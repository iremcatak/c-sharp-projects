using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasaparola_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            buttonA.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "balık")
                        {
                            buttonB.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            buttonC.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            buttonD.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "ergenlik")
                        {
                            buttonE.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "fay")
                        {
                            buttonF.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            buttonG.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halay")
                        {
                            buttonH.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            buttonI.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "iplik")
                        {
                            buttonİ.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonİ.BackColor = Color.Red;
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            buttonJ.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            buttonK.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            buttonL.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            buttonM.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            buttonN.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            buttonO.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "papyon")
                        {
                            buttonP.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            buttonR.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "simit")
                        {
                            buttonS.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tramvay")
                        {
                            buttonT.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "uzak")
                        {
                            buttonU.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            buttonV.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yağmur")
                        {
                            buttonY.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            buttonZ.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                        }
                        break;
                }
            }
        }
    

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        linkLabel1.Text = "Sıradaki Soru";
        soruno++;
        this.Text = soruno.ToString();

        if (soruno == 1)
        {
            richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
            buttonA.BackColor = Color.Yellow;
        }
        if (soruno == 2)
        {
            richTextBox1.Text = "Denizde yaşayan bir hayvan?";
            buttonB.BackColor = Color.Yellow;
        }
        if (soruno == 3)
        {
            richTextBox1.Text = "Müslümanların kutsal günü?";
            buttonC.BackColor = Color.Yellow;
        }
        if (soruno == 4)
        {
            richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
            buttonD.BackColor = Color.Yellow;
        }
        if (soruno == 5)
        {
            richTextBox1.Text = "Çocukluktan yetişkinliğe geçiş aşaması?";
            buttonE.BackColor = Color.Yellow;
        }
        if (soruno == 6)
        {
            richTextBox1.Text = "Depremlerin üzerinde gerçekleştiği hat?";
            buttonF.BackColor = Color.Yellow;
        }
        if (soruno == 7)
        {
            richTextBox1.Text = "Dünyanın ısı kaynağı?";
            buttonG.BackColor = Color.Yellow;
        }
        if (soruno == 8)
        {
            richTextBox1.Text = "Düğünlerde ele ele tutuşarak oyanan halk oyunu?";
            buttonH.BackColor = Color.Yellow;
        }
        if (soruno == 9)
        {
            richTextBox1.Text = "Gülüyle ünlü ilimiz?";
            buttonI.BackColor = Color.Yellow;
        }
        if (soruno == 10)
        {
            richTextBox1.Text = "Kıyafet dikerken kullanılan malzeme?";
            buttonİ.BackColor = Color.Yellow;
        }
        if (soruno == 11)
        {
            richTextBox1.Text = "Askeri bir topluluk?";
            buttonJ.BackColor = Color.Yellow;
        }
        if (soruno == 12)
        {
            richTextBox1.Text = "Malatyanın meşhur meyvesi?";
            buttonK.BackColor = Color.Yellow;
        }
        if (soruno == 13)
        {
            richTextBox1.Text = "İstanbulun simgesi olan çiçek?";
            buttonL.BackColor = Color.Yellow;
        }
        if (soruno == 14)
        {
            richTextBox1.Text = "Yılın üçüncü ayı?";
            buttonM.BackColor = Color.Yellow;
        }
        if (soruno == 15)
        {
            richTextBox1.Text = "Üflemeli bir müzik aleti?";
            buttonN.BackColor = Color.Yellow;
        }
        if (soruno == 16)
        {
            richTextBox1.Text = "Halk şairi?";
            buttonO.BackColor = Color.Yellow;
        }
        if (soruno == 17)
        {
            richTextBox1.Text = "Erkeklerin yakalarına taktığı aksesuar?";
            buttonP.BackColor = Color.Yellow;
        }
        if (soruno == 18)
        {
            richTextBox1.Text = "11 ayın sultanı?";
            buttonR.BackColor = Color.Yellow;
        }
        if (soruno == 19)
        {
            richTextBox1.Text = "Gevrek olarakda adlandırılan yiyecek?";
            buttonS.BackColor = Color.Yellow;
        }
        if (soruno == 20)
        {
            richTextBox1.Text = "Ray üzerinde ilerleyen bir taşıt?";
            buttonT.BackColor = Color.Yellow;
        }
        if (soruno == 21)
        {
            richTextBox1.Text = "Yakın kelimesinin zıt anlamlısı?";
            buttonU.BackColor = Color.Yellow;
        }
        if (soruno == 22)
        {
            richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
            buttonV.BackColor = Color.Yellow;
        }
        if (soruno == 23)
        {
            richTextBox1.Text = "Bir yağış türü?";
            buttonY.BackColor = Color.Yellow;
        }
        if (soruno == 24)
        {
            richTextBox1.Text = "Yağı yapılan bir besin?";
            buttonZ.BackColor = Color.Yellow;
        }
    }
}
}
