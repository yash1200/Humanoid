namespace WindowsFormsApplication1
{
    partial class form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.servo_1 = new System.Windows.Forms.NumericUpDown();
            this.servo_2 = new System.Windows.Forms.NumericUpDown();
            this.servo_3 = new System.Windows.Forms.NumericUpDown();
            this.servo_4 = new System.Windows.Forms.NumericUpDown();
            this.servo_5 = new System.Windows.Forms.NumericUpDown();
            this.servo_6 = new System.Windows.Forms.NumericUpDown();
            this.servo_7 = new System.Windows.Forms.NumericUpDown();
            this.servo_8 = new System.Windows.Forms.NumericUpDown();
            this.servo_9 = new System.Windows.Forms.NumericUpDown();
            this.servo_10 = new System.Windows.Forms.NumericUpDown();
            this.servo_11 = new System.Windows.Forms.NumericUpDown();
            this.servo_12 = new System.Windows.Forms.NumericUpDown();
            this.servo_13 = new System.Windows.Forms.NumericUpDown();
            this.servo_14 = new System.Windows.Forms.NumericUpDown();
            this.servo_15 = new System.Windows.Forms.NumericUpDown();
            this.servo_16 = new System.Windows.Forms.NumericUpDown();
            this.send_btn = new System.Windows.Forms.Button();
            this.datasent = new System.Windows.Forms.TextBox();
            this.combox = new System.Windows.Forms.ListBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.datarecieved = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.s0 = new System.Windows.Forms.CheckBox();
            this.s8 = new System.Windows.Forms.CheckBox();
            this.s9 = new System.Windows.Forms.CheckBox();
            this.s15 = new System.Windows.Forms.CheckBox();
            this.s14 = new System.Windows.Forms.CheckBox();
            this.s13 = new System.Windows.Forms.CheckBox();
            this.s12 = new System.Windows.Forms.CheckBox();
            this.s11 = new System.Windows.Forms.CheckBox();
            this.s10 = new System.Windows.Forms.CheckBox();
            this.s7 = new System.Windows.Forms.CheckBox();
            this.s6 = new System.Windows.Forms.CheckBox();
            this.s5 = new System.Windows.Forms.CheckBox();
            this.s4 = new System.Windows.Forms.CheckBox();
            this.s3 = new System.Windows.Forms.CheckBox();
            this.s2 = new System.Windows.Forms.CheckBox();
            this.s1 = new System.Windows.Forms.CheckBox();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.inc = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servo_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inc)).BeginInit();
            this.SuspendLayout();
            // 
            // servo_1
            // 
            this.servo_1.Location = new System.Drawing.Point(133, 168);
            this.servo_1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_1.Name = "servo_1";
            this.servo_1.Size = new System.Drawing.Size(120, 22);
            this.servo_1.TabIndex = 0;
            this.servo_1.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.servo_1.ValueChanged += new System.EventHandler(this.servo_1_ValueChanged);
            // 
            // servo_2
            // 
            this.servo_2.Location = new System.Drawing.Point(133, 197);
            this.servo_2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_2.Name = "servo_2";
            this.servo_2.Size = new System.Drawing.Size(120, 22);
            this.servo_2.TabIndex = 1;
            this.servo_2.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.servo_2.ValueChanged += new System.EventHandler(this.servo_2_ValueChanged);
            // 
            // servo_3
            // 
            this.servo_3.Location = new System.Drawing.Point(133, 226);
            this.servo_3.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_3.Name = "servo_3";
            this.servo_3.Size = new System.Drawing.Size(120, 22);
            this.servo_3.TabIndex = 2;
            this.servo_3.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.servo_3.ValueChanged += new System.EventHandler(this.servo_3_ValueChanged);
            // 
            // servo_4
            // 
            this.servo_4.Location = new System.Drawing.Point(133, 255);
            this.servo_4.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_4.Name = "servo_4";
            this.servo_4.Size = new System.Drawing.Size(120, 22);
            this.servo_4.TabIndex = 3;
            this.servo_4.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.servo_4.ValueChanged += new System.EventHandler(this.servo_4_ValueChanged);
            // 
            // servo_5
            // 
            this.servo_5.Location = new System.Drawing.Point(133, 284);
            this.servo_5.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_5.Name = "servo_5";
            this.servo_5.Size = new System.Drawing.Size(120, 22);
            this.servo_5.TabIndex = 4;
            this.servo_5.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.servo_5.ValueChanged += new System.EventHandler(this.servo_5_ValueChanged);
            // 
            // servo_6
            // 
            this.servo_6.Location = new System.Drawing.Point(133, 313);
            this.servo_6.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_6.Name = "servo_6";
            this.servo_6.Size = new System.Drawing.Size(120, 22);
            this.servo_6.TabIndex = 5;
            this.servo_6.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.servo_6.ValueChanged += new System.EventHandler(this.servo_6_ValueChanged);
            // 
            // servo_7
            // 
            this.servo_7.Location = new System.Drawing.Point(133, 342);
            this.servo_7.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_7.Name = "servo_7";
            this.servo_7.Size = new System.Drawing.Size(120, 22);
            this.servo_7.TabIndex = 7;
            this.servo_7.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.servo_7.ValueChanged += new System.EventHandler(this.servo_7_ValueChanged);
            // 
            // servo_8
            // 
            this.servo_8.Location = new System.Drawing.Point(133, 369);
            this.servo_8.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_8.Name = "servo_8";
            this.servo_8.Size = new System.Drawing.Size(120, 22);
            this.servo_8.TabIndex = 8;
            this.servo_8.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.servo_8.ValueChanged += new System.EventHandler(this.servo_8_ValueChanged);
            // 
            // servo_9
            // 
            this.servo_9.Location = new System.Drawing.Point(452, 168);
            this.servo_9.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_9.Name = "servo_9";
            this.servo_9.Size = new System.Drawing.Size(120, 22);
            this.servo_9.TabIndex = 9;
            this.servo_9.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.servo_9.ValueChanged += new System.EventHandler(this.servo_9_ValueChanged);
            // 
            // servo_10
            // 
            this.servo_10.Location = new System.Drawing.Point(452, 196);
            this.servo_10.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_10.Name = "servo_10";
            this.servo_10.Size = new System.Drawing.Size(120, 22);
            this.servo_10.TabIndex = 10;
            this.servo_10.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.servo_10.ValueChanged += new System.EventHandler(this.servo_10_ValueChanged);
            // 
            // servo_11
            // 
            this.servo_11.Location = new System.Drawing.Point(452, 226);
            this.servo_11.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_11.Name = "servo_11";
            this.servo_11.Size = new System.Drawing.Size(120, 22);
            this.servo_11.TabIndex = 11;
            this.servo_11.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.servo_11.ValueChanged += new System.EventHandler(this.servo_11_ValueChanged);
            // 
            // servo_12
            // 
            this.servo_12.Location = new System.Drawing.Point(452, 254);
            this.servo_12.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_12.Name = "servo_12";
            this.servo_12.Size = new System.Drawing.Size(120, 22);
            this.servo_12.TabIndex = 12;
            this.servo_12.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.servo_12.ValueChanged += new System.EventHandler(this.servo_12_ValueChanged);
            // 
            // servo_13
            // 
            this.servo_13.Location = new System.Drawing.Point(452, 284);
            this.servo_13.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_13.Name = "servo_13";
            this.servo_13.Size = new System.Drawing.Size(120, 22);
            this.servo_13.TabIndex = 13;
            this.servo_13.Value = new decimal(new int[] {
            67,
            0,
            0,
            0});
            this.servo_13.ValueChanged += new System.EventHandler(this.servo_13_ValueChanged);
            // 
            // servo_14
            // 
            this.servo_14.Location = new System.Drawing.Point(452, 313);
            this.servo_14.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_14.Name = "servo_14";
            this.servo_14.Size = new System.Drawing.Size(120, 22);
            this.servo_14.TabIndex = 14;
            this.servo_14.Value = new decimal(new int[] {
            77,
            0,
            0,
            0});
            this.servo_14.ValueChanged += new System.EventHandler(this.servo_14_ValueChanged);
            // 
            // servo_15
            // 
            this.servo_15.Location = new System.Drawing.Point(452, 341);
            this.servo_15.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_15.Name = "servo_15";
            this.servo_15.Size = new System.Drawing.Size(120, 22);
            this.servo_15.TabIndex = 15;
            this.servo_15.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.servo_15.ValueChanged += new System.EventHandler(this.servo_15_ValueChanged);
            // 
            // servo_16
            // 
            this.servo_16.Location = new System.Drawing.Point(452, 369);
            this.servo_16.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.servo_16.Name = "servo_16";
            this.servo_16.Size = new System.Drawing.Size(120, 22);
            this.servo_16.TabIndex = 16;
            this.servo_16.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.servo_16.ValueChanged += new System.EventHandler(this.servo_16_ValueChanged);
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.send_btn.Enabled = false;
            this.send_btn.Location = new System.Drawing.Point(611, 254);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(134, 71);
            this.send_btn.TabIndex = 33;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // datasent
            // 
            this.datasent.Location = new System.Drawing.Point(120, 12);
            this.datasent.Name = "datasent";
            this.datasent.Size = new System.Drawing.Size(584, 22);
            this.datasent.TabIndex = 34;
            // 
            // combox
            // 
            this.combox.AccessibleName = "combox";
            this.combox.FormattingEnabled = true;
            this.combox.ItemHeight = 16;
            this.combox.Location = new System.Drawing.Point(53, 69);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(140, 84);
            this.combox.TabIndex = 35;
            this.combox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.combox_MouseDoubleClick);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(212, 69);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 22);
            this.textBox18.TabIndex = 36;
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.WriteTimeout = 500;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(56, 12);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(64, 22);
            this.textBox19.TabIndex = 37;
            this.textBox19.Text = "Send";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(56, 37);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(64, 22);
            this.textBox20.TabIndex = 38;
            this.textBox20.Text = "Recieved";
            // 
            // datarecieved
            // 
            this.datarecieved.Location = new System.Drawing.Point(120, 37);
            this.datarecieved.Name = "datarecieved";
            this.datarecieved.Size = new System.Drawing.Size(584, 22);
            this.datarecieved.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 64);
            this.button1.TabIndex = 40;
            this.button1.Text = "Detach All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.AccessibleName = "listBox1";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(53, 399);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(651, 276);
            this.listBox1.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 69);
            this.button2.TabIndex = 42;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(611, 134);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(134, 65);
            this.start.TabIndex = 43;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(611, 69);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(134, 65);
            this.save.TabIndex = 44;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // s0
            // 
            this.s0.AutoSize = true;
            this.s0.Location = new System.Drawing.Point(53, 168);
            this.s0.Name = "s0";
            this.s0.Size = new System.Drawing.Size(79, 21);
            this.s0.TabIndex = 45;
            this.s0.Text = "Servo 0";
            this.s0.UseVisualStyleBackColor = true;
            this.s0.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s8
            // 
            this.s8.AutoSize = true;
            this.s8.Location = new System.Drawing.Point(371, 169);
            this.s8.Name = "s8";
            this.s8.Size = new System.Drawing.Size(79, 21);
            this.s8.TabIndex = 46;
            this.s8.Text = "Servo 8";
            this.s8.UseVisualStyleBackColor = true;
            this.s8.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s9
            // 
            this.s9.AutoSize = true;
            this.s9.Location = new System.Drawing.Point(371, 196);
            this.s9.Name = "s9";
            this.s9.Size = new System.Drawing.Size(79, 21);
            this.s9.TabIndex = 47;
            this.s9.Text = "Servo 9";
            this.s9.UseVisualStyleBackColor = true;
            this.s9.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s15
            // 
            this.s15.AutoSize = true;
            this.s15.Location = new System.Drawing.Point(371, 368);
            this.s15.Name = "s15";
            this.s15.Size = new System.Drawing.Size(87, 21);
            this.s15.TabIndex = 48;
            this.s15.Text = "Servo 15";
            this.s15.UseVisualStyleBackColor = true;
            this.s15.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s14
            // 
            this.s14.AutoSize = true;
            this.s14.Location = new System.Drawing.Point(371, 341);
            this.s14.Name = "s14";
            this.s14.Size = new System.Drawing.Size(87, 21);
            this.s14.TabIndex = 49;
            this.s14.Text = "Servo 14";
            this.s14.UseVisualStyleBackColor = true;
            this.s14.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s13
            // 
            this.s13.AutoSize = true;
            this.s13.Location = new System.Drawing.Point(371, 314);
            this.s13.Name = "s13";
            this.s13.Size = new System.Drawing.Size(83, 21);
            this.s13.TabIndex = 52;
            this.s13.Text = "Servo13";
            this.s13.UseVisualStyleBackColor = true;
            this.s13.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s12
            // 
            this.s12.AutoSize = true;
            this.s12.Location = new System.Drawing.Point(371, 284);
            this.s12.Name = "s12";
            this.s12.Size = new System.Drawing.Size(87, 21);
            this.s12.TabIndex = 53;
            this.s12.Text = "Servo 12";
            this.s12.UseVisualStyleBackColor = true;
            this.s12.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s11
            // 
            this.s11.AutoSize = true;
            this.s11.Location = new System.Drawing.Point(371, 253);
            this.s11.Name = "s11";
            this.s11.Size = new System.Drawing.Size(87, 21);
            this.s11.TabIndex = 54;
            this.s11.Text = "Servo 11";
            this.s11.UseVisualStyleBackColor = true;
            this.s11.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s10
            // 
            this.s10.AutoSize = true;
            this.s10.Location = new System.Drawing.Point(371, 226);
            this.s10.Name = "s10";
            this.s10.Size = new System.Drawing.Size(87, 21);
            this.s10.TabIndex = 55;
            this.s10.Text = "Servo 10";
            this.s10.UseVisualStyleBackColor = true;
            this.s10.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s7
            // 
            this.s7.AutoSize = true;
            this.s7.Location = new System.Drawing.Point(53, 369);
            this.s7.Name = "s7";
            this.s7.Size = new System.Drawing.Size(79, 21);
            this.s7.TabIndex = 56;
            this.s7.Text = "Servo 7";
            this.s7.UseVisualStyleBackColor = true;
            this.s7.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s6
            // 
            this.s6.AutoSize = true;
            this.s6.Location = new System.Drawing.Point(52, 341);
            this.s6.Name = "s6";
            this.s6.Size = new System.Drawing.Size(79, 21);
            this.s6.TabIndex = 57;
            this.s6.Text = "Servo 6";
            this.s6.UseVisualStyleBackColor = true;
            this.s6.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s5
            // 
            this.s5.AutoSize = true;
            this.s5.Location = new System.Drawing.Point(52, 314);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(79, 21);
            this.s5.TabIndex = 58;
            this.s5.Text = "Servo 5";
            this.s5.UseVisualStyleBackColor = true;
            this.s5.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s4
            // 
            this.s4.AutoSize = true;
            this.s4.Location = new System.Drawing.Point(52, 285);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(79, 21);
            this.s4.TabIndex = 59;
            this.s4.Text = "Servo 4";
            this.s4.UseVisualStyleBackColor = true;
            this.s4.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s3
            // 
            this.s3.AutoSize = true;
            this.s3.Location = new System.Drawing.Point(53, 256);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(79, 21);
            this.s3.TabIndex = 60;
            this.s3.Text = "Servo 3";
            this.s3.UseVisualStyleBackColor = true;
            this.s3.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.Location = new System.Drawing.Point(52, 226);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(79, 21);
            this.s2.TabIndex = 61;
            this.s2.Text = "Servo 2";
            this.s2.UseVisualStyleBackColor = true;
            this.s2.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.Location = new System.Drawing.Point(52, 197);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(79, 21);
            this.s1.TabIndex = 62;
            this.s1.Text = "Servo 1";
            this.s1.UseVisualStyleBackColor = true;
            this.s1.CheckStateChanged += new System.EventHandler(this.click_check);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Location = new System.Drawing.Point(277, 169);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(60, 51);
            this.add.TabIndex = 63;
            this.add.Text = "˄";
            this.add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sub.Location = new System.Drawing.Point(277, 226);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(60, 51);
            this.sub.TabIndex = 64;
            this.sub.Text = "˅";
            this.sub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(751, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 65;
            this.button3.Text = "Bend";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(751, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 66;
            this.button4.Text = "Pushup";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // inc
            // 
            this.inc.Location = new System.Drawing.Point(277, 130);
            this.inc.Name = "inc";
            this.inc.Size = new System.Drawing.Size(60, 22);
            this.inc.TabIndex = 67;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(722, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 22);
            this.textBox1.TabIndex = 68;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(802, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 23);
            this.button5.TabIndex = 69;
            this.button5.Text = "enter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(262, 283);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 70;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(741, 195);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 65);
            this.button7.TabIndex = 71;
            this.button7.Text = "Detach selected";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 684);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.s5);
            this.Controls.Add(this.s6);
            this.Controls.Add(this.s7);
            this.Controls.Add(this.s9);
            this.Controls.Add(this.s8);
            this.Controls.Add(this.s0);
            this.Controls.Add(this.save);
            this.Controls.Add(this.start);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datarecieved);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.combox);
            this.Controls.Add(this.datasent);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.servo_16);
            this.Controls.Add(this.servo_15);
            this.Controls.Add(this.servo_14);
            this.Controls.Add(this.servo_13);
            this.Controls.Add(this.servo_12);
            this.Controls.Add(this.servo_11);
            this.Controls.Add(this.servo_10);
            this.Controls.Add(this.servo_9);
            this.Controls.Add(this.servo_8);
            this.Controls.Add(this.servo_7);
            this.Controls.Add(this.servo_6);
            this.Controls.Add(this.servo_5);
            this.Controls.Add(this.servo_4);
            this.Controls.Add(this.servo_3);
            this.Controls.Add(this.servo_2);
            this.Controls.Add(this.servo_1);
            this.Controls.Add(this.s10);
            this.Controls.Add(this.s12);
            this.Controls.Add(this.s13);
            this.Controls.Add(this.s14);
            this.Controls.Add(this.s15);
            this.Controls.Add(this.s11);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servo_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servo_16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown servo_1;
        private System.Windows.Forms.NumericUpDown servo_2;
        private System.Windows.Forms.NumericUpDown servo_3;
        private System.Windows.Forms.NumericUpDown servo_4;
        private System.Windows.Forms.NumericUpDown servo_5;
        private System.Windows.Forms.NumericUpDown servo_6;
        private System.Windows.Forms.NumericUpDown servo_7;
        private System.Windows.Forms.NumericUpDown servo_8;
        private System.Windows.Forms.NumericUpDown servo_9;
        private System.Windows.Forms.NumericUpDown servo_10;
        private System.Windows.Forms.NumericUpDown servo_11;
        private System.Windows.Forms.NumericUpDown servo_12;
        private System.Windows.Forms.NumericUpDown servo_13;
        private System.Windows.Forms.NumericUpDown servo_14;
        private System.Windows.Forms.NumericUpDown servo_15;
        private System.Windows.Forms.NumericUpDown servo_16;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox datasent;
        private System.Windows.Forms.ListBox combox;
        private System.Windows.Forms.TextBox textBox18;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox datarecieved;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.CheckBox s0;
        private System.Windows.Forms.CheckBox s8;
        private System.Windows.Forms.CheckBox s9;
        private System.Windows.Forms.CheckBox s15;
        private System.Windows.Forms.CheckBox s14;
        private System.Windows.Forms.CheckBox s13;
        private System.Windows.Forms.CheckBox s12;
        private System.Windows.Forms.CheckBox s11;
        private System.Windows.Forms.CheckBox s10;
        private System.Windows.Forms.CheckBox s7;
        private System.Windows.Forms.CheckBox s6;
        private System.Windows.Forms.CheckBox s5;
        private System.Windows.Forms.CheckBox s4;
        private System.Windows.Forms.CheckBox s3;
        private System.Windows.Forms.CheckBox s2;
        private System.Windows.Forms.CheckBox s1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown inc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

