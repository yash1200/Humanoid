using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class form1 : Form
    {
        bool[] check = new bool[16];
        string[] ports;
        SerialPort myport;

        public form1()
        {
            InitializeComponent();
        }


        private void send_btn_Load(object sender, EventArgs e)
        {
            decimal d1 = servo_1.Value;
            decimal d2 = servo_2.Value;
            decimal d3 = servo_3.Value;
            decimal d4 = servo_4.Value;
            decimal d5 = servo_5.Value;
            decimal d6 = servo_6.Value;
            decimal d7 = servo_7.Value;
            decimal d8 = servo_8.Value;
            decimal d9 = servo_9.Value;
            decimal d10 = servo_10.Value;
            decimal d11 = servo_11.Value;
            decimal d12 = servo_12.Value;
            decimal d13 = servo_13.Value;
            decimal d14 = servo_14.Value;
            decimal d15 = servo_15.Value;
            decimal d16 = servo_16.Value;
            String str = d1.ToString() + "," + d2.ToString() + "," + d3.ToString() + "," +
                d4.ToString() + "," + d5.ToString() + "," + d6.ToString() + "," +
                d7.ToString() + "," + d8.ToString() + "," + d9.ToString() + "," +
                d10.ToString() + "," + d11.ToString() + "," + d12.ToString() + "," +
                d13.ToString() + "," + d14.ToString() + "," + d15.ToString() + "," +
                d16.ToString() + ";";
            datasent.Text = str;
        }

        private void servo_1_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            decimal d1 = servo_1.Value;
            decimal d2 = servo_2.Value;
            decimal d3 = servo_3.Value;
            decimal d4 = servo_4.Value;
            decimal d5 = servo_5.Value;
            decimal d6 = servo_6.Value;
            decimal d7 = servo_7.Value;
            decimal d8 = servo_8.Value;
            decimal d9 = servo_9.Value;
            decimal d10 = servo_10.Value;
            decimal d11 = servo_11.Value;
            decimal d12 = servo_12.Value;
            decimal d13 = servo_13.Value;
            decimal d14 = servo_14.Value;
            decimal d15 = servo_15.Value;
            decimal d16 = servo_16.Value;
            String str = d1.ToString() + "," + d2.ToString() + "," + d3.ToString() + "," +
                d4.ToString() + "," + d5.ToString() + "," + d6.ToString() + "," +
                d7.ToString() + "," + d8.ToString() + "," + d9.ToString() + "," +
                d10.ToString() + "," + d11.ToString() + "," + d12.ToString() + "," +
                d13.ToString() + "," + d14.ToString() + "," + d15.ToString() + "," +
                d16.ToString() + ";";
            datasent.Text = str;
            try
            {
                serialPort1.Write(str);
            }
            catch (Exception eee)
            {

            }
            //myport.WriteLine(str);
        }

        private void form_Load(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            ports = SerialPort.GetPortNames();
            // string[] ports = {"com1","com2"};
            int length = ports.Length;
            serialread();
            for (int i = 0; i <= length; i++)
            {
                try
                {
                    combox.Items.Add(ports.GetValue(i));
                }
                catch (Exception ex)
                {

                }
            }



            // Display each port name to the console.

        }
        public void Update_Value()
        {
            decimal d1 = servo_1.Value;
            decimal d2 = servo_2.Value;
            decimal d3 = servo_3.Value;
            decimal d4 = servo_4.Value;
            decimal d5 = servo_5.Value;
            decimal d6 = servo_6.Value;
            decimal d7 = servo_7.Value;
            decimal d8 = servo_8.Value;
            decimal d9 = servo_9.Value;
            decimal d10 = servo_10.Value;
            decimal d11 = servo_11.Value;
            decimal d12 = servo_12.Value;
            decimal d13 = servo_13.Value;
            decimal d14 = servo_14.Value;
            decimal d15 = servo_15.Value;
            decimal d16 = servo_16.Value;
            String str = d1.ToString() + "," + d2.ToString() + "," + d3.ToString() + "," +
                d4.ToString() + "," + d5.ToString() + "," + d6.ToString() + "," +
                d7.ToString() + "," + d8.ToString() + "," + d9.ToString() + "," +
                d10.ToString() + "," + d11.ToString() + "," + d12.ToString() + "," +
                d13.ToString() + "," + d14.ToString() + "," + d15.ToString() + "," +
                d16.ToString() + ";";
            datasent.Text = str;
            try
            {
                serialPort1.Write(str);
            }
            catch (Exception eee)
            {

            }
            //myport.WriteLine(str);

        }

        private void combox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.combox.IndexFromPoint(e.Location);
            try
            {
                textBox18.Text = ports.GetValue(index).ToString();
                serialPort1.PortName = ports.GetValue(index).ToString();
            }
            catch (Exception ep)
            {

            }
            try
            {
                serialPort1.PortName = ports.GetValue(index).ToString();
            }
            catch { }
            if (serialPort1.IsOpen)
                serialPort1.Close();
            try
            {

                serialPort1.ReceivedBytesThreshold = 1;
                serialPort1.Open();

                // myport = new SerialPort();
                // myport.BaudRate = 9600;
                // myport.PortName = ports.GetValue(index).ToString();
                // myport.Open();

            }
            catch (Exception eps)
            {

            }
            finally
            {

                //send_btn.Enabled = true;

                //serialPort1.Write("start;");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                    return;


                string rd;
                rd = serialPort1.ReadLine();
                BeginInvoke(new Action(() => datarecieved.Text = rd));
                BeginInvoke(new Action(() => listBox1.Items.Add(rd)));
            }
            catch { }
        }

        private void servo_2_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_3_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_4_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_5_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_6_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_7_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_8_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_9_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_10_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_11_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_12_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_13_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_14_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_15_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void servo_16_ValueChanged(object sender, EventArgs e)
        {
            Update_Value();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("getservoread;");
            }
            catch (Exception eee)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("detach;");
            }
            catch (Exception eee)
            {

            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("start;");
                send_btn.Enabled = true;

            }
            catch (Exception esp)
            {

            }
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            serialPort1.Write("saveinit;");
        }


        private void serialread()////////////read incoming data for servo angles
        {
            int[] ang = //{ 87, 91, 100, 91, 92, 96, 79, 109, 82, 97, 84, 100, 94, 96, 93, 90 };
                //{84,118,119,129,92,93,113,128,127,97,84,100,94,96,163,160};  
            //{ 87, 91, 100, 95, 92, 96, 79, 109, 86, 97, 84, 100, 11, 18, 107, 115 };
            //{ 84,14,30,180,92,93,2,39,171,97,84,100,87,94,45,53};
            {87,91,100,95,92,96,79,109,86,97,84,100,11,18,107,115};
            

            String input = textBox1.Text;
            if (input != null)
            {
                Console.WriteLine(input);
                int a = 0;
                int p = 0;
                int comma = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == ',')
                    {
                        comma++;
                    }
                }
                if (comma == 15)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == ',')
                        {
                            Console.WriteLine(input.Substring(p, i-p));
                            Console.WriteLine(p);
                            Console.WriteLine(i);
                            ang[a] = Convert.ToInt32(input.Substring(p, i-p));
                            a++;
                            p = i + 1;
                        }
                    }
                    ang[a] = Convert.ToInt32(input.Substring(p, input.Length-p));

                }
            }

           


            servo_1.Value = ang[0];
            servo_2.Value = ang[1];
            servo_3.Value = ang[2];
            servo_4.Value = ang[3];
            servo_5.Value = ang[4];
            servo_6.Value = ang[5];
            servo_7.Value = ang[6];
            servo_8.Value = ang[7];
            servo_9.Value = ang[8];
            servo_10.Value = ang[9];
            servo_11.Value = ang[10];
            servo_12.Value = ang[11];
            servo_13.Value = ang[12];
            servo_14.Value = ang[13];
            servo_15.Value = ang[14];
            servo_16.Value = ang[15];

        }





        private void click_check(object sender, EventArgs e)
        {
            
                //String id = String.Format("s%d",i);
                //CheckBox checkbox = (CheckBox)this.Controls[id];
                string id = (sender as CheckBox).Name;
                CheckBox checkbox = (CheckBox)this.Controls[id];
                int a = int.Parse(id.Substring(1));
                if (checkbox.Checked)
                {
                    check[a] = true;
                }
                else
                {
                    check[a] = false;
                }
            








        }



        

        private void add_Click(object sender, EventArgs e)
        {

           // String id = String.Format("servo_%d", i + 1);
            decimal a = inc.Value;
            foreach (NumericUpDown ctlNumeric in this.Controls.OfType<NumericUpDown>())
            {
                if (ctlNumeric.Name.Length > 6)
                {
                    int p = int.Parse(ctlNumeric.Name.Substring(6));
                    if (check[p - 1])
                    {
                        var value = ctlNumeric.Value;
                        value += a;
                        if(value>180)
                        {
                            value = 180;
                        }
                        ctlNumeric.Value = value;
                    }


                }
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            decimal a = inc.Value;
            foreach (NumericUpDown ctlNumeric in this.Controls.OfType<NumericUpDown>())
            {
                if (ctlNumeric.Name.Length > 6)
                {
                    int p = int.Parse(ctlNumeric.Name.Substring(6));
                    if (check[p - 1])
                    {
                        var value = ctlNumeric.Value;
                        value -= a;
                        if(value>=180)
                        {
                            value = 180;
                        }
                        if (value <= 0)
                        {
                            value = 0;
                        }
                        try {
                            ctlNumeric.Value = value;
                        }
                        catch { }
                        
                    }


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("bend;");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("pushup;");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialread();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialread();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal[] d = new decimal[16];
           for(int i = 0;i<16;i++)
           {
            string id = "Servo_"+ (i+1).ToString() ;
            NumericUpDown checkbox = (NumericUpDown)this.Controls[id];
            d[i] = checkbox.Value;
           }
           
            for (int i = 0; i < 16;i++ )
            {
                if(check[i] == true)
                {
                    d[i] = -2;
                }
            }


            String str = d[0].ToString();
            for (int i = 1; i < 15; i++)
            {
                str = str + "," + d[i].ToString();
            }
            str = str+"," + d[15].ToString() + ";";

            
            
            
            datasent.Text = str;
            try
            {
                serialPort1.Write(str);
            }
            catch (Exception eee)
            {

            }
            //myport.WriteLine(str);
        }

        

       
     }
}
        
    

