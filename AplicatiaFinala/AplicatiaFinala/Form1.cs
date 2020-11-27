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

namespace AplicatiaFinala
{
    public partial class Form1 : Form
    {
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        /*
         de la primul motor la ultimul (de jos in sus) ---
         1. F --- scade  ;;; T --- creste
         2. G --- scade  ;;; Y --- creste
         3. H --- scade  ;;; U --- creste
         4. J --- scade  ;;; I --- creste
         5. K --- scade  ;;; O --- creste
         6. L --- scade  ;;; P --- creste

         X --- stop
        */

        private void button13_Click(object sender, EventArgs e)
        {
            port = new SerialPort();
            port.BaudRate = 9600;
            port.PortName = Convert.ToString(textBox1.Text);
            bool ok = true;
            try
            {

                port.Open();
                ok = true;

            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
                ok = false;

            }
            if (ok)
            {
                textBox1.Hide();
                button13.Hide();
                button19.Show();

            }

        }

        private void Servo1F(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("F");
        }

        private void Servo1T(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("T");
        }

        private void Servo2G(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("G");
        }

        private void Servo2Y(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("Y");
        }

        private void Servo3H(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("H");
        }

        private void Servo3U(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("U");
        }

        private void Servo4J(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("J");
        }

        private void Servo4I(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("I");
        }

        private void Servo5K(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("K");
        }

        private void Servo5O(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("O");
        }

        private void Servo6L(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("L");
        }

        private void Servo6P(object sender, EventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("P");
        }

        private void MotorW(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("S");
        }

        private void MotorA(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("D");
        }

        private void MotorS(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("W");
        }

        private void MotorD(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("A");
        }

        private void MotorWStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void MotorAStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void MotorSStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void MouseDStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void Servo1FStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void Servo1TStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }
        private void Servo2GStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void Servo2YStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }
        private void Servo3HStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void Servo3UStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }
        private void Servo4JStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void Servo4IStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }
        private void Servo5KStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void Servo5OStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }
        private void Servo6LStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void Servo6PStop(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("X");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            port = new SerialPort();
            // port.BaudRate = 9600;
            port.Close();
            button19.Hide();
            button13.Show();
            textBox1.Show();
        }

        private void Servo4J(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("J");
        }

        private void Servo4I(object sender, MouseEventArgs e)
        {
            if (port.IsOpen)
                port.WriteLine("I");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("test");
        }

       

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
    }
}
