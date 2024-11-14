namespace DRoger_RRHH.vistas
{
    partial class drogerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drogerLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DRoger_Acceder = new System.Windows.Forms.GroupBox();
            this.DRoegr_Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DRoger_DBUsuario = new System.Windows.Forms.TextBox();
            this.DRoger_TBContraseña = new System.Windows.Forms.TextBox();
            this.DRoger_BotonEntrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.DRoger_Acceder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DRoger_RRHH.Properties.Resources.imglogin;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 397);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(601, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // DRoger_Acceder
            // 
            this.DRoger_Acceder.Controls.Add(this.pictureBox4);
            this.DRoger_Acceder.Controls.Add(this.pictureBox3);
            this.DRoger_Acceder.Controls.Add(this.DRoger_BotonEntrar);
            this.DRoger_Acceder.Controls.Add(this.DRoger_TBContraseña);
            this.DRoger_Acceder.Controls.Add(this.DRoger_DBUsuario);
            this.DRoger_Acceder.Controls.Add(this.label2);
            this.DRoger_Acceder.Controls.Add(this.DRoegr_Usuario);
            this.DRoger_Acceder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DRoger_Acceder.Location = new System.Drawing.Point(505, 127);
            this.DRoger_Acceder.Name = "DRoger_Acceder";
            this.DRoger_Acceder.Size = new System.Drawing.Size(345, 244);
            this.DRoger_Acceder.TabIndex = 3;
            this.DRoger_Acceder.TabStop = false;
            this.DRoger_Acceder.Text = "Acceder";
            this.DRoger_Acceder.Enter += new System.EventHandler(this.DRoger_Acceder_Enter);
            // 
            // DRoegr_Usuario
            // 
            this.DRoegr_Usuario.AutoSize = true;
            this.DRoegr_Usuario.Location = new System.Drawing.Point(6, 53);
            this.DRoegr_Usuario.Name = "DRoegr_Usuario";
            this.DRoegr_Usuario.Size = new System.Drawing.Size(54, 16);
            this.DRoegr_Usuario.TabIndex = 0;
            this.DRoegr_Usuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // DRoger_DBUsuario
            // 
            this.DRoger_DBUsuario.Location = new System.Drawing.Point(122, 50);
            this.DRoger_DBUsuario.Name = "DRoger_DBUsuario";
            this.DRoger_DBUsuario.Size = new System.Drawing.Size(149, 22);
            this.DRoger_DBUsuario.TabIndex = 2;
            this.DRoger_DBUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DRoger_TBContraseña
            // 
            this.DRoger_TBContraseña.Location = new System.Drawing.Point(122, 128);
            this.DRoger_TBContraseña.Name = "DRoger_TBContraseña";
            this.DRoger_TBContraseña.Size = new System.Drawing.Size(149, 22);
            this.DRoger_TBContraseña.TabIndex = 3;
            // 
            // DRoger_BotonEntrar
            // 
            this.DRoger_BotonEntrar.BackColor = System.Drawing.Color.IndianRed;
            this.DRoger_BotonEntrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DRoger_BotonEntrar.Location = new System.Drawing.Point(122, 198);
            this.DRoger_BotonEntrar.Name = "DRoger_BotonEntrar";
            this.DRoger_BotonEntrar.Size = new System.Drawing.Size(125, 40);
            this.DRoger_BotonEntrar.TabIndex = 4;
            this.DRoger_BotonEntrar.Text = "Entrar";
            this.DRoger_BotonEntrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(286, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(286, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // drogerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 383);
            this.Controls.Add(this.DRoger_Acceder);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "drogerLogin";
            this.Text = "drogerLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.DRoger_Acceder.ResumeLayout(false);
            this.DRoger_Acceder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox DRoger_Acceder;
        private System.Windows.Forms.TextBox DRoger_DBUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DRoegr_Usuario;
        private System.Windows.Forms.TextBox DRoger_TBContraseña;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button DRoger_BotonEntrar;
    }
}