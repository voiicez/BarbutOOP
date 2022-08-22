using BarbutOOP.Models;
namespace BarbutOOP
{
    public partial class Form1 : Form

    {
        Zar zar = new Zar();
        string dice = "dice-";
        string uzanti =".png";
        //string klasor = @"C:\Users\behlul.sahin\Desktop\Beho\DicePng";
        ////C:\Users\behlul.sahin\Desktop\Beho\DicePng\dice-1.png
        string klasor = Application.StartupPath.Replace(@"bin\Debug\net6.0-windows",@"DicePng\");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ZarAt();

        }

         void ZarAt()
        {
            zar.At();
            int sayi1 = zar.Sayi;
            lSayi1.Text = "Siz: " + sayi1.ToString();
            lSayi1.Visible = true;
            pbSayi1.ImageLocation = klasor + dice + sayi1 + uzanti;
            zar.At();
            int sayi2 = zar.Sayi;
            lSayi2.Text = "Rakip: " + sayi2.ToString();
            lSayi2.Visible = true;
            pbSayi2.ImageLocation = klasor + dice + sayi2 + uzanti;
            if (sayi1 > sayi2)
            {
                lbsonuc.Items.Add("Siz");
            }
            else if (sayi2 > sayi1)
            {
                lbsonuc.Items.Add("Rakip");
            }
            else
            {
                ZarAt(); // Berabere geldiğinde bir daha atsın istemiyorsak lbsonuc.Items.Add("Berabere");
            }
        }
    }
}