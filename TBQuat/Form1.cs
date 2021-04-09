using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TBQuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string s;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btPort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();

            serialPort1.PortName = txtPort.Text;

            try
            {
                serialPort1.Open();

                MessageBox.Show("Connect!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String tocdo = txtSpeed.Text;
            if (serialPort1.IsOpen)
                if (serialPort1.BytesToRead > 0)
                {
                    txtReceive.Text = serialPort1.ReadExisting();
                    if (txtReceive.Text == "Start")
                        ctlQuatT.Start();
                    if (txtReceive.Text == "Stop")
                        ctlQuatT.Stop();
                    if (txtReceive.Text == "Reverse")
                        ctlQuatT.Reverse();
                    if (int.Parse(txtSpeed.Text) >= 1 && int.Parse(txtSpeed.Text) <= 1000)
                    {
                        ctlQuatT.Speed = int.Parse(txtSpeed.Text);
                    }
                }


        }

        private void XulyDL()
        {
            if (s.IndexOf("#B#") < 0) return;
            if (s.IndexOf("#E#") < 0) return;

            int i1 = s.IndexOf("#B#");
            int i2 = s.IndexOf("#E#");
            string s1 = s.Substring(i1 + 3, i2 - 3);

        }
    }
}
