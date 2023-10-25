namespace Iglesia
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pbOcultar = new System.Windows.Forms.PictureBox();
            this.pbMostrar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 26);
            this.textBox1.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(108, 140);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(311, 26);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(251, 176);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(168, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recuperar contraseña";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(427, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // pbOcultar
            // 
            this.pbOcultar.Image = global::Iglesia.Properties.Resources.Diseño_sin_título;
            this.pbOcultar.Location = new System.Drawing.Point(425, 141);
            this.pbOcultar.Name = "pbOcultar";
            this.pbOcultar.Size = new System.Drawing.Size(41, 33);
            this.pbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOcultar.TabIndex = 7;
            this.pbOcultar.TabStop = false;
            this.pbOcultar.Click += new System.EventHandler(this.pbOcultar_Click);
            // 
            // pbMostrar
            // 
            this.pbMostrar.Image = global::Iglesia.Properties.Resources.ojo;
            this.pbMostrar.Location = new System.Drawing.Point(425, 140);
            this.pbMostrar.Name = "pbMostrar";
            this.pbMostrar.Size = new System.Drawing.Size(41, 30);
            this.pbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrar.TabIndex = 6;
            this.pbMostrar.TabStop = false;
            this.pbMostrar.Click += new System.EventHandler(this.pbMostrar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Iglesia.Properties.Resources.ad509a0b_2b57_4de0_9ec8_599f1f1d66a0;
            this.pictureBox4.Location = new System.Drawing.Point(52, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Iglesia.Properties.Resources._9a3c57e9_594f_42dc_b745_e54fa9adebeb;
            this.pictureBox3.Location = new System.Drawing.Point(52, 69);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoEllipsis = true;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIniciarSesion.BackgroundImage = global::Iglesia.Properties.Resources.logo;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 5;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.Location = new System.Drawing.Point(108, 213);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(265, 65);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.BackgroundImage = global::Iglesia.Properties.Resources.logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 47);
            this.panel1.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(490, 316);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbOcultar);
            this.Controls.Add(this.pbMostrar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Iglesia Adm.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbMostrar;
        private System.Windows.Forms.PictureBox pbOcultar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}

