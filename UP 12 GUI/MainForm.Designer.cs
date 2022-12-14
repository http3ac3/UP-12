namespace UP_12_GUI
{
    partial class MainForm
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
            this.ASideBox = new System.Windows.Forms.TextBox();
            this.BSideBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateSquareButton = new System.Windows.Forms.Button();
            this.ChangesBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IncrementSidesButton = new System.Windows.Forms.Button();
            this.DecrementSidesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KnowByIndexButton = new System.Windows.Forms.Button();
            this.ChangeByIndexButton = new System.Windows.Forms.Button();
            this.SideChangeBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IsSquareButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MultiplyToScalarButton = new System.Windows.Forms.Button();
            this.ScalarBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ToStringButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StringBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StringToRecButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сторону a -> ";
            // 
            // ASideBox
            // 
            this.ASideBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ASideBox.Location = new System.Drawing.Point(162, 10);
            this.ASideBox.Name = "ASideBox";
            this.ASideBox.Size = new System.Drawing.Size(100, 23);
            this.ASideBox.TabIndex = 1;
            // 
            // BSideBox
            // 
            this.BSideBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.BSideBox.Location = new System.Drawing.Point(423, 10);
            this.BSideBox.Name = "BSideBox";
            this.BSideBox.Size = new System.Drawing.Size(100, 23);
            this.BSideBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(268, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите сторону b ->";
            // 
            // CreateSquareButton
            // 
            this.CreateSquareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.CreateSquareButton.Location = new System.Drawing.Point(529, 7);
            this.CreateSquareButton.Name = "CreateSquareButton";
            this.CreateSquareButton.Size = new System.Drawing.Size(204, 28);
            this.CreateSquareButton.TabIndex = 4;
            this.CreateSquareButton.Text = "Создать прямоугольник";
            this.CreateSquareButton.UseVisualStyleBackColor = true;
            this.CreateSquareButton.Click += new System.EventHandler(this.CreateSquareButton_Click);
            // 
            // ChangesBox
            // 
            this.ChangesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ChangesBox.Location = new System.Drawing.Point(334, 59);
            this.ChangesBox.Name = "ChangesBox";
            this.ChangesBox.ReadOnly = true;
            this.ChangesBox.Size = new System.Drawing.Size(399, 421);
            this.ChangesBox.TabIndex = 5;
            this.ChangesBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(330, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Изменения";
            // 
            // IncrementSidesButton
            // 
            this.IncrementSidesButton.Enabled = false;
            this.IncrementSidesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IncrementSidesButton.Location = new System.Drawing.Point(15, 59);
            this.IncrementSidesButton.Name = "IncrementSidesButton";
            this.IncrementSidesButton.Size = new System.Drawing.Size(150, 28);
            this.IncrementSidesButton.TabIndex = 7;
            this.IncrementSidesButton.Text = "Инкремент сторон";
            this.IncrementSidesButton.UseVisualStyleBackColor = true;
            this.IncrementSidesButton.Click += new System.EventHandler(this.IncrementSidesButton_Click);
            // 
            // DecrementSidesButton
            // 
            this.DecrementSidesButton.Enabled = false;
            this.DecrementSidesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.DecrementSidesButton.Location = new System.Drawing.Point(171, 59);
            this.DecrementSidesButton.Name = "DecrementSidesButton";
            this.DecrementSidesButton.Size = new System.Drawing.Size(156, 28);
            this.DecrementSidesButton.TabIndex = 8;
            this.DecrementSidesButton.Text = "Декремент сторон";
            this.DecrementSidesButton.UseVisualStyleBackColor = true;
            this.DecrementSidesButton.Click += new System.EventHandler(this.DecrementSidesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KnowByIndexButton);
            this.groupBox1.Controls.Add(this.ChangeByIndexButton);
            this.groupBox1.Controls.Add(this.SideChangeBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.IndexBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(15, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обращение по индексам";
            // 
            // KnowByIndexButton
            // 
            this.KnowByIndexButton.Enabled = false;
            this.KnowByIndexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.KnowByIndexButton.Location = new System.Drawing.Point(6, 80);
            this.KnowByIndexButton.Name = "KnowByIndexButton";
            this.KnowByIndexButton.Size = new System.Drawing.Size(144, 28);
            this.KnowByIndexButton.TabIndex = 14;
            this.KnowByIndexButton.Text = "Узнать";
            this.KnowByIndexButton.UseVisualStyleBackColor = true;
            this.KnowByIndexButton.Click += new System.EventHandler(this.KnowByIndexButton_Click);
            // 
            // ChangeByIndexButton
            // 
            this.ChangeByIndexButton.Enabled = false;
            this.ChangeByIndexButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ChangeByIndexButton.Location = new System.Drawing.Point(156, 80);
            this.ChangeByIndexButton.Name = "ChangeByIndexButton";
            this.ChangeByIndexButton.Size = new System.Drawing.Size(150, 28);
            this.ChangeByIndexButton.TabIndex = 10;
            this.ChangeByIndexButton.Text = "Изменить";
            this.ChangeByIndexButton.UseVisualStyleBackColor = true;
            this.ChangeByIndexButton.Click += new System.EventHandler(this.ChangeByIndexButton_Click);
            // 
            // SideChangeBox
            // 
            this.SideChangeBox.Enabled = false;
            this.SideChangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.SideChangeBox.Location = new System.Drawing.Point(156, 51);
            this.SideChangeBox.Name = "SideChangeBox";
            this.SideChangeBox.Size = new System.Drawing.Size(150, 23);
            this.SideChangeBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Измените сторону -> ";
            // 
            // IndexBox
            // 
            this.IndexBox.Enabled = false;
            this.IndexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IndexBox.Location = new System.Drawing.Point(156, 22);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(150, 23);
            this.IndexBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Введите индекс -> ";
            // 
            // IsSquareButton
            // 
            this.IsSquareButton.Enabled = false;
            this.IsSquareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.IsSquareButton.Location = new System.Drawing.Point(15, 223);
            this.IsSquareButton.Name = "IsSquareButton";
            this.IsSquareButton.Size = new System.Drawing.Size(312, 26);
            this.IsSquareButton.TabIndex = 15;
            this.IsSquareButton.Text = "Является ли прямоугольник квадртом";
            this.IsSquareButton.UseVisualStyleBackColor = true;
            this.IsSquareButton.Click += new System.EventHandler(this.IsSquareButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MultiplyToScalarButton);
            this.groupBox2.Controls.Add(this.ScalarBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(15, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 89);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Умножение на скаляр";
            // 
            // MultiplyToScalarButton
            // 
            this.MultiplyToScalarButton.Enabled = false;
            this.MultiplyToScalarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.MultiplyToScalarButton.Location = new System.Drawing.Point(43, 51);
            this.MultiplyToScalarButton.Name = "MultiplyToScalarButton";
            this.MultiplyToScalarButton.Size = new System.Drawing.Size(231, 28);
            this.MultiplyToScalarButton.TabIndex = 10;
            this.MultiplyToScalarButton.Text = "Умножить";
            this.MultiplyToScalarButton.UseVisualStyleBackColor = true;
            this.MultiplyToScalarButton.Click += new System.EventHandler(this.MultiplyToScalarButton_Click);
            // 
            // ScalarBox
            // 
            this.ScalarBox.Enabled = false;
            this.ScalarBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ScalarBox.Location = new System.Drawing.Point(156, 22);
            this.ScalarBox.Name = "ScalarBox";
            this.ScalarBox.Size = new System.Drawing.Size(150, 23);
            this.ScalarBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Введите скаляр -> ";
            // 
            // ToStringButton
            // 
            this.ToStringButton.Enabled = false;
            this.ToStringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ToStringButton.Location = new System.Drawing.Point(15, 359);
            this.ToStringButton.Name = "ToStringButton";
            this.ToStringButton.Size = new System.Drawing.Size(312, 26);
            this.ToStringButton.TabIndex = 16;
            this.ToStringButton.Text = "Преобразовать в строку";
            this.ToStringButton.UseVisualStyleBackColor = true;
            this.ToStringButton.Click += new System.EventHandler(this.ToStringButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(142, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "ИЛИ ";
            // 
            // StringBox
            // 
            this.StringBox.Enabled = false;
            this.StringBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.StringBox.Location = new System.Drawing.Point(15, 425);
            this.StringBox.Name = "StringBox";
            this.StringBox.Size = new System.Drawing.Size(312, 23);
            this.StringBox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(12, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Введите строку с двумя сторонами -> ";
            // 
            // StringToRecButton
            // 
            this.StringToRecButton.Enabled = false;
            this.StringToRecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.StringToRecButton.Location = new System.Drawing.Point(16, 454);
            this.StringToRecButton.Name = "StringToRecButton";
            this.StringToRecButton.Size = new System.Drawing.Size(312, 26);
            this.StringToRecButton.TabIndex = 18;
            this.StringToRecButton.Text = "Преобразовать строку в прямоугольник";
            this.StringToRecButton.UseVisualStyleBackColor = true;
            this.StringToRecButton.Click += new System.EventHandler(this.StringToRecButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 486);
            this.Controls.Add(this.StringToRecButton);
            this.Controls.Add(this.StringBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ToStringButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.IsSquareButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DecrementSidesButton);
            this.Controls.Add(this.IncrementSidesButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangesBox);
            this.Controls.Add(this.CreateSquareButton);
            this.Controls.Add(this.BSideBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ASideBox);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ASideBox;
        private System.Windows.Forms.TextBox BSideBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateSquareButton;
        private System.Windows.Forms.RichTextBox ChangesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button IncrementSidesButton;
        private System.Windows.Forms.Button DecrementSidesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button KnowByIndexButton;
        private System.Windows.Forms.Button ChangeByIndexButton;
        private System.Windows.Forms.TextBox SideChangeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IsSquareButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MultiplyToScalarButton;
        private System.Windows.Forms.TextBox ScalarBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ToStringButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StringBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button StringToRecButton;
    }
}

