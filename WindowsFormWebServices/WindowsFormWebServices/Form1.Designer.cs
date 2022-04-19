
namespace WindowsFormWebServices
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
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_Sisim = new System.Windows.Forms.Label();
            this.lbl_yil = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_iaim = new System.Windows.Forms.TextBox();
            this.TXT_sisim = new System.Windows.Forms.TextBox();
            this.txt_yil = new System.Windows.Forms.TextBox();
            this.btn_Gönder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(112, 42);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(24, 13);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "TC:";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(119, 84);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(32, 13);
            this.lbl_isim.TabIndex = 1;
            this.lbl_isim.Text = "İSİM:";
            // 
            // lbl_Sisim
            // 
            this.lbl_Sisim.AutoSize = true;
            this.lbl_Sisim.Location = new System.Drawing.Point(118, 125);
            this.lbl_Sisim.Name = "lbl_Sisim";
            this.lbl_Sisim.Size = new System.Drawing.Size(54, 13);
            this.lbl_Sisim.TabIndex = 2;
            this.lbl_Sisim.Text = "SOYİSİM:";
            // 
            // lbl_yil
            // 
            this.lbl_yil.AutoSize = true;
            this.lbl_yil.Location = new System.Drawing.Point(130, 163);
            this.lbl_yil.Name = "lbl_yil";
            this.lbl_yil.Size = new System.Drawing.Size(26, 13);
            this.lbl_yil.TabIndex = 3;
            this.lbl_yil.Text = "YIL:";
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(176, 39);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(143, 20);
            this.txt_tc.TabIndex = 4;
            // 
            // txt_iaim
            // 
            this.txt_iaim.Location = new System.Drawing.Point(176, 82);
            this.txt_iaim.Name = "txt_iaim";
            this.txt_iaim.Size = new System.Drawing.Size(143, 20);
            this.txt_iaim.TabIndex = 5;
            // 
            // TXT_sisim
            // 
            this.TXT_sisim.Location = new System.Drawing.Point(176, 121);
            this.TXT_sisim.Name = "TXT_sisim";
            this.TXT_sisim.Size = new System.Drawing.Size(143, 20);
            this.TXT_sisim.TabIndex = 6;
            // 
            // txt_yil
            // 
            this.txt_yil.Location = new System.Drawing.Point(176, 159);
            this.txt_yil.Name = "txt_yil";
            this.txt_yil.Size = new System.Drawing.Size(143, 20);
            this.txt_yil.TabIndex = 7;
            // 
            // btn_Gönder
            // 
            this.btn_Gönder.BackColor = System.Drawing.Color.White;
            this.btn_Gönder.Location = new System.Drawing.Point(149, 207);
            this.btn_Gönder.Name = "btn_Gönder";
            this.btn_Gönder.Size = new System.Drawing.Size(116, 23);
            this.btn_Gönder.TabIndex = 8;
            this.btn_Gönder.Text = "Gönder";
            this.btn_Gönder.UseVisualStyleBackColor = false;
            this.btn_Gönder.Click += new System.EventHandler(this.btn_Gönder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(427, 286);
            this.Controls.Add(this.btn_Gönder);
            this.Controls.Add(this.txt_yil);
            this.Controls.Add(this.TXT_sisim);
            this.Controls.Add(this.txt_iaim);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.lbl_yil);
            this.Controls.Add(this.lbl_Sisim);
            this.Controls.Add(this.lbl_isim);
            this.Controls.Add(this.lbl_tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_Sisim;
        private System.Windows.Forms.Label lbl_yil;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_iaim;
        private System.Windows.Forms.TextBox TXT_sisim;
        private System.Windows.Forms.TextBox txt_yil;
        private System.Windows.Forms.Button btn_Gönder;
    }
}

