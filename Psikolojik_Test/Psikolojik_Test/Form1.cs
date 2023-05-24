using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Psikolojik_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soru;
        int toplam = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "Sonraki";
            soru++;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = false;
            if (soru==1)
            {
                
                textBox1.Text = "1-Öncelikle şunu soralım, kediler ve köpekler sahipleri ile bağ kurarlar mı?";
                button1.Text = "Evet, ancak bunun yalnızca kedi ve köpek ile sınırlandırılmaması gerekir. Tüm canlılar sahipleri ile bağ kurarlar.";
                button2.Text = "Evet, kedi ve köpeklerin sahibiyle bağ kurduğunu biliyorum.";
                button3.Text = "Elbette kurarlar.";
                button4.Text = "Hayır! Hayvanların öyle duyguları yoktur.";
                
            }
            if (soru==2)
            {
                textBox1.Text = "2-Evcil hayvanın nasıl bir yaklaşım sergilersin?";
                button1.Text = "Mutlu";
                button2.Text = "Dürüst";
                button3.Text = "Normal davranırım.";
                button4.Text = "Sinirli";
            }


            if (soru==3)
            {
                textBox1.Text = "3-Diyelim ki evin evcil hayvanın için uygun değil. Evini evcil dostun için uygun hâle getirmek için uğraşır mısın? Örneğin kapı ve pencerelere sineklik takmak vb.";
                button1.Text = "Elbette uygun hâle getiririm.";
                button2.Text = "Her şeyi yapamayabilirim ama onun da rahat edebileceği bir alan oluştururum.";
                button3.Text = "Yani bilemiyorum, belki yaparım.";
                button4.Text = "Neden yapayım ki ? ";
            }


            if (soru==4)
            {

                textBox1.Text = "4- Kedi ve köpeklere takılan çip hakkında bilgin var mı?";
                button1.Text = "Evet, onların kaybolmaması ve tehlike anında veterinerlerin bizlere ulaşabilmesi adına oldukça önemlidir.";
                button2.Text = "Evet, detaylı bilgim yok ama öğrenmeye çalışıyorum.";
                button3.Text = "Çip ne demek? Hayvanları da çiplemeye mi çalışıyorlar?";
                button4.Text = "Asla olmaz! Hayvana elektronik bir şey takılmaz!";
            }


            if (soru==5)
            {
                textBox1.Text = "5-Hayvanların bir şeyleri kemirmesi, eşyalara zarar vermesi normal midir?";
                button1.Text = "Tıpkı çocukların bir şeylere zarar vermesi gibi normaldir.";
                button2.Text = "Neden olmasın? Bizler de bazı şeyleri kırıp dökebiliyoruz.";
                button3.Text = "Ben asla tahammül edemem!";
                button4.Text = "Ben asla tahammül edemem!";
                
            }
            
            if (soru==6)
            {
                textBox1.BackColor = Color.PaleTurquoise;
                label2.BackColor = Color.DarkGray;

                label2.Text = toplam.ToString();

                if (toplam <= 7) 
                {
                    textBox1.Text = " SONUÇ:Evcil hayvan bakmaya uygun değilsin. Özgür bir yapıya sahipsin," +
                        "ancak evcil hayvan bakmak sorumluluk gerektirmektedir.";
                }


                if (toplam<=11 && toplam>=8)
                {
                    textBox1.Text = "SONUÇ:Bakıma daha az ihtiyacı olan bir evcil hayvan sahiplenmen daha mantıklı olur.  ";

                }

                if (toplam<=15 &&toplam>=12)
                {
                    textBox1.Text = "SONUÇ:Evcil hayvan bakmaya uygunsun.Bu sorumluluğu alabilirsin ancak dikkatli olmalısın.";
                }

                if (toplam<=20 && toplam>=16)
                {
                    textBox1.Text = "SONUÇ:Süper!! Tam bir evcil hayvan insanısın.Seni tebrik ediyoruz.";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = true;
            toplam = toplam + 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = true;
            toplam = toplam + 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = true;
            toplam = toplam + 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = true;
            toplam = toplam + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            
        }
    }
}
