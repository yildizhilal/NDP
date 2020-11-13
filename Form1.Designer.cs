namespace NesneyeDayaliProgramlama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelTc = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonara = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.buttontcsorgulama = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxmaas = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(449, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAAŞ HESAPLAMA";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(27, 510);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(56, 25);
            this.labelTc.TabIndex = 1;
            this.labelTc.Text = "TC : ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(60, 168);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(908, 314);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // buttonara
            // 
            this.buttonara.Location = new System.Drawing.Point(725, 104);
            this.buttonara.Name = "buttonara";
            this.buttonara.Size = new System.Drawing.Size(243, 44);
            this.buttonara.TabIndex = 17;
            this.buttonara.Text = "DOSYA OKU";
            this.buttonara.UseVisualStyleBackColor = true;
            this.buttonara.Click += new System.EventHandler(this.buttondosyaokuma_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttontcsorgulama
            // 
            this.buttontcsorgulama.Location = new System.Drawing.Point(330, 505);
            this.buttontcsorgulama.Name = "buttontcsorgulama";
            this.buttontcsorgulama.Size = new System.Drawing.Size(278, 41);
            this.buttontcsorgulama.TabIndex = 18;
            this.buttontcsorgulama.Text = "SORGULA ve HESAPLA";
            this.buttontcsorgulama.UseVisualStyleBackColor = true;
            this.buttontcsorgulama.Click += new System.EventHandler(this.buttontcsorgulama_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 510);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 30);
            this.textBox1.TabIndex = 19;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(32, 579);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(604, 96);
            this.richTextBox2.TabIndex = 20;
            this.richTextBox2.Text = "";
            // 
            // richTextBoxmaas
            // 
            this.richTextBoxmaas.Location = new System.Drawing.Point(683, 579);
            this.richTextBoxmaas.Name = "richTextBoxmaas";
            this.richTextBoxmaas.Size = new System.Drawing.Size(239, 96);
            this.richTextBoxmaas.TabIndex = 21;
            this.richTextBoxmaas.Text = "";
            this.richTextBoxmaas.TextChanged += new System.EventHandler(this.richTextBoxmaas_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 848);
            this.Controls.Add(this.richTextBoxmaas);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttontcsorgulama);
            this.Controls.Add(this.buttonara);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelTc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonara;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttontcsorgulama;
        private System.Windows.Forms.RichTextBox richTextBoxmaas;
    }
}

