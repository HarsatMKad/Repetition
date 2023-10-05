using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsoleApp2
{
  public partial class Form3 : Form
  {
    string FilePath = "dataBase.xml";
    Person[] People;

    public void CreateXmlFile()
    {
      XmlWriterSettings settings = new XmlWriterSettings();
      XmlWriter writer = XmlWriter.Create(FilePath, settings);
      writer.WriteStartElement("ArrayOfPerson");
      writer.WriteEndElement();
      writer.Flush();
      writer.Close();
    }

    private void SerializationFromFile()
    {
      XmlSerializer Formatter = new XmlSerializer(typeof(Person[]));
      using (FileStream FileStreamer = new FileStream(FilePath, FileMode.Open))
      {
        Person[] People = Formatter.Deserialize(FileStreamer) as Person[];
        this.People = People;
      }
    }

    private void FillOutTheList()
    {
      if (People != null)
      {
        List<string> Citys = new List<string>();

        for (int i = 0; i < People.Length; ++i)
        {
          if (Citys.Contains(People[i].City))
          {
            continue;
          }
          Citys.Add(People[i].City);
        }

        foreach (string sity in Citys)
        {
          if (sity != null)
          {
            comboBox1.Items.Add(sity);
          }
        }
      }
    }

    public Form3()
    {
      InitializeComponent();
    }

    private void Form3_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      CreateXmlFile();

      Random Random = new Random();
      string[] LastNames = new string[20];
      string[] Citys = new string[8];
      Person[] NewPeople = new Person[20];

      LastNames[0] = "Иванова";
      LastNames[1] = "Коротков";
      LastNames[2] = "Рябинина";
      LastNames[3] = "Суслова";
      LastNames[4] = "Авдеева";
      LastNames[5] = "Козлов";
      LastNames[6] = "Матвеев";
      LastNames[7] = "Попов";
      LastNames[8] = "Полякова";
      LastNames[9] = "Соколов";
      LastNames[10] = "Волкова";
      LastNames[11] = "Иванова";
      LastNames[12] = "Семенова";
      LastNames[13] = "Смирнова";
      LastNames[14] = "Скворцов";
      LastNames[15] = "Иванов";
      LastNames[16] = "Степанова";
      LastNames[17] = "Давыдов";
      LastNames[18] = "Фадеев";
      LastNames[19] = "Константинов";

      Citys[0] = "Город1";
      Citys[1] = "Город2";
      Citys[2] = "Город3";
      Citys[3] = "Город4";
      Citys[4] = "Город5";
      Citys[5] = "Город6";
      Citys[6] = "Город7";
      Citys[7] = "Город8";

      for(int index = 0; index < NewPeople.Length; ++index)
      {
        int LastNameIndex, CityIndex, Age;
        LastNameIndex = Random.Next(0, 19);
        CityIndex = Random.Next(0, 7);
        Age = Random.Next(1, 100);

        NewPeople[index] = new Person(LastNames[LastNameIndex], Citys[CityIndex], Age);
      }

      XmlSerializer Formatter = new XmlSerializer(typeof(Person[]));
      using (FileStream FileStreamer = new FileStream(FilePath, FileMode.OpenOrCreate))
      {
        Formatter.Serialize(FileStreamer, NewPeople);
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (comboBox1.SelectedItem == null)
      {
        MessageBox.Show( "Выберите город", "Ошибка", MessageBoxButtons.OK);
      }

      else
      {
        listBox1.Items.Clear();
        string SelectedCity = comboBox1.SelectedItem as string;
        int TotalAge = 0;
        int CountOfSelected = 0;
        double AverageAge = 0;
        foreach (Person person in People)
        {
          if(person.City == SelectedCity)
          {
            TotalAge += person.Age;
            CountOfSelected += 1;

            if(CountOfSelected == 0)
            {
              textBox1.Text = "0";
            }
            else
            {
              AverageAge = TotalAge / CountOfSelected;
            }
            string personData = person.LastName + "     " + person.City + "     " + person.Age;
            listBox1.Items.Add(personData);
          }
        }
        textBox1.Text = Convert.ToString(AverageAge);
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Hide();
      Form2 MainForm = new Form2();
      MainForm.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      SerializationFromFile();
      FillOutTheList();
    }
  }
}
