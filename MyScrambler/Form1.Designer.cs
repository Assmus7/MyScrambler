namespace MyScrambler
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lKeyEncode = new System.Windows.Forms.Label();
            this.lMessageEncode = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lResEncode = new System.Windows.Forms.Label();
            this.tbResEncode = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lResDecode = new System.Windows.Forms.Label();
            this.lKeyDecode = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lMessageDecode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbResEncode);
            this.panel1.Controls.Add(this.lResEncode);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lKeyEncode);
            this.panel1.Controls.Add(this.lMessageEncode);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 271);
            this.panel1.TabIndex = 0;
            // 
            // lKeyEncode
            // 
            this.lKeyEncode.AutoSize = true;
            this.lKeyEncode.Location = new System.Drawing.Point(14, 121);
            this.lKeyEncode.Name = "lKeyEncode";
            this.lKeyEncode.Size = new System.Drawing.Size(28, 13);
            this.lKeyEncode.TabIndex = 2;
            this.lKeyEncode.Text = "Key:";
            // 
            // lMessageEncode
            // 
            this.lMessageEncode.AutoSize = true;
            this.lMessageEncode.Location = new System.Drawing.Point(14, 29);
            this.lMessageEncode.Name = "lMessageEncode";
            this.lMessageEncode.Size = new System.Drawing.Size(112, 13);
            this.lMessageEncode.TabIndex = 1;
            this.lMessageEncode.Text = "Введите сообщение:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lMessageDecode);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.lKeyDecode);
            this.panel2.Controls.Add(this.lResDecode);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(288, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 271);
            this.panel2.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(253, 103);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(29, 25);
            this.btnGo.TabIndex = 0;
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lResEncode
            // 
            this.lResEncode.AutoSize = true;
            this.lResEncode.Location = new System.Drawing.Point(14, 178);
            this.lResEncode.Name = "lResEncode";
            this.lResEncode.Size = new System.Drawing.Size(62, 13);
            this.lResEncode.TabIndex = 4;
            this.lResEncode.Text = "Результат:";
            // 
            // tbResEncode
            // 
            this.tbResEncode.Location = new System.Drawing.Point(17, 194);
            this.tbResEncode.Multiline = true;
            this.tbResEncode.Name = "tbResEncode";
            this.tbResEncode.Size = new System.Drawing.Size(200, 63);
            this.tbResEncode.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 45);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 63);
            this.textBox3.TabIndex = 6;
            // 
            // lResDecode
            // 
            this.lResDecode.AutoSize = true;
            this.lResDecode.Location = new System.Drawing.Point(17, 178);
            this.lResDecode.Name = "lResDecode";
            this.lResDecode.Size = new System.Drawing.Size(62, 13);
            this.lResDecode.TabIndex = 7;
            this.lResDecode.Text = "Результат:";
            // 
            // lKeyDecode
            // 
            this.lKeyDecode.AutoSize = true;
            this.lKeyDecode.Location = new System.Drawing.Point(17, 121);
            this.lKeyDecode.Name = "lKeyDecode";
            this.lKeyDecode.Size = new System.Drawing.Size(28, 13);
            this.lKeyDecode.TabIndex = 8;
            this.lKeyDecode.Text = "Key:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(20, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(20, 194);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 38);
            this.textBox5.TabIndex = 10;
            // 
            // lMessageDecode
            // 
            this.lMessageDecode.AutoSize = true;
            this.lMessageDecode.Location = new System.Drawing.Point(17, 29);
            this.lMessageDecode.Name = "lMessageDecode";
            this.lMessageDecode.Size = new System.Drawing.Size(97, 13);
            this.lMessageDecode.TabIndex = 11;
            this.lMessageDecode.Text = "Ваше сообщение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 327);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrambler";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lMessageEncode;
        private System.Windows.Forms.Label lKeyEncode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbResEncode;
        private System.Windows.Forms.Label lResEncode;
        private System.Windows.Forms.Label lMessageDecode;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lKeyDecode;
        private System.Windows.Forms.Label lResDecode;
        private System.Windows.Forms.TextBox textBox3;
    }
}

