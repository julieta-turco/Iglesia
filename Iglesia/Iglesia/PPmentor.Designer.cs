﻿
namespace Iglesia
{
    partial class PPmentor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPmentor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mentoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reunionesDeMentoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postulacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentoresToolStripMenuItem,
            this.cuenta,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mentoresToolStripMenuItem
            // 
            this.mentoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reunionesDeMentoriasToolStripMenuItem,
            this.postulacionesToolStripMenuItem});
            this.mentoresToolStripMenuItem.Name = "mentoresToolStripMenuItem";
            this.mentoresToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.mentoresToolStripMenuItem.Text = "Mentores";
            // 
            // reunionesDeMentoriasToolStripMenuItem
            // 
            this.reunionesDeMentoriasToolStripMenuItem.Name = "reunionesDeMentoriasToolStripMenuItem";
            this.reunionesDeMentoriasToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.reunionesDeMentoriasToolStripMenuItem.Text = "Reuniones de mentorias";
            // 
            // postulacionesToolStripMenuItem
            // 
            this.postulacionesToolStripMenuItem.Name = "postulacionesToolStripMenuItem";
            this.postulacionesToolStripMenuItem.Size = new System.Drawing.Size(332, 34);
            this.postulacionesToolStripMenuItem.Text = "Postulaciones de miembros";
            // 
            // cuenta
            // 
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(80, 32);
            this.cuenta.Text = "cuenta";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(105, 32);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 577);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PPmentor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 579);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PPmentor";
            this.Text = "PPmentor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mentoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reunionesDeMentoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postulacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuenta;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}