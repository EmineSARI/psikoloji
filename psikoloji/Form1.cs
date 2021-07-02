using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psikoloji
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
            soru++;
            button6.Text = "sonraki";
            button6.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            if (soru==1)
            {
                textBox1.Text = "1. Kendinizi ne zaman en iyi hissedersiniz?";
                button1.Text = "Sabah erken saatlerde";
                button2.Text = "Öğlenden sonra";
                button3.Text = "Akşama doğru";
                button4.Text = "Akşam saatlerinde";
                button5.Text = "Gece";
            }
            if (soru == 2)
            {
                textBox1.Text = "2. Nasıl yürürsünüz?";
                button1.Text = "Hızlı ve uzun adımlarla";
                button2.Text = "Hızlı ve kısa adımlarla";
                button3.Text = "Normalden yavaş ve etrafa bakınarak";
                button4.Text = "Yavaş ve başı eğik";
                button5.Text = "Çok yavaş";
            }

            if (soru==3)
            {
                textBox1.Text = "3. İnsanlarla konuşurken";
                button1.Text = "Kollarımı göğsümde katlamış olarak dururum";
                button2.Text = "Ellerimi sıkarım";
                button3.Text = "Bir veya iki elimi belime koyarım";
                button4.Text = "Konuştuğum insanlara dokunur veya ittiririm";
                button5.Text = "Kulağımla oynar, çeneme dokunur veya saçımı düzeltirim";
            }

            if (soru==4)
            {
                textBox1.Text = "4. Dinlenirken nasıl oturursunuz?";
                button1.Text = "Dizler katlanmış ve bacaklar birbirine bitişik olarak";
                button2.Text = "Bacaklar çaprazlanmış olarak";
                button3.Text = "Bacaklarımı uzatarak";
                button4.Text = "Bir bacağımı altıma katlayarak";
                button5.Text = "Dümdüz otururum";
            }
            if (soru==5)
            {
                textBox1.Text = "5. Çok hoşunuza giden bir şey olduğunda ne yaparsınız?";
                button1.Text = "Büyük bir kahkaha atarım";
                button2.Text = "Gülerim ama fazla sesli değil";
                button3.Text = "Bir kerelik gülerim";
                button4.Text = "Sessizce gülümserim";
                button5.Text = "Tepkisiz kalırım";
            }
            if (soru==6)
            {
                textBox1.Text = "6.En çok hangi rengi seversiniz? ";
                button1.Text = "Kırmızı veya portakal rengi";
                button2.Text = "Siyah";
                button3.Text = "Sarı veya mavi";
                button4.Text = "Yeşil";
                button5.Text = "Koyu mavi veya mor";

            }

            if (soru==7)
            {
                textBox1.Text = "7. Çok zor bir işe dikkatinizi vermişken rahatsız ediliyorsunuz. Ne yaparsınız?";
                button1.Text = "Bölünmeyi memnuniyetle karşılarım";
                button2.Text = "Aşırı derecede rahatsız olurum";
                button3.Text = "Belli olmaz.Bu iki uç arasında değişken davranışlar gösteririm";
                
            }
            if (soru==8)
            {
                textBox1.Text = "8. Yatakta uyumadan önceki birkaç dakikada ";
                button1.Text = "Sırt üstü yatıp uzanırsınız";
                button2.Text = "Karnınızın üstüne yatıp uzanırsınız";
                button3.Text = "Hafif kıvrılmış olarak yan tarafınıza yatarsınız";
                button4.Text = "Başınızı bir kolunuzun üzerine koyarsınız";
                button5.Text = "Başınızı yorganın altına kapatırsınız";

            }
            if (soru==9)
            {
                textBox1.Text = "9.Bir partiye veya sosyal etkinliğe katıldığınızda ";
                button1.Text = "Herkes sizi fark edecek şekilde gürültülü bir giriş mi yaparsınız?";
                button2.Text = "Sessiz bir giriş yapıp etrafınızda tanıdığınız birilerine mi bakınırsınız?";
                button3.Text = "Çok sessizce girip kimsenin sizi fark etmemesine mi gayret edersiniz?";
                
            }
            if (soru==10)
            {
                textBox1.Text = "10. Rüyanızda genellikle";
                button1.Text = "Düşersiniz";
                button2.Text = "Kavga eder veya tartışırsınız";
                button3.Text = "Birilerini veya bir şeyler ararsınız";
                button4.Text = "Uçar veya yüzersiniz";
                button5.Text = "Genelde rüya görmezsiniz";
            }

            if (soru==11)
            {
                label2.Text = toplam.ToString();
                if (toplam >=0 && toplam <=5)
                {
                    textBox1.Text = "İnsanlar sizi mantıklı, ihtiyatlı, dikkatli ve pratik birisi olarak görürler. Sizi zeki, yetenekli ve hünerli ama alçak gönüllü olarak tanırlar. Çok hızlı arkadaşlık kurmayan, ama arkadaşlarına karşı çok sadık olan ve onlardan da aynı şeyi bekleyen birisiniz.";
                }
                if (toplam >=6  && toplam <= 10)
                {
                    textBox1.Text = "İnsanlar sizi taze, canlı, çekici, eğlendirici, pratik ve daima ilginç birisi olarak görürler; her zaman ilgi odağı olan ama çok aşırıya kaçmayacak kadar da dengeli birisi.. İnsanlar sizi ayrıca iyiliksever, düşünceli, anlayışlı ve kendilerini neşelendiren ve rahatlatan birisi olarak tanırlar.";
                }
                if (toplam >= 11 && toplam <= 15)
                {
                    textBox1.Text = "insanlar sizi heyecan verici, havai, düşüncesiz yapıda, doğal liderlik özellikleri olan, her zaman doğru olmasa da hızlı karar veren birisi olarak tanırlar. Seni cesur, maceraperest birisi olarak tanırlar; her şeyi bir kez denemek isteyen, macera yaşamak için fırsatları kaçırmayan birisi.. Yaydığınız heyecandan dolayı insanlar sizinle aynı iş yerinde yaşamaktan zevk alırlar.";
                }
                if (toplam >= 15 && toplam <= 30)
                {
                    textBox1.Text = "İnsanlar sana kırılgan bir eşya muamelesi yapıyorlar. Kibirli, bencil ve aşırı baskın birisi olarak görülüyorsun. İnsanlar size hayranlık duyup sizin gibi olmak isteyebilirler ama size her zaman güvenmezler ve sizinle çok yakın ilişkide olmaktan kaçınırlar.";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam = toplam + 1;
            button6.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam = toplam + 2;
            button6.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toplam = toplam + 3;
            button6.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toplam = toplam + 4;
            button6.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toplam = toplam + 5;
            button6.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
