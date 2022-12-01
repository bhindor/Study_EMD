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

namespace winform_arduino
{
    public partial class Form1 : Form
    {
        private SerialPort mySerial = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            mySerial.PortName = "COM5";
            mySerial.BaudRate = 9600;
            mySerial.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        /*private byte[] StringToByte(string _str)
        {
            byte[] tmpBytes = Encoding.UTF8.GetBytes(_str);
            return tmpBytes;
        }*/

        private void Led_1_On(object sender, EventArgs e)
        {
            //byte[] datas = StringToByte("1ON");
            //mySerial.Write(datas, 0, datas.Length);
            mySerial.Write("1");
        }

        private void Led_2_On(object sender, EventArgs e)
        {
            mySerial.Write("2");
        }
        private void Led_1_Off(object sender, EventArgs e)
        {
            mySerial.Write("3");
        }

        private void Led_2_Off(object sender, EventArgs e)
        {
            mySerial.Write("4");
        }

        private void Servo_Left(object sender, EventArgs e)
        {
            mySerial.Write("5");
        }

        private void Servo_Right(object sender, EventArgs e)
        {
            mySerial.Write("6");
        }
    }
}
