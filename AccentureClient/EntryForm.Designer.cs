namespace ImageColorAnalizer.UI
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.entryButton = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.ComboBox();
            this.loginBox = new System.Windows.Forms.ComboBox();
            this.rememberMeBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(48, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заполните входные данные для авторизации в системе\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(73, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Имя или адрес сервера:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(81, 208);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(230, 27);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // entryButton
            // 
            this.entryButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entryButton.Location = new System.Drawing.Point(52, 390);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(293, 52);
            this.entryButton.TabIndex = 6;
            this.entryButton.Text = "Войти";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.FormattingEnabled = true;
            this.addressBox.Location = new System.Drawing.Point(69, 299);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(254, 29);
            this.addressBox.TabIndex = 7;
            // 
            // loginBox
            // 
            this.loginBox.FormattingEnabled = true;
            this.loginBox.Location = new System.Drawing.Point(81, 135);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(230, 29);
            this.loginBox.TabIndex = 8;
            // 
            // rememberMeBox
            // 
            this.rememberMeBox.AutoSize = true;
            this.rememberMeBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rememberMeBox.Location = new System.Drawing.Point(205, 340);
            this.rememberMeBox.Name = "rememberMeBox";
            this.rememberMeBox.Size = new System.Drawing.Size(117, 25);
            this.rememberMeBox.TabIndex = 9;
            this.rememberMeBox.Text = "Запомнить";
            this.rememberMeBox.UseVisualStyleBackColor = true;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 477);
            this.Controls.Add(this.rememberMeBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.ComboBox addressBox;
        private System.Windows.Forms.ComboBox loginBox;
        private System.Windows.Forms.CheckBox rememberMeBox;
    }
}