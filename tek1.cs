using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;


namespace Tek_Test
{
    public partial class tek1 : Form
    {
        private DateTime baslangicZamani;
        string[] portlar = SerialPort.GetPortNames();
        GraphPane myPane = new GraphPane();
        public tek1()
        {
            InitializeComponent();
            myPane = zedGraphControl1.GraphPane;
            DrawSineCurve();
        }

        private void DrawSineCurve()
        {
            PointPairList pointPairList = new PointPairList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox'a seçenekleri ekleyelim
            comboBox1Zaman.Items.AddRange(new object[] { "5", "10", "15", "20", "30", "45", "60" });

            // Başlangıçta seçili olan seçeneği belirleyelim
            comboBox1Zaman.SelectedIndex = 0;
            myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Isı Grafiği";
            myPane.XAxis.Title.Text = "Zaman(Saniye)";
            myPane.YAxis.Title.Text = "Değer";

            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = double.MaxValue;
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = double.MaxValue;

            zedGraphControl1.AxisChange();
            foreach (string port in portlar)
            {
                comboBox1Port.Items.Add(port);
                comboBox1Port.SelectedIndex = 0;
            }
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }
        private void DrawGraph(double x, double y)
        {
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
            {
                LineItem curve = myPane.AddCurve("Veri", new double[] { x }, new double[] { y }, Color.Blue, SymbolType.None);
                curve.Line.IsVisible = true;
            }
            else
            {
                LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
                if (curve != null)
                {
                    IPointListEdit list = curve.Points as IPointListEdit;
                    if (list != null)
                    {
                        list.Add(x, y);
                    }
                }
            }
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1Connect_Click(object sender, EventArgs e)
        {
            // ComboBox'tan seçilen COM portunu al
            string selectedPort = comboBox1Port.SelectedItem.ToString();

            // Seçilen portun geçerli olduğunu kontrol et
            if (string.IsNullOrEmpty(selectedPort))
            {
                MessageBox.Show("Lütfen bir COM portu seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bağlantıyı aç
            try
            {
                serialPort1.PortName = selectedPort;
                serialPort1.Open();
                baslangicZamani = DateTime.Now;
                timer1.Start();
                button1Connect.Enabled = false; // Bağlan butonunu devre dışı bırak
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı açılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Bağlan butonuna basıldığında seçilen zaman aralığını alıyoruz
            int secilenZaman = int.Parse(comboBox1Zaman.SelectedItem.ToString());

            // Timer'ın tetiklenme aralığını seçilen zamana göre ayarlıyoruz (milisaniye cinsinden)
            timer1.Interval = secilenZaman * 1000;

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadLine();

            // Veriyi işleme ve grafikte gösterme
            double x = DateTime.Now.Second; // Zamanı saniye cinsinden alıyoruz
            double y = double.Parse(data); // Veriyi double cinsine dönüştürüyoruz, burada gelen verinin tam olarak nasıl olduğuna bağlı olarak uygun dönüşümü yapmalısınız

            // CheckBox'lara göre veriyi işleme ve grafikte gösterme
            if (data.Trim() == "1" && checkBox1NTC1.Checked)
            {
                DrawGraph(x, y);
            }
            else if (data.Trim() == "2" && checkBox1NTC2.Checked)
            {
                DrawGraph(x, y);
            }
            else if (data.Trim() == "3" && checkBox1NTC3.Checked)
            {
                DrawGraph(x, y);
            }
            else if (data.Trim() == "4" && checkBox1NTC4.Checked)
            {
                DrawGraph(x, y);
            }
            else if (data.Trim() == "5" && checkBox1NTC5.Checked)
            {
                DrawGraph(x, y);
            }
            else if (data.Trim() == "6" && checkBox1NTC6.Checked)
            {
                DrawGraph(x, y);
            }
            else if (data.Trim() == "7" && checkBox1Guc.Checked)
            {
                DrawGraph(x, y);
            }
            else if (data.Trim() == "8" && checkBox1Voltaj.Checked)
            {
                DrawGraph(x, y);
            }

            this.Invoke(new EventHandler(delegate
            {
                if (data.Trim() == "1")
                    textBox1NTC1.Text = y.ToString();
                else if (data.Trim() == "2")
                    textBox1NTC2.Text = y.ToString();
                else if (data.Trim() == "3")
                    textBox1NTC3.Text = y.ToString();
                else if (data.Trim() == "4")
                    textBox1NTC4.Text = y.ToString();
                else if (data.Trim() == "5")
                    textBox1NTC5.Text = y.ToString();
                else if (data.Trim() == "6")
                    textBox1NTC6.Text = y.ToString();
                else if (data.Trim() == "7")
                    textBox1Guc.Text = y.ToString();
                else if (data.Trim() == "8")
                    textBox1Voltaj.Text = y.ToString();
            }));
        }

        private void button1Disconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer1.Stop();
            button1Connect.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Timer tetiklendiğinde geçen süreyi hesaplıyoruz
            TimeSpan gecenSure = DateTime.Now - baslangicZamani;

            // Geçen süreyi textBox1Time kutusuna yazıyoruz (zaman formatı isteğe bağlı olarak ayarlanabilir)
            textBox1Time.Text = gecenSure.ToString(@"hh\:mm\:ss");
            // Seçilen zaman dilimini alın (saniye cinsinden)
            int selectedInterval = int.Parse(comboBox1Zaman.SelectedItem.ToString());

            // CheckBox kontrolünü bulmak için farklı bir yöntem
            foreach (CheckBox checkBox in groupBox1.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked) // CheckBox seçiliyse
                {
                    // CheckBox'un adını kontrol ederek hangi sensörün seçildiğini buluyoruz
                    string sensorID = checkBox.Name.Replace("checkBox", "");

                    // Zamanı saniye cinsinden alıyoruz
                    double x = gecenSure.TotalSeconds;

                    // Veriyi okuyoruz ve grafik üzerine çizdiriyoruz
                    double y = ReadSensorData(sensorID);
                    DrawGraph(x, y);
                }
            }

            // Seri porttan veri alınırken checkbox'lara göre veri alımını ve grafik güncellemesini yapacağız
            /*    foreach (Control control in groupBox1.Controls) // groupBox1 içerisindeki checkbox'ları kontrol ediyoruz
        {
                    if (checkBox1NTC1.Checked)
                    {
                        double x = elapsedTime.TotalSeconds; // Zamanı saniye cinsinden alıyoruz
                        double y = ReadSensorData("1"); // "1" verisini okuyoruz, ReadSensorData metodunuzu kullanarak sensör verisini almalısınız
                        DrawGraph(x, y);
                    }

                    if (checkBox1NTC2.Checked)
                    {
                        double x = elapsedTime.TotalSeconds; // Zamanı saniye cinsinden alıyoruz
                        double y = ReadSensorData("2"); // "2" verisini okuyoruz, ReadSensorData metodunuzu kullanarak sensör verisini almalısınız
                        DrawGraph(x, y);
                    }

                }*/
        }

        private double ReadSensorData(string sensorID)
        {
            throw new NotImplementedException();
        }
    }

}