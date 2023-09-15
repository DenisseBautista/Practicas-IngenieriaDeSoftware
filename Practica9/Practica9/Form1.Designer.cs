namespace Practica9
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pBcalc = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pBword = new System.Windows.Forms.PictureBox();
            this.pBpower = new System.Windows.Forms.PictureBox();
            this.pBexcel = new System.Windows.Forms.PictureBox();
            this.pBone = new System.Windows.Forms.PictureBox();
            this.pBreloj = new System.Windows.Forms.PictureBox();
            this.pBchr = new System.Windows.Forms.PictureBox();
            this.pBadmin = new System.Windows.Forms.PictureBox();
            this.pBcorreo = new System.Windows.Forms.PictureBox();
            this.pBMedia = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBcalc)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBexcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBreloj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBchr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBadmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pBMedia);
            this.groupBox2.Controls.Add(this.pBcorreo);
            this.groupBox2.Controls.Add(this.pBadmin);
            this.groupBox2.Controls.Add(this.pBchr);
            this.groupBox2.Controls.Add(this.pBreloj);
            this.groupBox2.Controls.Add(this.pBone);
            this.groupBox2.Controls.Add(this.pBexcel);
            this.groupBox2.Controls.Add(this.pBpower);
            this.groupBox2.Controls.Add(this.pBword);
            this.groupBox2.Controls.Add(this.pBcalc);
            this.groupBox2.Location = new System.Drawing.Point(26, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 400);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sistema";
            // 
            // pBcalc
            // 
            this.pBcalc.Image = ((System.Drawing.Image)(resources.GetObject("pBcalc.Image")));
            this.pBcalc.Location = new System.Drawing.Point(16, 46);
            this.pBcalc.Name = "pBcalc";
            this.pBcalc.Size = new System.Drawing.Size(58, 69);
            this.pBcalc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBcalc.TabIndex = 0;
            this.pBcalc.TabStop = false;
            this.pBcalc.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(646, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Archivo";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Firma";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Salir";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // pBword
            // 
            this.pBword.Image = ((System.Drawing.Image)(resources.GetObject("pBword.Image")));
            this.pBword.Location = new System.Drawing.Point(103, 51);
            this.pBword.Name = "pBword";
            this.pBword.Size = new System.Drawing.Size(61, 58);
            this.pBword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBword.TabIndex = 1;
            this.pBword.TabStop = false;
            this.pBword.Click += new System.EventHandler(this.pBword_Click);
            // 
            // pBpower
            // 
            this.pBpower.Image = ((System.Drawing.Image)(resources.GetObject("pBpower.Image")));
            this.pBpower.Location = new System.Drawing.Point(293, 46);
            this.pBpower.Name = "pBpower";
            this.pBpower.Size = new System.Drawing.Size(67, 74);
            this.pBpower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBpower.TabIndex = 2;
            this.pBpower.TabStop = false;
            this.pBpower.Click += new System.EventHandler(this.pBpower_Click);
            // 
            // pBexcel
            // 
            this.pBexcel.Image = ((System.Drawing.Image)(resources.GetObject("pBexcel.Image")));
            this.pBexcel.Location = new System.Drawing.Point(195, 35);
            this.pBexcel.Name = "pBexcel";
            this.pBexcel.Size = new System.Drawing.Size(73, 85);
            this.pBexcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBexcel.TabIndex = 3;
            this.pBexcel.TabStop = false;
            this.pBexcel.Click += new System.EventHandler(this.pBexcel_Click);
            // 
            // pBone
            // 
            this.pBone.Image = ((System.Drawing.Image)(resources.GetObject("pBone.Image")));
            this.pBone.Location = new System.Drawing.Point(16, 146);
            this.pBone.Name = "pBone";
            this.pBone.Size = new System.Drawing.Size(47, 51);
            this.pBone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBone.TabIndex = 4;
            this.pBone.TabStop = false;
            this.pBone.Click += new System.EventHandler(this.pBone_Click);
            // 
            // pBreloj
            // 
            this.pBreloj.Image = ((System.Drawing.Image)(resources.GetObject("pBreloj.Image")));
            this.pBreloj.Location = new System.Drawing.Point(103, 146);
            this.pBreloj.Name = "pBreloj";
            this.pBreloj.Size = new System.Drawing.Size(61, 51);
            this.pBreloj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBreloj.TabIndex = 5;
            this.pBreloj.TabStop = false;
            this.pBreloj.Click += new System.EventHandler(this.pBreloj_Click);
            // 
            // pBchr
            // 
            this.pBchr.Image = ((System.Drawing.Image)(resources.GetObject("pBchr.Image")));
            this.pBchr.Location = new System.Drawing.Point(195, 146);
            this.pBchr.Name = "pBchr";
            this.pBchr.Size = new System.Drawing.Size(54, 51);
            this.pBchr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBchr.TabIndex = 6;
            this.pBchr.TabStop = false;
            this.pBchr.Click += new System.EventHandler(this.pBchr_Click);
            // 
            // pBadmin
            // 
            this.pBadmin.Image = ((System.Drawing.Image)(resources.GetObject("pBadmin.Image")));
            this.pBadmin.Location = new System.Drawing.Point(293, 146);
            this.pBadmin.Name = "pBadmin";
            this.pBadmin.Size = new System.Drawing.Size(56, 51);
            this.pBadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBadmin.TabIndex = 7;
            this.pBadmin.TabStop = false;
            this.pBadmin.Click += new System.EventHandler(this.pBadmin_Click);
            // 
            // pBcorreo
            // 
            this.pBcorreo.Image = ((System.Drawing.Image)(resources.GetObject("pBcorreo.Image")));
            this.pBcorreo.Location = new System.Drawing.Point(13, 232);
            this.pBcorreo.Name = "pBcorreo";
            this.pBcorreo.Size = new System.Drawing.Size(50, 54);
            this.pBcorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBcorreo.TabIndex = 8;
            this.pBcorreo.TabStop = false;
            this.pBcorreo.Click += new System.EventHandler(this.pBcorreo_Click);
            // 
            // pBMedia
            // 
            this.pBMedia.Image = ((System.Drawing.Image)(resources.GetObject("pBMedia.Image")));
            this.pBMedia.Location = new System.Drawing.Point(103, 225);
            this.pBMedia.Name = "pBMedia";
            this.pBMedia.Size = new System.Drawing.Size(61, 61);
            this.pBMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBMedia.TabIndex = 9;
            this.pBMedia.TabStop = false;
            this.pBMedia.Click += new System.EventHandler(this.pBMedia_Click);
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(646, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Sistema";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBcalc)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBexcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBreloj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBchr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBadmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBcorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pBcalc;
        private System.Windows.Forms.PictureBox pBword;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.PictureBox pBpower;
        private System.Windows.Forms.PictureBox pBexcel;
        private System.Windows.Forms.PictureBox pBone;
        private System.Windows.Forms.PictureBox pBadmin;
        private System.Windows.Forms.PictureBox pBchr;
        private System.Windows.Forms.PictureBox pBreloj;
        private System.Windows.Forms.PictureBox pBcorreo;
        private System.Windows.Forms.PictureBox pBMedia;
    }
}

