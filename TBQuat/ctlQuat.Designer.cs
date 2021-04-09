
namespace TBQuat
{
    partial class ctlQuat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlQuat));
            this.timeimage = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timeimage
            // 
            this.timeimage.Interval = 200;
            this.timeimage.Tick += new System.EventHandler(this.timeimage_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "fan1.png");
            this.imageList1.Images.SetKeyName(1, "fan2.png");
            this.imageList1.Images.SetKeyName(2, "fan3.png");
            // 
            // picImage
            // 
            this.picImage.Image = global::TBQuat.Properties.Resources.fan1;
            this.picImage.Location = new System.Drawing.Point(1, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(204, 202);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // ctlQuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picImage);
            this.Name = "ctlQuat";
            this.Size = new System.Drawing.Size(208, 208);
            this.Load += new System.EventHandler(this.ctlQuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timeimage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picImage;
    }
}
