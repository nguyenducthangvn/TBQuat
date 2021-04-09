
namespace TBQuat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btPort = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.ctlQuatT = new TBQuat.ctlQuat();
            this.SuspendLayout();
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(9, 66);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.Size = new System.Drawing.Size(100, 20);
            this.txtReceive.TabIndex = 9;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(9, 9);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "COM2";
            // 
            // btPort
            // 
            this.btPort.Location = new System.Drawing.Point(115, 6);
            this.btPort.Name = "btPort";
            this.btPort.Size = new System.Drawing.Size(75, 23);
            this.btPort.TabIndex = 5;
            this.btPort.Text = "Port";
            this.btPort.UseVisualStyleBackColor = true;
            this.btPort.Click += new System.EventHandler(this.btPort_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fan1.png");
            this.imageList1.Images.SetKeyName(1, "fan2.png");
            this.imageList1.Images.SetKeyName(2, "fan3.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(9, 92);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.ReadOnly = true;
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 11;
            this.txtSpeed.Text = "500";
            // 
            // ctlQuatT
            // 
            this.ctlQuatT.Location = new System.Drawing.Point(236, 9);
            this.ctlQuatT.Name = "ctlQuatT";
            this.ctlQuatT.Size = new System.Drawing.Size(208, 208);
            this.ctlQuatT.Speed = 810;
            this.ctlQuatT.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 272);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.ctlQuatT);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btPort);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btPort;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private ctlQuat ctlQuatT;
        private System.Windows.Forms.TextBox txtSpeed;
    }
}

