namespace Prj_Teste
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnHistorico = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConsulta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCadAluno = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header_panel = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.header = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.bntMenu);
            this.bunifuGradientPanel1.Controls.Add(this.pbLogo);
            this.bunifuGradientPanel1.Controls.Add(this.btnHistorico);
            this.bunifuGradientPanel1.Controls.Add(this.btnConsulta);
            this.bunifuGradientPanel1.Controls.Add(this.btnHome);
            this.bunifuGradientPanel1.Controls.Add(this.btnCadAluno);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(14)))), ((int)(((byte)(21)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 35);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(227, 423);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bntMenu
            // 
            this.bntMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMenu.BackColor = System.Drawing.Color.Transparent;
            this.bntMenu.Image = ((System.Drawing.Image)(resources.GetObject("bntMenu.Image")));
            this.bntMenu.ImageActive = null;
            this.bntMenu.Location = new System.Drawing.Point(188, 9);
            this.bntMenu.Name = "bntMenu";
            this.bntMenu.Size = new System.Drawing.Size(30, 30);
            this.bntMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bntMenu.TabIndex = 1;
            this.bntMenu.TabStop = false;
            this.bntMenu.Zoom = 10;
            this.bntMenu.Click += new System.EventHandler(this.bntMenu_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(38, 31);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(104, 32);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // btnHistorico
            // 
            this.btnHistorico.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnHistorico.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorico.BorderRadius = 0;
            this.btnHistorico.ButtonText = "        Histórico";
            this.btnHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorico.DisabledColor = System.Drawing.Color.Gray;
            this.btnHistorico.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistorico.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHistorico.Iconimage")));
            this.btnHistorico.Iconimage_right = null;
            this.btnHistorico.Iconimage_right_Selected = null;
            this.btnHistorico.Iconimage_Selected = null;
            this.btnHistorico.IconMarginLeft = 0;
            this.btnHistorico.IconMarginRight = 0;
            this.btnHistorico.IconRightVisible = true;
            this.btnHistorico.IconRightZoom = 0D;
            this.btnHistorico.IconVisible = true;
            this.btnHistorico.IconZoom = 50D;
            this.btnHistorico.IsTab = true;
            this.btnHistorico.Location = new System.Drawing.Point(0, 232);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHistorico.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnHistorico.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnHistorico.selected = false;
            this.btnHistorico.Size = new System.Drawing.Size(228, 39);
            this.btnHistorico.TabIndex = 4;
            this.btnHistorico.Text = "        Histórico";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Textcolor = System.Drawing.Color.White;
            this.btnHistorico.TextFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnConsulta
            // 
            this.btnConsulta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsulta.BorderRadius = 0;
            this.btnConsulta.ButtonText = "        Consultar";
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsulta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsulta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Iconimage")));
            this.btnConsulta.Iconimage_right = null;
            this.btnConsulta.Iconimage_right_Selected = null;
            this.btnConsulta.Iconimage_Selected = null;
            this.btnConsulta.IconMarginLeft = 0;
            this.btnConsulta.IconMarginRight = 0;
            this.btnConsulta.IconRightVisible = true;
            this.btnConsulta.IconRightZoom = 0D;
            this.btnConsulta.IconVisible = true;
            this.btnConsulta.IconZoom = 50D;
            this.btnConsulta.IsTab = true;
            this.btnConsulta.Location = new System.Drawing.Point(0, 185);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConsulta.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnConsulta.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnConsulta.selected = false;
            this.btnConsulta.Size = new System.Drawing.Size(228, 39);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "        Consultar";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Textcolor = System.Drawing.Color.White;
            this.btnConsulta.TextFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "        Início";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 0;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 50D;
            this.btnHome.IsTab = true;
            this.btnHome.Location = new System.Drawing.Point(0, 91);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnHome.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnHome.selected = true;
            this.btnHome.Size = new System.Drawing.Size(228, 39);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "        Início";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnCadAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnCadAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadAluno.BorderRadius = 0;
            this.btnCadAluno.ButtonText = "        Cadastrar";
            this.btnCadAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadAluno.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.btnCadAluno.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadAluno.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCadAluno.Iconimage")));
            this.btnCadAluno.Iconimage_right = null;
            this.btnCadAluno.Iconimage_right_Selected = null;
            this.btnCadAluno.Iconimage_Selected = null;
            this.btnCadAluno.IconMarginLeft = 0;
            this.btnCadAluno.IconMarginRight = 0;
            this.btnCadAluno.IconRightVisible = true;
            this.btnCadAluno.IconRightZoom = 0D;
            this.btnCadAluno.IconVisible = true;
            this.btnCadAluno.IconZoom = 50D;
            this.btnCadAluno.IsTab = true;
            this.btnCadAluno.Location = new System.Drawing.Point(0, 138);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCadAluno.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCadAluno.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.btnCadAluno.selected = false;
            this.btnCadAluno.Size = new System.Drawing.Size(228, 39);
            this.btnCadAluno.TabIndex = 2;
            this.btnCadAluno.Text = "        Cadastrar";
            this.btnCadAluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadAluno.Textcolor = System.Drawing.Color.White;
            this.btnCadAluno.TextFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.header_panel.Controls.Add(this.btnClose);
            this.header_panel.Controls.Add(this.pictureBox3);
            this.header_panel.Controls.Add(this.bunifuCustomLabel1);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(909, 35);
            this.header_panel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(877, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(35, 8);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(319, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "LISOFT - Empréstimo de Mesas Digitalizadoras";
            // 
            // header
            // 
            this.header.Fixed = true;
            this.header.Horizontal = true;
            this.header.TargetControl = this.header_panel;
            this.header.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(227, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 423);
            this.panel1.TabIndex = 1;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.header_panel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bntMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadAluno;
        private Bunifu.Framework.UI.BunifuFlatButton btnHistorico;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsulta;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bntMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuDragControl header;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}

