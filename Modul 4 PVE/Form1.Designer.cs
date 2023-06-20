
namespace Modul_4_PVE
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
            this.pictureBoxAsli = new System.Windows.Forms.PictureBox();
            this.pictureBoxHasil = new System.Windows.Forms.PictureBox();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.textBoxPusatX = new System.Windows.Forms.TextBox();
            this.textBoxPusatY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAsli
            // 
            this.pictureBoxAsli.Image = global::Modul_4_PVE.Properties.Resources.KTM_Unpad;
            this.pictureBoxAsli.Location = new System.Drawing.Point(54, 44);
            this.pictureBoxAsli.Name = "pictureBoxAsli";
            this.pictureBoxAsli.Size = new System.Drawing.Size(190, 282);
            this.pictureBoxAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAsli.TabIndex = 0;
            this.pictureBoxAsli.TabStop = false;
            // 
            // pictureBoxHasil
            // 
            this.pictureBoxHasil.Location = new System.Drawing.Point(268, 44);
            this.pictureBoxHasil.Name = "pictureBoxHasil";
            this.pictureBoxHasil.Size = new System.Drawing.Size(190, 282);
            this.pictureBoxHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHasil.TabIndex = 1;
            this.pictureBoxHasil.TabStop = false;
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Location = new System.Drawing.Point(588, 65);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(65, 20);
            this.textBoxAngle.TabIndex = 2;
            // 
            // textBoxPusatX
            // 
            this.textBoxPusatX.Location = new System.Drawing.Point(517, 137);
            this.textBoxPusatX.Name = "textBoxPusatX";
            this.textBoxPusatX.Size = new System.Drawing.Size(87, 20);
            this.textBoxPusatX.TabIndex = 3;
            // 
            // textBoxPusatY
            // 
            this.textBoxPusatY.Location = new System.Drawing.Point(636, 137);
            this.textBoxPusatY.Name = "textBoxPusatY";
            this.textBoxPusatY.Size = new System.Drawing.Size(87, 20);
            this.textBoxPusatY.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sudut Rotasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Derajat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pusat Rotasi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Length (Y)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Width (X)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Proses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPusatY);
            this.Controls.Add(this.textBoxPusatX);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.pictureBoxHasil);
            this.Controls.Add(this.pictureBoxAsli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAsli;
        private System.Windows.Forms.PictureBox pictureBoxHasil;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.TextBox textBoxPusatX;
        private System.Windows.Forms.TextBox textBoxPusatY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

