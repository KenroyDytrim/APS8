namespace APS8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAlg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenB = new System.Windows.Forms.Button();
            this.ResB = new System.Windows.Forms.Button();
            this.Col = new System.Windows.Forms.NumericUpDown();
            this.checkedList = new System.Windows.Forms.CheckedListBox();
            this.MinG = new System.Windows.Forms.NumericUpDown();
            this.MaxG = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Col)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Массив";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(52, 118);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(622, 240);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(769, 118);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(536, 240);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(764, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат";
            // 
            // comboAlg
            // 
            this.comboAlg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboAlg.AutoCompleteCustomSource.AddRange(new string[] {
            "Пузырёк",
            "Выборка",
            "Быстрая"});
            this.comboAlg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboAlg.FormattingEnabled = true;
            this.comboAlg.Items.AddRange(new object[] {
            "Пузырёк",
            "Выборка",
            "Гномья"});
            this.comboAlg.Location = new System.Drawing.Point(52, 404);
            this.comboAlg.Name = "comboAlg";
            this.comboAlg.Size = new System.Drawing.Size(175, 33);
            this.comboAlg.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Алгоритм сортировки";
            // 
            // GenB
            // 
            this.GenB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GenB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenB.Location = new System.Drawing.Point(200, 62);
            this.GenB.Name = "GenB";
            this.GenB.Size = new System.Drawing.Size(192, 34);
            this.GenB.TabIndex = 7;
            this.GenB.Text = "Сгенерировать";
            this.GenB.UseVisualStyleBackColor = false;
            this.GenB.Click += new System.EventHandler(this.GenB_Click);
            // 
            // ResB
            // 
            this.ResB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ResB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResB.Location = new System.Drawing.Point(769, 385);
            this.ResB.Name = "ResB";
            this.ResB.Size = new System.Drawing.Size(172, 36);
            this.ResB.TabIndex = 8;
            this.ResB.Text = "Результат";
            this.ResB.UseVisualStyleBackColor = false;
            this.ResB.Click += new System.EventHandler(this.ResB_Click);
            // 
            // Col
            // 
            this.Col.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Col.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Col.Location = new System.Drawing.Point(52, 65);
            this.Col.Name = "Col";
            this.Col.Size = new System.Drawing.Size(120, 30);
            this.Col.TabIndex = 10;
            this.Col.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // checkedList
            // 
            this.checkedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkedList.CheckOnClick = true;
            this.checkedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedList.FormattingEnabled = true;
            this.checkedList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedList.Items.AddRange(new object[] {
            "Возрастание",
            "Убывание"});
            this.checkedList.Location = new System.Drawing.Point(479, 46);
            this.checkedList.Name = "checkedList";
            this.checkedList.Size = new System.Drawing.Size(212, 79);
            this.checkedList.TabIndex = 11;
            this.checkedList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedList_ItemCheck);
            // 
            // MinG
            // 
            this.MinG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinG.Location = new System.Drawing.Point(402, 46);
            this.MinG.Name = "MinG";
            this.MinG.Size = new System.Drawing.Size(71, 30);
            this.MinG.TabIndex = 12;
            // 
            // MaxG
            // 
            this.MaxG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxG.Location = new System.Drawing.Point(402, 82);
            this.MaxG.Name = "MaxG";
            this.MaxG.Size = new System.Drawing.Size(71, 30);
            this.MaxG.TabIndex = 13;
            this.MaxG.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1335, 498);
            this.Controls.Add(this.MaxG);
            this.Controls.Add(this.MinG);
            this.Controls.Add(this.checkedList);
            this.Controls.Add(this.Col);
            this.Controls.Add(this.ResB);
            this.Controls.Add(this.GenB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboAlg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Сортировка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Col)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenB;
        private System.Windows.Forms.Button ResB;
        private System.Windows.Forms.NumericUpDown Col;
        private System.Windows.Forms.CheckedListBox checkedList;
        private System.Windows.Forms.NumericUpDown MinG;
        private System.Windows.Forms.NumericUpDown MaxG;
    }
}

