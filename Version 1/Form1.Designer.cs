namespace Version_1
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
            this.XePlayer = new System.Windows.Forms.PictureBox();
            this.XeComputer = new System.Windows.Forms.PictureBox();
            this.timerDiChuyenXe = new System.Windows.Forms.Timer(this.components);
            this.NutPlay = new System.Windows.Forms.PictureBox();
            this.VuNo = new System.Windows.Forms.PictureBox();
            this.lblDiemSo = new System.Windows.Forms.Label();
            this.VienDan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.XePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XeComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NutPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VuNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VienDan)).BeginInit();
            this.SuspendLayout();
            // 
            // XePlayer
            // 
            this.XePlayer.Image = ((System.Drawing.Image)(resources.GetObject("XePlayer.Image")));
            this.XePlayer.Location = new System.Drawing.Point(573, 331);
            this.XePlayer.Name = "XePlayer";
            this.XePlayer.Size = new System.Drawing.Size(78, 149);
            this.XePlayer.TabIndex = 0;
            this.XePlayer.TabStop = false;
            this.XePlayer.Click += new System.EventHandler(this.XePlayer_Click);
            this.XePlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XePlayer_MouseDown);
            this.XePlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.XePlayer_MouseMove);
            this.XePlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XePlayer_MouseUp);
            // 
            // XeComputer
            // 
            this.XeComputer.Image = ((System.Drawing.Image)(resources.GetObject("XeComputer.Image")));
            this.XeComputer.Location = new System.Drawing.Point(85, 112);
            this.XeComputer.Name = "XeComputer";
            this.XeComputer.Size = new System.Drawing.Size(76, 149);
            this.XeComputer.TabIndex = 1;
            this.XeComputer.TabStop = false;
            this.XeComputer.Click += new System.EventHandler(this.XeComputer_Click);
            // 
            // timerDiChuyenXe
            // 
            this.timerDiChuyenXe.Interval = 1;
            this.timerDiChuyenXe.Tick += new System.EventHandler(this.timerDiChuyenXe_Tick);
            // 
            // NutPlay
            // 
            this.NutPlay.Image = ((System.Drawing.Image)(resources.GetObject("NutPlay.Image")));
            this.NutPlay.Location = new System.Drawing.Point(632, 33);
            this.NutPlay.Name = "NutPlay";
            this.NutPlay.Size = new System.Drawing.Size(56, 52);
            this.NutPlay.TabIndex = 2;
            this.NutPlay.TabStop = false;
            this.NutPlay.Click += new System.EventHandler(this.NutPlay_Click);
            // 
            // VuNo
            // 
            this.VuNo.Image = ((System.Drawing.Image)(resources.GetObject("VuNo.Image")));
            this.VuNo.Location = new System.Drawing.Point(215, 341);
            this.VuNo.Name = "VuNo";
            this.VuNo.Size = new System.Drawing.Size(154, 163);
            this.VuNo.TabIndex = 3;
            this.VuNo.TabStop = false;
            // 
            // lblDiemSo
            // 
            this.lblDiemSo.AutoSize = true;
            this.lblDiemSo.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemSo.Location = new System.Drawing.Point(12, 19);
            this.lblDiemSo.Name = "lblDiemSo";
            this.lblDiemSo.Size = new System.Drawing.Size(107, 37);
            this.lblDiemSo.TabIndex = 4;
            this.lblDiemSo.Text = "Score:";
            // 
            // VienDan
            // 
            this.VienDan.Image = ((System.Drawing.Image)(resources.GetObject("VienDan.Image")));
            this.VienDan.Location = new System.Drawing.Point(429, 112);
            this.VienDan.Name = "VienDan";
            this.VienDan.Size = new System.Drawing.Size(30, 100);
            this.VienDan.TabIndex = 5;
            this.VienDan.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(748, 741);
            this.Controls.Add(this.VienDan);
            this.Controls.Add(this.lblDiemSo);
            this.Controls.Add(this.VuNo);
            this.Controls.Add(this.NutPlay);
            this.Controls.Add(this.XeComputer);
            this.Controls.Add(this.XePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Speed King";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.XePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XeComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NutPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VuNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VienDan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox XePlayer;
        private System.Windows.Forms.PictureBox XeComputer;
        private System.Windows.Forms.Timer timerDiChuyenXe;
        private System.Windows.Forms.PictureBox NutPlay;
        private System.Windows.Forms.PictureBox VuNo;
        private System.Windows.Forms.Label lblDiemSo;
        private System.Windows.Forms.PictureBox VienDan;
    }
}

