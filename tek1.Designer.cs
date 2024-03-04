namespace Tek_Test
{
    partial class tek1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1Zaman = new System.Windows.Forms.ComboBox();
            this.comboBox1Port = new System.Windows.Forms.ComboBox();
            this.comboBox1BautRate = new System.Windows.Forms.ComboBox();
            this.label1BautRate = new System.Windows.Forms.Label();
            this.label1Zamanlayıcı = new System.Windows.Forms.Label();
            this.label1Port = new System.Windows.Forms.Label();
            this.button1Disconnect = new System.Windows.Forms.Button();
            this.button1Connect = new System.Windows.Forms.Button();
            this.groupBox2Veri = new System.Windows.Forms.GroupBox();
            this.textBox1Voltaj = new System.Windows.Forms.TextBox();
            this.textBox1Guc = new System.Windows.Forms.TextBox();
            this.textBox1NTC4 = new System.Windows.Forms.TextBox();
            this.textBox1NTC5 = new System.Windows.Forms.TextBox();
            this.textBox1NTC3 = new System.Windows.Forms.TextBox();
            this.textBox1NTC6 = new System.Windows.Forms.TextBox();
            this.textBox1NTC1 = new System.Windows.Forms.TextBox();
            this.textBox1NTC2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1Time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1NTC1 = new System.Windows.Forms.CheckBox();
            this.checkBox1Voltaj = new System.Windows.Forms.CheckBox();
            this.checkBox1NTC5 = new System.Windows.Forms.CheckBox();
            this.checkBox1NTC4 = new System.Windows.Forms.CheckBox();
            this.checkBox1NTC2 = new System.Windows.Forms.CheckBox();
            this.checkBox1Guc = new System.Windows.Forms.CheckBox();
            this.checkBox1NTC6 = new System.Windows.Forms.CheckBox();
            this.checkBox1NTC3 = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox2Veri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 46);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1222, 738);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.görünümToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // comboBox1Zaman
            // 
            this.comboBox1Zaman.FormattingEnabled = true;
            this.comboBox1Zaman.Location = new System.Drawing.Point(1394, 235);
            this.comboBox1Zaman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1Zaman.Name = "comboBox1Zaman";
            this.comboBox1Zaman.Size = new System.Drawing.Size(121, 24);
            this.comboBox1Zaman.TabIndex = 12;
            // 
            // comboBox1Port
            // 
            this.comboBox1Port.FormattingEnabled = true;
            this.comboBox1Port.Location = new System.Drawing.Point(1394, 146);
            this.comboBox1Port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1Port.Name = "comboBox1Port";
            this.comboBox1Port.Size = new System.Drawing.Size(121, 24);
            this.comboBox1Port.TabIndex = 13;
            // 
            // comboBox1BautRate
            // 
            this.comboBox1BautRate.FormattingEnabled = true;
            this.comboBox1BautRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200"});
            this.comboBox1BautRate.Location = new System.Drawing.Point(1394, 192);
            this.comboBox1BautRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1BautRate.Name = "comboBox1BautRate";
            this.comboBox1BautRate.Size = new System.Drawing.Size(121, 24);
            this.comboBox1BautRate.TabIndex = 14;
            // 
            // label1BautRate
            // 
            this.label1BautRate.AutoSize = true;
            this.label1BautRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1BautRate.Location = new System.Drawing.Point(1270, 192);
            this.label1BautRate.Name = "label1BautRate";
            this.label1BautRate.Size = new System.Drawing.Size(87, 20);
            this.label1BautRate.TabIndex = 9;
            this.label1BautRate.Text = "BautRate";
            // 
            // label1Zamanlayıcı
            // 
            this.label1Zamanlayıcı.AutoSize = true;
            this.label1Zamanlayıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1Zamanlayıcı.Location = new System.Drawing.Point(1249, 235);
            this.label1Zamanlayıcı.Name = "label1Zamanlayıcı";
            this.label1Zamanlayıcı.Size = new System.Drawing.Size(108, 20);
            this.label1Zamanlayıcı.TabIndex = 10;
            this.label1Zamanlayıcı.Text = "Zamanlayıcı";
            // 
            // label1Port
            // 
            this.label1Port.AutoSize = true;
            this.label1Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1Port.Location = new System.Drawing.Point(1270, 146);
            this.label1Port.Name = "label1Port";
            this.label1Port.Size = new System.Drawing.Size(88, 20);
            this.label1Port.TabIndex = 11;
            this.label1Port.Text = "Port Seç ";
            // 
            // button1Disconnect
            // 
            this.button1Disconnect.Location = new System.Drawing.Point(1394, 46);
            this.button1Disconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1Disconnect.Name = "button1Disconnect";
            this.button1Disconnect.Size = new System.Drawing.Size(103, 66);
            this.button1Disconnect.TabIndex = 8;
            this.button1Disconnect.Text = "Bağlantıyı Kes";
            this.button1Disconnect.UseVisualStyleBackColor = true;
            this.button1Disconnect.Click += new System.EventHandler(this.button1Disconnect_Click);
            // 
            // button1Connect
            // 
            this.button1Connect.Location = new System.Drawing.Point(1273, 46);
            this.button1Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1Connect.Name = "button1Connect";
            this.button1Connect.Size = new System.Drawing.Size(115, 66);
            this.button1Connect.TabIndex = 7;
            this.button1Connect.Text = "Bağlan";
            this.button1Connect.UseVisualStyleBackColor = true;
            this.button1Connect.Click += new System.EventHandler(this.button1Connect_Click);
            // 
            // groupBox2Veri
            // 
            this.groupBox2Veri.Controls.Add(this.textBox1Voltaj);
            this.groupBox2Veri.Controls.Add(this.textBox1Guc);
            this.groupBox2Veri.Controls.Add(this.textBox1NTC4);
            this.groupBox2Veri.Controls.Add(this.textBox1NTC5);
            this.groupBox2Veri.Controls.Add(this.textBox1NTC3);
            this.groupBox2Veri.Controls.Add(this.textBox1NTC6);
            this.groupBox2Veri.Controls.Add(this.textBox1NTC1);
            this.groupBox2Veri.Controls.Add(this.textBox1NTC2);
            this.groupBox2Veri.Controls.Add(this.label9);
            this.groupBox2Veri.Controls.Add(this.label5);
            this.groupBox2Veri.Controls.Add(this.label8);
            this.groupBox2Veri.Controls.Add(this.label4);
            this.groupBox2Veri.Controls.Add(this.label7);
            this.groupBox2Veri.Controls.Add(this.label6);
            this.groupBox2Veri.Controls.Add(this.label3);
            this.groupBox2Veri.Controls.Add(this.label1);
            this.groupBox2Veri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2Veri.Location = new System.Drawing.Point(1252, 550);
            this.groupBox2Veri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2Veri.Name = "groupBox2Veri";
            this.groupBox2Veri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2Veri.Size = new System.Drawing.Size(305, 393);
            this.groupBox2Veri.TabIndex = 18;
            this.groupBox2Veri.TabStop = false;
            this.groupBox2Veri.Text = "Son Veri";
            // 
            // textBox1Voltaj
            // 
            this.textBox1Voltaj.Location = new System.Drawing.Point(115, 334);
            this.textBox1Voltaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1Voltaj.Name = "textBox1Voltaj";
            this.textBox1Voltaj.Size = new System.Drawing.Size(147, 27);
            this.textBox1Voltaj.TabIndex = 1;
            // 
            // textBox1Guc
            // 
            this.textBox1Guc.Location = new System.Drawing.Point(115, 294);
            this.textBox1Guc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1Guc.Name = "textBox1Guc";
            this.textBox1Guc.Size = new System.Drawing.Size(147, 27);
            this.textBox1Guc.TabIndex = 1;
            // 
            // textBox1NTC4
            // 
            this.textBox1NTC4.Location = new System.Drawing.Point(115, 160);
            this.textBox1NTC4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1NTC4.Name = "textBox1NTC4";
            this.textBox1NTC4.Size = new System.Drawing.Size(147, 27);
            this.textBox1NTC4.TabIndex = 1;
            // 
            // textBox1NTC5
            // 
            this.textBox1NTC5.Location = new System.Drawing.Point(115, 206);
            this.textBox1NTC5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1NTC5.Name = "textBox1NTC5";
            this.textBox1NTC5.Size = new System.Drawing.Size(147, 27);
            this.textBox1NTC5.TabIndex = 1;
            // 
            // textBox1NTC3
            // 
            this.textBox1NTC3.Location = new System.Drawing.Point(115, 121);
            this.textBox1NTC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1NTC3.Name = "textBox1NTC3";
            this.textBox1NTC3.Size = new System.Drawing.Size(147, 27);
            this.textBox1NTC3.TabIndex = 1;
            // 
            // textBox1NTC6
            // 
            this.textBox1NTC6.Location = new System.Drawing.Point(115, 249);
            this.textBox1NTC6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1NTC6.Name = "textBox1NTC6";
            this.textBox1NTC6.Size = new System.Drawing.Size(147, 27);
            this.textBox1NTC6.TabIndex = 1;
            // 
            // textBox1NTC1
            // 
            this.textBox1NTC1.Location = new System.Drawing.Point(115, 31);
            this.textBox1NTC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1NTC1.Name = "textBox1NTC1";
            this.textBox1NTC1.Size = new System.Drawing.Size(147, 27);
            this.textBox1NTC1.TabIndex = 1;
            // 
            // textBox1NTC2
            // 
            this.textBox1NTC2.Location = new System.Drawing.Point(115, 75);
            this.textBox1NTC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1NTC2.Name = "textBox1NTC2";
            this.textBox1NTC2.Size = new System.Drawing.Size(147, 27);
            this.textBox1NTC2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "NTC4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "VOLTAJ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "NTC3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "GÜÇ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "NTC1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "NTC2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "NTC5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NTC6";
            // 
            // textBox1Time
            // 
            this.textBox1Time.Location = new System.Drawing.Point(1375, 495);
            this.textBox1Time.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1Time.Name = "textBox1Time";
            this.textBox1Time.Size = new System.Drawing.Size(147, 22);
            this.textBox1Time.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1248, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Geçen Zaman : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1NTC1);
            this.groupBox1.Controls.Add(this.checkBox1Voltaj);
            this.groupBox1.Controls.Add(this.checkBox1NTC5);
            this.groupBox1.Controls.Add(this.checkBox1NTC4);
            this.groupBox1.Controls.Add(this.checkBox1NTC2);
            this.groupBox1.Controls.Add(this.checkBox1Guc);
            this.groupBox1.Controls.Add(this.checkBox1NTC6);
            this.groupBox1.Controls.Add(this.checkBox1NTC3);
            this.groupBox1.Location = new System.Drawing.Point(1273, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(179, 186);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veri Seçim Grubu";
            // 
            // checkBox1NTC1
            // 
            this.checkBox1NTC1.AutoSize = true;
            this.checkBox1NTC1.Location = new System.Drawing.Point(7, 21);
            this.checkBox1NTC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1NTC1.Name = "checkBox1NTC1";
            this.checkBox1NTC1.Size = new System.Drawing.Size(64, 20);
            this.checkBox1NTC1.TabIndex = 3;
            this.checkBox1NTC1.Text = "NTC1";
            this.checkBox1NTC1.UseVisualStyleBackColor = true;
            // 
            // checkBox1Voltaj
            // 
            this.checkBox1Voltaj.AutoSize = true;
            this.checkBox1Voltaj.Location = new System.Drawing.Point(101, 145);
            this.checkBox1Voltaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1Voltaj.Name = "checkBox1Voltaj";
            this.checkBox1Voltaj.Size = new System.Drawing.Size(63, 20);
            this.checkBox1Voltaj.TabIndex = 3;
            this.checkBox1Voltaj.Text = "Voltaj";
            this.checkBox1Voltaj.UseVisualStyleBackColor = true;
            // 
            // checkBox1NTC5
            // 
            this.checkBox1NTC5.AutoSize = true;
            this.checkBox1NTC5.Location = new System.Drawing.Point(101, 21);
            this.checkBox1NTC5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1NTC5.Name = "checkBox1NTC5";
            this.checkBox1NTC5.Size = new System.Drawing.Size(64, 20);
            this.checkBox1NTC5.TabIndex = 3;
            this.checkBox1NTC5.Text = "NTC5";
            this.checkBox1NTC5.UseVisualStyleBackColor = true;
            // 
            // checkBox1NTC4
            // 
            this.checkBox1NTC4.AutoSize = true;
            this.checkBox1NTC4.Location = new System.Drawing.Point(7, 145);
            this.checkBox1NTC4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1NTC4.Name = "checkBox1NTC4";
            this.checkBox1NTC4.Size = new System.Drawing.Size(64, 20);
            this.checkBox1NTC4.TabIndex = 3;
            this.checkBox1NTC4.Text = "NTC4";
            this.checkBox1NTC4.UseVisualStyleBackColor = true;
            // 
            // checkBox1NTC2
            // 
            this.checkBox1NTC2.AutoSize = true;
            this.checkBox1NTC2.Location = new System.Drawing.Point(7, 58);
            this.checkBox1NTC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1NTC2.Name = "checkBox1NTC2";
            this.checkBox1NTC2.Size = new System.Drawing.Size(64, 20);
            this.checkBox1NTC2.TabIndex = 3;
            this.checkBox1NTC2.Text = "NTC2";
            this.checkBox1NTC2.UseVisualStyleBackColor = true;
            // 
            // checkBox1Guc
            // 
            this.checkBox1Guc.AutoSize = true;
            this.checkBox1Guc.Location = new System.Drawing.Point(101, 103);
            this.checkBox1Guc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1Guc.Name = "checkBox1Guc";
            this.checkBox1Guc.Size = new System.Drawing.Size(53, 20);
            this.checkBox1Guc.TabIndex = 3;
            this.checkBox1Guc.Text = "Güç";
            this.checkBox1Guc.UseVisualStyleBackColor = true;
            // 
            // checkBox1NTC6
            // 
            this.checkBox1NTC6.AutoSize = true;
            this.checkBox1NTC6.Location = new System.Drawing.Point(101, 58);
            this.checkBox1NTC6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1NTC6.Name = "checkBox1NTC6";
            this.checkBox1NTC6.Size = new System.Drawing.Size(64, 20);
            this.checkBox1NTC6.TabIndex = 3;
            this.checkBox1NTC6.Text = "NTC6";
            this.checkBox1NTC6.UseVisualStyleBackColor = true;
            // 
            // checkBox1NTC3
            // 
            this.checkBox1NTC3.AutoSize = true;
            this.checkBox1NTC3.Location = new System.Drawing.Point(7, 103);
            this.checkBox1NTC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1NTC3.Name = "checkBox1NTC3";
            this.checkBox1NTC3.Size = new System.Drawing.Size(64, 20);
            this.checkBox1NTC3.TabIndex = 3;
            this.checkBox1NTC3.Text = "NTC3";
            this.checkBox1NTC3.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 957);
            this.Controls.Add(this.groupBox2Veri);
            this.Controls.Add(this.textBox1Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1Zaman);
            this.Controls.Add(this.comboBox1Port);
            this.Controls.Add(this.comboBox1BautRate);
            this.Controls.Add(this.label1BautRate);
            this.Controls.Add(this.label1Zamanlayıcı);
            this.Controls.Add(this.label1Port);
            this.Controls.Add(this.button1Disconnect);
            this.Controls.Add(this.button1Connect);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2Veri.ResumeLayout(false);
            this.groupBox2Veri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1Zaman;
        private System.Windows.Forms.ComboBox comboBox1Port;
        private System.Windows.Forms.ComboBox comboBox1BautRate;
        private System.Windows.Forms.Label label1BautRate;
        private System.Windows.Forms.Label label1Zamanlayıcı;
        private System.Windows.Forms.Label label1Port;
        private System.Windows.Forms.Button button1Disconnect;
        private System.Windows.Forms.Button button1Connect;
        private System.Windows.Forms.GroupBox groupBox2Veri;
        private System.Windows.Forms.TextBox textBox1Voltaj;
        private System.Windows.Forms.TextBox textBox1Guc;
        private System.Windows.Forms.TextBox textBox1NTC4;
        private System.Windows.Forms.TextBox textBox1NTC5;
        private System.Windows.Forms.TextBox textBox1NTC3;
        private System.Windows.Forms.TextBox textBox1NTC6;
        private System.Windows.Forms.TextBox textBox1NTC1;
        private System.Windows.Forms.TextBox textBox1NTC2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1NTC1;
        private System.Windows.Forms.CheckBox checkBox1Voltaj;
        private System.Windows.Forms.CheckBox checkBox1NTC5;
        private System.Windows.Forms.CheckBox checkBox1NTC4;
        private System.Windows.Forms.CheckBox checkBox1NTC2;
        private System.Windows.Forms.CheckBox checkBox1Guc;
        private System.Windows.Forms.CheckBox checkBox1NTC6;
        private System.Windows.Forms.CheckBox checkBox1NTC3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

