﻿
namespace ConsoleApp2
{
  partial class Form1
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox1.Location = new System.Drawing.Point(36, 376);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(156, 29);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(424, 65);
      this.label1.TabIndex = 1;
      this.label1.Text = "Вариант 4:\r\nВычислить объем и массу трубы длинной l, с внутренним и внешним радиу" +
    "сами r \r\nи R (r < R), изготовленную из материала плостностью p.\r\nV = l*pi(R^2-r^" +
    "2)\r\nm = p*V";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(32, 349);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(71, 24);
      this.label2.TabIndex = 2;
      this.label2.Text = "Объем";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(311, 349);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(66, 24);
      this.label3.TabIndex = 3;
      this.label3.Text = "Масса";
      // 
      // textBox2
      // 
      this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBox2.Location = new System.Drawing.Point(315, 376);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(140, 29);
      this.textBox2.TabIndex = 4;
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(36, 193);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 5;
      this.textBox3.Text = "0";
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(142, 193);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(100, 20);
      this.textBox4.TabIndex = 6;
      this.textBox4.Text = "0";
      this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(248, 193);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(100, 20);
      this.textBox5.TabIndex = 7;
      this.textBox5.Text = "0";
      this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(354, 193);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(100, 20);
      this.textBox6.TabIndex = 8;
      this.textBox6.Text = "0";
      this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label4.Location = new System.Drawing.Point(32, 144);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(68, 20);
      this.label4.TabIndex = 9;
      this.label4.Text = "Данные";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(36, 175);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(61, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Плотность";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(142, 174);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(46, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Длинна";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(351, 175);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(104, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Внутренний радиус";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(246, 175);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(90, 13);
      this.label8.TabIndex = 13;
      this.label8.Text = "Внешний радиус";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(178, 263);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(158, 59);
      this.button1.TabIndex = 14;
      this.button1.Text = "Расчитать";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.IndianRed;
      this.button2.Location = new System.Drawing.Point(480, 12);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(47, 26);
      this.button2.TabIndex = 15;
      this.button2.Text = "Назад";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label9.Location = new System.Drawing.Point(461, 379);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(31, 24);
      this.label9.TabIndex = 16;
      this.label9.Text = "Кг";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label10.Location = new System.Drawing.Point(198, 379);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(55, 24);
      this.label10.TabIndex = 17;
      this.label10.Text = "мм^3";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(539, 450);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox6);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
  }
}