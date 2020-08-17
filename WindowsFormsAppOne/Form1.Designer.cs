using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BotonUno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonUno
            // 
            this.BotonUno.BackColor = System.Drawing.Color.LightYellow;
            this.BotonUno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BotonUno.Image = ((System.Drawing.Image)(resources.GetObject("BotonUno.Image")));
            this.BotonUno.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BotonUno.Location = new System.Drawing.Point(395, 115);
            this.BotonUno.Name = "BotonUno";
            this.BotonUno.Size = new System.Drawing.Size(323, 65);
            this.BotonUno.TabIndex = 0;
            this.BotonUno.Text = "DALE CLICK!";
            this.BotonUno.UseVisualStyleBackColor = false;
            this.BotonUno.Click += new System.EventHandler(this.BotonUno_Click);
            this.BotonUno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BotonUno_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(521, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "INTÉNTALO!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Nombre
            // 
            this.Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Nombre.Location = new System.Drawing.Point(413, 234);
            this.Nombre.MaxLength = 4000;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(211, 26);
            this.Nombre.TabIndex = 2;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(413, 289);
            this.textbox2.Multiline = true;
            this.textbox2.Name = "textbox2";
            this.textbox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox2.Size = new System.Drawing.Size(211, 26);
            this.textbox2.TabIndex = 3;
            this.textbox2.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-23, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotonUno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "APPI";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonUno;
        private Label label1;
        private TextBox Nombre;
        private TextBox textbox2;
        private PictureBox pictureBox1;
    }
}

