namespace Bandit_Odnorukiy_Zlodey_Pr10S2_
{
  partial class Казино
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ПОГНАЛИ = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dvg1 = new System.Windows.Forms.Timer(this.components);
            this.dvg2 = new System.Windows.Forms.Timer(this.components);
            this.dvg3 = new System.Windows.Forms.Timer(this.components);
            this.stop1 = new System.Windows.Forms.Timer(this.components);
            this.stop2 = new System.Windows.Forms.Timer(this.components);
            this.stop3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(147, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 118);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(320, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 118);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(501, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 118);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // ПОГНАЛИ
            // 
            this.ПОГНАЛИ.Location = new System.Drawing.Point(96, 242);
            this.ПОГНАЛИ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ПОГНАЛИ.Name = "ПОГНАЛИ";
            this.ПОГНАЛИ.Size = new System.Drawing.Size(231, 101);
            this.ПОГНАЛИ.TabIndex = 3;
            this.ПОГНАЛИ.Text = "ПОГНАЛИ";
            this.ПОГНАЛИ.UseVisualStyleBackColor = true;
            this.ПОГНАЛИ.Click += new System.EventHandler(this.ПОГНАЛИ_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 370);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 99);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сделать ставку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(402, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 101);
            this.label4.TabIndex = 5;
            this.label4.Text = "Баланс: $100";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(412, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 99);
            this.label5.TabIndex = 6;
            this.label5.Text = "Выбрать ставку:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(645, 412);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(462, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 62);
            this.label6.TabIndex = 8;
            this.label6.Text = "Осталось попыток: 0";
            // 
            // dvg1
            // 
            this.dvg1.Interval = 25;
            this.dvg1.Tick += new System.EventHandler(this.dvg1_Tick);
            // 
            // dvg2
            // 
            this.dvg2.Interval = 25;
            this.dvg2.Tick += new System.EventHandler(this.dvg2_Tick);
            // 
            // dvg3
            // 
            this.dvg3.Interval = 25;
            this.dvg3.Tick += new System.EventHandler(this.dvg3_Tick);
            // 
            // stop1
            // 
            this.stop1.Interval = 1500;
            this.stop1.Tick += new System.EventHandler(this.stop1_Tick);
            // 
            // stop2
            // 
            this.stop2.Interval = 2500;
            this.stop2.Tick += new System.EventHandler(this.stop2_Tick);
            // 
            // stop3
            // 
            this.stop3.Interval = 3500;
            this.stop3.Tick += new System.EventHandler(this.stop3_Tick);
            // 
            // Казино
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 567);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ПОГНАЛИ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Казино";
            this.Text = "Азино Три Топора";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ПОГНАЛИ;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer dvg1;
        private System.Windows.Forms.Timer dvg2;
        private System.Windows.Forms.Timer dvg3;
        private System.Windows.Forms.Timer stop1;
        private System.Windows.Forms.Timer stop2;
        private System.Windows.Forms.Timer stop3;
    }
}

