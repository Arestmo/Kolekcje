using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcje
{
    public partial class Form1 : Form
    {
        List<Familiada> pytania;
        Random rand = new Random();
        int QuestionID;
        int PointsVal;
        public Form1()
        {
            InitializeComponent();

            pytania = new List<Familiada>();

            pytania.Add(new Familiada("Co pije mleko?" ,new string[] { "Krowa", "Kot", "Dziecko"}));
            pytania.Add(new Familiada("Co daje mleko?" ,new string[] { "Koza", "Krowa", "Owca"}));
            pytania.Add(new Familiada("Więcej niż jedno zwierze to ?", new string[] { "Wieloryb", "Lama", "Stado" }));

            QuestionID = rand.Next(0, pytania.Count);

            Display_question.Text = pytania[QuestionID].GetQuestion();

        
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (pytania[QuestionID].Check(Ans_0.Text)) PointsVal += 10;
            if (pytania[QuestionID].Check(Ans_1.Text)) PointsVal += 10;
            if (pytania[QuestionID].Check(Ans_2.Text)) PointsVal += 10;

            Points.Text = PointsVal.ToString();
            NextButton.Enabled = true;

            pytania.RemoveAt(QuestionID);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(pytania.Count > 0 )
            {
                NextButton.Enabled = false;
                QuestionID = rand.Next(0, pytania.Count);
                Display_question.Text = pytania[QuestionID].GetQuestion();
            }
            else
            {
                NextButton.Enabled = false;
                CheckButton.Enabled = false;
                Display_question.Text = "Koniec pytań";
            }
        }
    }
}
