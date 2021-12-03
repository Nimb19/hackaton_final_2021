namespace ImageColorAnalizer.UI
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControlCamera = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлятьКамеройToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьОбрабатываемуюОбластьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.обработатьСейчасToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.разорватьПодключениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageLastPhoto = new System.Windows.Forms.TabPage();
            this.pictureBoxLastPhoto = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.отправитьОтчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДиректориюИзображенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработатьВыбранноеИзображениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownErrorRate = new System.Windows.Forms.NumericUpDown();
            this.labelMaterialType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxPrephoto = new System.Windows.Forms.PictureBox();
            this.labelLastTimeUpdInfo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelPercentQualityMaterial = new System.Windows.Forms.Label();
            this.labelResultInfo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.tabControlCamera.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPageLastPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastPhoto)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownErrorRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrephoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControlCamera);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(358, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 832);
            this.panel1.TabIndex = 1;
            // 
            // tabControlCamera
            // 
            this.tabControlCamera.Controls.Add(this.tabPage1);
            this.tabControlCamera.Controls.Add(this.tabPageLastPhoto);
            this.tabControlCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCamera.Location = new System.Drawing.Point(0, 0);
            this.tabControlCamera.Name = "tabControlCamera";
            this.tabControlCamera.SelectedIndex = 0;
            this.tabControlCamera.Size = new System.Drawing.Size(910, 832);
            this.tabControlCamera.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxCamera);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 798);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Камера";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCamera.Location = new System.Drawing.Point(3, 27);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(896, 768);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCamera.TabIndex = 13;
            this.pictureBoxCamera.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлятьКамеройToolStripMenuItem1,
            this.выделитьОбрабатываемуюОбластьToolStripMenuItem1,
            this.обработатьСейчасToolStripMenuItem1,
            this.разорватьПодключениеToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлятьКамеройToolStripMenuItem1
            // 
            this.управлятьКамеройToolStripMenuItem1.Name = "управлятьКамеройToolStripMenuItem1";
            this.управлятьКамеройToolStripMenuItem1.Size = new System.Drawing.Size(127, 20);
            this.управлятьКамеройToolStripMenuItem1.Text = "Управлять камерой";
            // 
            // выделитьОбрабатываемуюОбластьToolStripMenuItem1
            // 
            this.выделитьОбрабатываемуюОбластьToolStripMenuItem1.Name = "выделитьОбрабатываемуюОбластьToolStripMenuItem1";
            this.выделитьОбрабатываемуюОбластьToolStripMenuItem1.Size = new System.Drawing.Size(168, 20);
            this.выделитьОбрабатываемуюОбластьToolStripMenuItem1.Text = "Остановить автообработку";
            // 
            // обработатьСейчасToolStripMenuItem1
            // 
            this.обработатьСейчасToolStripMenuItem1.Name = "обработатьСейчасToolStripMenuItem1";
            this.обработатьСейчасToolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.обработатьСейчасToolStripMenuItem1.Text = "Обработать сейчас";
            // 
            // разорватьПодключениеToolStripMenuItem1
            // 
            this.разорватьПодключениеToolStripMenuItem1.Name = "разорватьПодключениеToolStripMenuItem1";
            this.разорватьПодключениеToolStripMenuItem1.Size = new System.Drawing.Size(153, 20);
            this.разорватьПодключениеToolStripMenuItem1.Text = "Разорвать подключение";
            // 
            // tabPageLastPhoto
            // 
            this.tabPageLastPhoto.Controls.Add(this.pictureBoxLastPhoto);
            this.tabPageLastPhoto.Controls.Add(this.menuStrip2);
            this.tabPageLastPhoto.Location = new System.Drawing.Point(4, 30);
            this.tabPageLastPhoto.Name = "tabPageLastPhoto";
            this.tabPageLastPhoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLastPhoto.Size = new System.Drawing.Size(902, 798);
            this.tabPageLastPhoto.TabIndex = 1;
            this.tabPageLastPhoto.Text = "Последнее обработанное фото";
            this.tabPageLastPhoto.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLastPhoto
            // 
            this.pictureBoxLastPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLastPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLastPhoto.Location = new System.Drawing.Point(3, 27);
            this.pictureBoxLastPhoto.Name = "pictureBoxLastPhoto";
            this.pictureBoxLastPhoto.Size = new System.Drawing.Size(896, 768);
            this.pictureBoxLastPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLastPhoto.TabIndex = 12;
            this.pictureBoxLastPhoto.TabStop = false;
            this.pictureBoxLastPhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxLastPhoto_Paint);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отправитьОтчётToolStripMenuItem,
            this.открытьДиректориюИзображенийToolStripMenuItem,
            this.обработатьВыбранноеИзображениеToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(896, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // отправитьОтчётToolStripMenuItem
            // 
            this.отправитьОтчётToolStripMenuItem.Name = "отправитьОтчётToolStripMenuItem";
            this.отправитьОтчётToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.отправитьОтчётToolStripMenuItem.Text = "Сформировать отчёт";
            // 
            // открытьДиректориюИзображенийToolStripMenuItem
            // 
            this.открытьДиректориюИзображенийToolStripMenuItem.Name = "открытьДиректориюИзображенийToolStripMenuItem";
            this.открытьДиректориюИзображенийToolStripMenuItem.Size = new System.Drawing.Size(232, 20);
            this.открытьДиректориюИзображенийToolStripMenuItem.Text = "Открыть директорию с изображением";
            // 
            // обработатьВыбранноеИзображениеToolStripMenuItem
            // 
            this.обработатьВыбранноеИзображениеToolStripMenuItem.Name = "обработатьВыбранноеИзображениеToolStripMenuItem";
            this.обработатьВыбранноеИзображениеToolStripMenuItem.Size = new System.Drawing.Size(219, 20);
            this.обработатьВыбранноеИзображениеToolStripMenuItem.Text = "Выбрать и обработать изображение";
            this.обработатьВыбранноеИзображениеToolStripMenuItem.Click += new System.EventHandler(this.ОбработатьВыбранноеИзображениеToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownErrorRate);
            this.groupBox1.Controls.Add(this.labelMaterialType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.pictureBoxPrephoto);
            this.groupBox1.Controls.Add(this.labelLastTimeUpdInfo);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.labelPercentQualityMaterial);
            this.groupBox1.Controls.Add(this.labelResultInfo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 832);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Макс. погрешность (%):";
            // 
            // numericUpDownErrorRate
            // 
            this.numericUpDownErrorRate.Location = new System.Drawing.Point(269, 274);
            this.numericUpDownErrorRate.Name = "numericUpDownErrorRate";
            this.numericUpDownErrorRate.Size = new System.Drawing.Size(76, 27);
            this.numericUpDownErrorRate.TabIndex = 16;
            this.numericUpDownErrorRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelMaterialType
            // 
            this.labelMaterialType.Location = new System.Drawing.Point(227, 757);
            this.labelMaterialType.Name = "labelMaterialType";
            this.labelMaterialType.Size = new System.Drawing.Size(100, 21);
            this.labelMaterialType.TabIndex = 15;
            this.labelMaterialType.Text = "Нет данных";
            this.labelMaterialType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 757);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Вид сырья:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Автообработка каждые (сек.):";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(269, 238);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(76, 27);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pictureBoxPrephoto
            // 
            this.pictureBoxPrephoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPrephoto.Location = new System.Drawing.Point(16, 387);
            this.pictureBoxPrephoto.Name = "pictureBoxPrephoto";
            this.pictureBoxPrephoto.Size = new System.Drawing.Size(329, 288);
            this.pictureBoxPrephoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPrephoto.TabIndex = 11;
            this.pictureBoxPrephoto.TabStop = false;
            // 
            // labelLastTimeUpdInfo
            // 
            this.labelLastTimeUpdInfo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.labelLastTimeUpdInfo.Location = new System.Drawing.Point(217, 789);
            this.labelLastTimeUpdInfo.Name = "labelLastTimeUpdInfo";
            this.labelLastTimeUpdInfo.Size = new System.Drawing.Size(93, 20);
            this.labelLastTimeUpdInfo.TabIndex = 10;
            this.labelLastTimeUpdInfo.Text = "Нет данных";
            this.labelLastTimeUpdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label16.Location = new System.Drawing.Point(26, 789);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Последнее обновление:";
            // 
            // labelPercentQualityMaterial
            // 
            this.labelPercentQualityMaterial.Location = new System.Drawing.Point(227, 722);
            this.labelPercentQualityMaterial.Name = "labelPercentQualityMaterial";
            this.labelPercentQualityMaterial.Size = new System.Drawing.Size(100, 21);
            this.labelPercentQualityMaterial.TabIndex = 8;
            this.labelPercentQualityMaterial.Text = "Нет данных";
            this.labelPercentQualityMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelResultInfo
            // 
            this.labelResultInfo.Location = new System.Drawing.Point(122, 688);
            this.labelResultInfo.Name = "labelResultInfo";
            this.labelResultInfo.Size = new System.Drawing.Size(205, 21);
            this.labelResultInfo.TabIndex = 7;
            this.labelResultInfo.Text = "Нет данных";
            this.labelResultInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 722);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Процент качества сырья:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 688);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Информация по последнему обработанному фото:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Содержимое разгрузочного вагона",
            "2. Номер разгрузочного вагона",
            "3. Содержимое бункера",
            "4. Содержимое загрузочного вагона",
            "5. Номер загрузочного вагона"});
            this.comboBox1.Location = new System.Drawing.Point(16, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 29);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор камеры";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.groupBox2.Location = new System.Drawing.Point(3, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор зоны погрузки";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 90);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(169, 25);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Зона приёма №5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(182, 59);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(169, 25);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Зона приёма №4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(169, 25);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Зона приёма №3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(182, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(169, 25);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Зона приёма №2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(169, 25);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Зона приёма №1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 832);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обработка камеры";
            this.panel1.ResumeLayout(false);
            this.tabControlCamera.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageLastPhoto.ResumeLayout(false);
            this.tabPageLastPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLastPhoto)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownErrorRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrephoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControlCamera;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageLastPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обработатьСейчасToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выделитьОбрабатываемуюОбластьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem управлятьКамеройToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem разорватьПодключениеToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPercentQualityMaterial;
        private System.Windows.Forms.Label labelResultInfo;
        private System.Windows.Forms.Label labelLastTimeUpdInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBoxPrephoto;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem отправитьОтчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьДиректориюИзображенийToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBoxLastPhoto;
        private System.Windows.Forms.ToolStripMenuItem обработатьВыбранноеИзображениеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.Label labelMaterialType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownErrorRate;
    }
}

