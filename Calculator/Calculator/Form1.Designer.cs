namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button7_Click);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(61, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button8_Click);
            this.button2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(119, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button9_Click);
            this.button3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(177, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonPlus_Click);
            this.button4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(3, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button4_Click);
            this.button5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(61, 58);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button5_Click);
            this.button6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(119, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 49);
            this.button7.TabIndex = 7;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button6_Click);
            this.button7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(177, 58);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(54, 49);
            this.button8.TabIndex = 8;
            this.button8.Text = "-";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonMinus_Click);
            this.button8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(3, 113);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 49);
            this.button9.TabIndex = 9;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button1_Click);
            this.button9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(61, 113);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 49);
            this.button10.TabIndex = 10;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button2_Click);
            this.button10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(119, 113);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(52, 49);
            this.button11.TabIndex = 11;
            this.button11.Text = "3";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button3_Click);
            this.button11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(177, 113);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(54, 49);
            this.button12.TabIndex = 12;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ButtonMult_Click);
            this.button12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(3, 168);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(52, 49);
            this.button13.TabIndex = 13;
            this.button13.Text = "CE";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.ButtonCE_Click);
            this.button13.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Location = new System.Drawing.Point(61, 168);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(52, 49);
            this.button14.TabIndex = 14;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button0_Click);
            this.button14.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Location = new System.Drawing.Point(119, 168);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(52, 49);
            this.button15.TabIndex = 15;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.ButtonP_Click);
            this.button15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Location = new System.Drawing.Point(177, 168);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(54, 49);
            this.button16.TabIndex = 16;
            this.button16.Text = "/";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ButtonDiv_Click);
            this.button16.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.button17, 4);
            this.button17.Location = new System.Drawing.Point(3, 223);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(228, 50);
            this.button17.TabIndex = 17;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.ButtonEq_Click);
            this.button17.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_Up);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button17, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 276);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 750);
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

