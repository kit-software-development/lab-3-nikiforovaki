namespace RunningButton
{
    partial class RunningForm
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
            this.RunButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RunButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RunButton.Location = new System.Drawing.Point(133, 107);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(80, 35);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Push me";
            this.RunButton.UseVisualStyleBackColor = false;
            this.RunButton.Click += new System.EventHandler(this.OnButton_Click);
            this.RunButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Runbutton_MouseMove);
            // 
            // RunningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 248);
            this.Controls.Add(this.RunButton);
            this.Name = "RunningForm";
            this.Text = "Running Button";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
    }
}

