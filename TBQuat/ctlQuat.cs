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
    public partial class ctlQuat : UserControl
    {

        int idx = 0;
        bool Thuan = true;

        public delegate void RunEventHandler(object Sender, bool ClockwiseDirection, int Speed);
        public event RunEventHandler Running = null;

        public ctlQuat()
        {
            InitializeComponent();
        }

        private void ctlQuat_Load(object sender, EventArgs e)
        {
            picImage.Dock = DockStyle.Fill;
        }

        private void timeimage_Tick(object sender, EventArgs e)
        {
            if (Thuan)
            {
                idx++;
                if (idx >= imageList1.Images.Count)
                {
                    idx = 0;
                }
            }
            else
            {
                idx--;
                if (idx < 0)
                {
                    idx = imageList1.Images.Count - 1;
                }
            }
            picImage.Image = imageList1.Images[idx];
            //Kich hoat su kien co ten Running
            Running?.Invoke(this, Thuan, this.Speed);
        }

        //Cac phuong thuc
        public void Start()
        {
            timeimage.Start();
        }

        public void Stop()
        {
            timeimage.Stop();
        }

        public void Reverse()
        {
            Thuan = !Thuan;
        }

        //Theo chieu kim dong ho
        public void SetClockWise()
        {
            Thuan = true;
        }

        public void AntiSetClockWise()
        {
            Thuan = false;
        }

        //Thuoc tinh Toc do tu 1(cham) den 1000(nhanh)
        public int Speed
        {
            set
            {
                int tam = value;
                if (tam < 1)
                    tam = 1;
                else if (tam > 1000)
                    tam = 1000;

                timeimage.Interval = 1000 - tam + 10;

            }
            get
            {
                return (1010 - timeimage.Interval);
            }
        }
    }
}
