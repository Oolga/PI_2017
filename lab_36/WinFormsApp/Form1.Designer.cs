namespace WinFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonSum = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.textBoxAppZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResultAppZ = new System.Windows.Forms.TextBox();
            this.buttonAddAppZ = new System.Windows.Forms.Button();
            this.buttonGetAppZ = new System.Windows.Forms.Button();
            this.buttonSetAppZ = new System.Windows.Forms.Button();
            this.textBoxGetAppZ = new System.Windows.Forms.TextBox();
            this.textBoxSetAppZ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Х";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(36, 18);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(36, 49);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 3;
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(36, 89);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(34, 23);
            this.buttonSum.TabIndex = 4;
            this.buttonSum.Text = "+";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(76, 89);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(34, 23);
            this.buttonSub.TabIndex = 5;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(116, 89);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(34, 23);
            this.buttonMul.TabIndex = 6;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(232, 89);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult.TabIndex = 7;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(180, 92);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 8;
            this.Result.Text = "Result";
            // 
            // textBoxAppZ
            // 
            this.textBoxAppZ.Location = new System.Drawing.Point(36, 383);
            this.textBoxAppZ.Name = "textBoxAppZ";
            this.textBoxAppZ.Size = new System.Drawing.Size(100, 22);
            this.textBoxAppZ.TabIndex = 26;
            this.textBoxAppZ.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Result app z";
            // 
            // textBoxResultAppZ
            // 
            this.textBoxResultAppZ.Location = new System.Drawing.Point(354, 384);
            this.textBoxResultAppZ.Name = "textBoxResultAppZ";
            this.textBoxResultAppZ.Size = new System.Drawing.Size(100, 22);
            this.textBoxResultAppZ.TabIndex = 24;
            // 
            // buttonAddAppZ
            // 
            this.buttonAddAppZ.Location = new System.Drawing.Point(145, 383);
            this.buttonAddAppZ.Name = "buttonAddAppZ";
            this.buttonAddAppZ.Size = new System.Drawing.Size(34, 23);
            this.buttonAddAppZ.TabIndex = 23;
            this.buttonAddAppZ.Text = "+";
            this.buttonAddAppZ.UseVisualStyleBackColor = true;
            this.buttonAddAppZ.Click += new System.EventHandler(this.buttonAddAppZ_Click);
            // 
            // buttonGetAppZ
            // 
            this.buttonGetAppZ.Location = new System.Drawing.Point(142, 328);
            this.buttonGetAppZ.Name = "buttonGetAppZ";
            this.buttonGetAppZ.Size = new System.Drawing.Size(75, 23);
            this.buttonGetAppZ.TabIndex = 22;
            this.buttonGetAppZ.Text = "GetAppZ";
            this.buttonGetAppZ.UseVisualStyleBackColor = true;
            this.buttonGetAppZ.Click += new System.EventHandler(this.buttonGetAppZ_Click);
            // 
            // buttonSetAppZ
            // 
            this.buttonSetAppZ.Location = new System.Drawing.Point(142, 290);
            this.buttonSetAppZ.Name = "buttonSetAppZ";
            this.buttonSetAppZ.Size = new System.Drawing.Size(75, 23);
            this.buttonSetAppZ.TabIndex = 21;
            this.buttonSetAppZ.Text = "SetAppZ";
            this.buttonSetAppZ.UseVisualStyleBackColor = true;
            this.buttonSetAppZ.Click += new System.EventHandler(this.buttonSetAppZ_Click);
            // 
            // textBoxGetAppZ
            // 
            this.textBoxGetAppZ.Location = new System.Drawing.Point(36, 328);
            this.textBoxGetAppZ.Name = "textBoxGetAppZ";
            this.textBoxGetAppZ.Size = new System.Drawing.Size(100, 22);
            this.textBoxGetAppZ.TabIndex = 20;
            // 
            // textBoxSetAppZ
            // 
            this.textBoxSetAppZ.Location = new System.Drawing.Point(36, 291);
            this.textBoxSetAppZ.Name = "textBoxSetAppZ";
            this.textBoxSetAppZ.Size = new System.Drawing.Size(100, 22);
            this.textBoxSetAppZ.TabIndex = 19;
            this.textBoxSetAppZ.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 444);
            this.Controls.Add(this.textBoxAppZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResultAppZ);
            this.Controls.Add(this.buttonAddAppZ);
            this.Controls.Add(this.buttonGetAppZ);
            this.Controls.Add(this.buttonSetAppZ);
            this.Controls.Add(this.textBoxGetAppZ);
            this.Controls.Add(this.textBoxSetAppZ);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textBoxAppZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResultAppZ;
        private System.Windows.Forms.Button buttonAddAppZ;
        private System.Windows.Forms.Button buttonGetAppZ;
        private System.Windows.Forms.Button buttonSetAppZ;
        private System.Windows.Forms.TextBox textBoxGetAppZ;
        private System.Windows.Forms.TextBox textBoxSetAppZ;
    }
}

