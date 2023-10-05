﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
  public partial class Form1 : Form
  {
    double Density;
    double Lengt;
    double InnerRadius;
    double OuterRadius;


    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        Density = Convert.ToDouble(textBox3.Text) / 10000;
        Lengt = Convert.ToDouble(textBox4.Text);
        OuterRadius = Convert.ToDouble(textBox5.Text) / 10;
        InnerRadius = Convert.ToDouble(textBox6.Text) / 10;
      }

      catch
      {
        MessageBox.Show("Данные введены в неверном формате", "Ошибка", MessageBoxButtons.OK);
      }

      double Volume = Lengt * Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
      textBox1.Text = Convert.ToString(Volume);

      double Mass = Density * Volume;
      textBox2.Text = Convert.ToString(Mass);
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form2 MainForm = new Form2();
      MainForm.Show();
    }
  }
}
