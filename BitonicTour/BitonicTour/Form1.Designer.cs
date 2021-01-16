namespace BitonicTour
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерВершиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветВершинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отладкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоматическаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.быстроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медленноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ручнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1196, 620);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1262, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Запуск";
            this.toolTip1.SetToolTip(this.button1, "Запустить программу");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.отладкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1488, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерВершиныToolStripMenuItem,
            this.размерЛинииToolStripMenuItem,
            this.цветВершинToolStripMenuItem,
            this.цветЛинииToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(108, 27);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // размерВершиныToolStripMenuItem
            // 
            this.размерВершиныToolStripMenuItem.Name = "размерВершиныToolStripMenuItem";
            this.размерВершиныToolStripMenuItem.Size = new System.Drawing.Size(231, 28);
            this.размерВершиныToolStripMenuItem.Text = "Размер вершины";
            this.размерВершиныToolStripMenuItem.Click += new System.EventHandler(this.размерВершиныToolStripMenuItem_Click);
            // 
            // размерЛинииToolStripMenuItem
            // 
            this.размерЛинииToolStripMenuItem.Name = "размерЛинииToolStripMenuItem";
            this.размерЛинииToolStripMenuItem.Size = new System.Drawing.Size(231, 28);
            this.размерЛинииToolStripMenuItem.Text = "Размер линии";
            this.размерЛинииToolStripMenuItem.Click += new System.EventHandler(this.размерЛинииToolStripMenuItem_Click);
            // 
            // цветВершинToolStripMenuItem
            // 
            this.цветВершинToolStripMenuItem.Name = "цветВершинToolStripMenuItem";
            this.цветВершинToolStripMenuItem.Size = new System.Drawing.Size(231, 28);
            this.цветВершинToolStripMenuItem.Text = "Цвет вершин";
            this.цветВершинToolStripMenuItem.Click += new System.EventHandler(this.цветВершинToolStripMenuItem_Click);
            // 
            // цветЛинииToolStripMenuItem
            // 
            this.цветЛинииToolStripMenuItem.Name = "цветЛинииToolStripMenuItem";
            this.цветЛинииToolStripMenuItem.Size = new System.Drawing.Size(231, 28);
            this.цветЛинииToolStripMenuItem.Text = "Цвет линий";
            this.цветЛинииToolStripMenuItem.Click += new System.EventHandler(this.цветЛинииToolStripMenuItem_Click);
            // 
            // отладкаToolStripMenuItem
            // 
            this.отладкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автоматическаяToolStripMenuItem,
            this.ручнаяToolStripMenuItem});
            this.отладкаToolStripMenuItem.Name = "отладкаToolStripMenuItem";
            this.отладкаToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.отладкаToolStripMenuItem.Size = new System.Drawing.Size(88, 27);
            this.отладкаToolStripMenuItem.Text = "Отладка";
            // 
            // автоматическаяToolStripMenuItem
            // 
            this.автоматическаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.быстроToolStripMenuItem,
            this.среднеToolStripMenuItem,
            this.медленноToolStripMenuItem});
            this.автоматическаяToolStripMenuItem.Name = "автоматическаяToolStripMenuItem";
            this.автоматическаяToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.автоматическаяToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.автоматическаяToolStripMenuItem.Text = "Автоматическая";
            // 
            // быстроToolStripMenuItem
            // 
            this.быстроToolStripMenuItem.Name = "быстроToolStripMenuItem";
            this.быстроToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.быстроToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.быстроToolStripMenuItem.Text = "Быстро";
            this.быстроToolStripMenuItem.Click += new System.EventHandler(this.быстроToolStripMenuItem_Click);
            // 
            // среднеToolStripMenuItem
            // 
            this.среднеToolStripMenuItem.Name = "среднеToolStripMenuItem";
            this.среднеToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.среднеToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.среднеToolStripMenuItem.Text = "Средне";
            this.среднеToolStripMenuItem.Click += new System.EventHandler(this.среднеToolStripMenuItem_Click);
            // 
            // медленноToolStripMenuItem
            // 
            this.медленноToolStripMenuItem.Name = "медленноToolStripMenuItem";
            this.медленноToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.медленноToolStripMenuItem.Size = new System.Drawing.Size(175, 28);
            this.медленноToolStripMenuItem.Text = "Медленно";
            this.медленноToolStripMenuItem.Click += new System.EventHandler(this.медленноToolStripMenuItem_Click);
            // 
            // ручнаяToolStripMenuItem
            // 
            this.ручнаяToolStripMenuItem.Name = "ручнаяToolStripMenuItem";
            this.ручнаяToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.ручнаяToolStripMenuItem.Text = "Ручная";
            this.ручнаяToolStripMenuItem.Click += new System.EventHandler(this.ручнаяToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1262, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 52);
            this.button4.TabIndex = 5;
            this.button4.Text = "Сбросить";
            this.toolTip1.SetToolTip(this.button4, "Сбросить все изменения,\r\nочистить основное поле");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1359, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 70);
            this.button2.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button2, "Следующий шаг отладки");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1248, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 70);
            this.button3.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button3, "Предыдущий шаг отладки");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(1263, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 52);
            this.button5.TabIndex = 8;
            this.button5.Text = "Остановить";
            this.toolTip1.SetToolTip(this.button5, "Выключить ручной режим отладки");
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1229, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Длина оптимального\r\nпути: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(131, 27);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Битонический коммивояжер";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem отладкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоматическаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ручнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерВершиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерЛинииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветВершинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветЛинииToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem быстроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медленноToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

