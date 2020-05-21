namespace WindowsFormsApp21
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
            this.stroka = new System.Windows.Forms.TextBox();
            this.rec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bkv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.way = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alltxt = new System.Windows.Forms.ListBox();
            this.rez = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // stroka
            // 
            this.stroka.Location = new System.Drawing.Point(41, 85);
            this.stroka.Multiline = true;
            this.stroka.Name = "stroka";
            this.stroka.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.stroka.Size = new System.Drawing.Size(434, 64);
            this.stroka.TabIndex = 0;
            // 
            // rec
            // 
            this.rec.Location = new System.Drawing.Point(481, 85);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(141, 64);
            this.rec.TabIndex = 3;
            this.rec.Text = "Записать в файл и вывести";
            this.rec.UseVisualStyleBackColor = true;
            this.rec.Click += new System.EventHandler(this.rec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Текст из файла:";
            // 
            // bkv
            // 
            this.bkv.Location = new System.Drawing.Point(41, 270);
            this.bkv.Multiline = true;
            this.bkv.Name = "bkv";
            this.bkv.Size = new System.Drawing.Size(434, 24);
            this.bkv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите букву:";
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(481, 270);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(141, 24);
            this.find.TabIndex = 8;
            this.find.Text = "Найти";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(481, 320);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(141, 54);
            this.clr.TabIndex = 9;
            this.clr.Text = "Очистить всё";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Слова, начинающиеся с заданной буквы:";
            // 
            // way
            // 
            this.way.Location = new System.Drawing.Point(41, 38);
            this.way.Multiline = true;
            this.way.Name = "way";
            this.way.Size = new System.Drawing.Size(581, 24);
            this.way.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите путь к файлу:";
            // 
            // alltxt
            // 
            this.alltxt.FormattingEnabled = true;
            this.alltxt.ItemHeight = 16;
            this.alltxt.Location = new System.Drawing.Point(41, 179);
            this.alltxt.Name = "alltxt";
            this.alltxt.ScrollAlwaysVisible = true;
            this.alltxt.Size = new System.Drawing.Size(581, 68);
            this.alltxt.TabIndex = 13;
            // 
            // rez
            // 
            this.rez.FormattingEnabled = true;
            this.rez.ItemHeight = 16;
            this.rez.Location = new System.Drawing.Point(41, 320);
            this.rez.Name = "rez";
            this.rez.ScrollAlwaysVisible = true;
            this.rez.Size = new System.Drawing.Size(434, 52);
            this.rez.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 412);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.alltxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.way);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bkv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.stroka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stroka;
        private System.Windows.Forms.Button rec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bkv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox way;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox alltxt;
        private System.Windows.Forms.ListBox rez;
    }
}

