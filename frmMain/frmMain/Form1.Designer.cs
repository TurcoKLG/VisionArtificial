namespace frmMain
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imgBox1 = new Emgu.CV.UI.ImageBox();
            this.imgBox2 = new Emgu.CV.UI.ImageBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grbPre = new System.Windows.Forms.GroupBox();
            this.btnCalib = new System.Windows.Forms.Button();
            this.grbCams = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox2)).BeginInit();
            this.grbPre.SuspendLayout();
            this.grbCams.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgBox1
            // 
            this.imgBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgBox1.InitialImage")));
            this.imgBox1.Location = new System.Drawing.Point(23, 20);
            this.imgBox1.Name = "imgBox1";
            this.imgBox1.Size = new System.Drawing.Size(650, 430);
            this.imgBox1.TabIndex = 2;
            this.imgBox1.TabStop = false;
            // 
            // imgBox2
            // 
            this.imgBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgBox2.InitialImage")));
            this.imgBox2.Location = new System.Drawing.Point(679, 20);
            this.imgBox2.Name = "imgBox2";
            this.imgBox2.Size = new System.Drawing.Size(650, 430);
            this.imgBox2.TabIndex = 3;
            this.imgBox2.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(18, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(145, 55);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grbPre
            // 
            this.grbPre.Controls.Add(this.btnConnect);
            this.grbPre.Controls.Add(this.btnCalib);
            this.grbPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbPre.Location = new System.Drawing.Point(55, 25);
            this.grbPre.Name = "grbPre";
            this.grbPre.Size = new System.Drawing.Size(178, 474);
            this.grbPre.TabIndex = 6;
            this.grbPre.TabStop = false;
            // 
            // btnCalib
            // 
            this.btnCalib.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalib.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalib.ForeColor = System.Drawing.Color.White;
            this.btnCalib.Location = new System.Drawing.Point(18, 92);
            this.btnCalib.Name = "btnCalib";
            this.btnCalib.Size = new System.Drawing.Size(145, 55);
            this.btnCalib.TabIndex = 6;
            this.btnCalib.Text = "Calibrar";
            this.btnCalib.UseVisualStyleBackColor = false;
            // 
            // grbCams
            // 
            this.grbCams.Controls.Add(this.imgBox1);
            this.grbCams.Controls.Add(this.imgBox2);
            this.grbCams.Location = new System.Drawing.Point(264, 25);
            this.grbCams.Name = "grbCams";
            this.grbCams.Size = new System.Drawing.Size(1350, 474);
            this.grbCams.TabIndex = 7;
            this.grbCams.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.grbCams);
            this.Controls.Add(this.grbPre);
            this.Font = new System.Drawing.Font("Oxygen", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Artificial Vision";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox2)).EndInit();
            this.grbPre.ResumeLayout(false);
            this.grbCams.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBox1;
        private Emgu.CV.UI.ImageBox imgBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grbPre;
        private System.Windows.Forms.Button btnCalib;
        private System.Windows.Forms.GroupBox grbCams;
    }
}

