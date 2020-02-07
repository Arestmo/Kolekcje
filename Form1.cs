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
        public Form1()
        {
            InitializeComponent();

            //Deklaracja Listy
            List<string> lista = new List<string>();

            //Dodanie wartościddsa
            lista.Add("Ala");
            lista.Add("Ma");
            lista.Add("Kota");

            //Wyświetlenie
            foreach(string item in lista)
            {
                listBox1.Items.Add(item);
                //Console.WriteLine(item);
            }

            //Deklaracja stosu
            Stack stos = new Stack();

            //Dodanie wartości
            stos.Push("Ala");
            stos.Push("Ma");
            stos.Push(12);
            stos.Push("Kotów");

            //Wyświetlenie 
            int ile = stos.Count;
            for (int i = 0; i < ile; i++)
            {
                //Console.WriteLine(stos.Pop());
                listBox1.Items.Add(stos.Pop());
            }

            //Deklaracja Kolejki
            Queue kolejka = new Queue();

            //Dodanie wartości
            kolejka.Enqueue("Ala");
            kolejka.Enqueue(12);
            kolejka.Enqueue("Kota");

            //Wyświetlenie

            foreach(var Item in kolejka)
            {
                listBox1.Items.Add(kolejka.Dequeue());
                //Console.WriteLine(kolejka.Dequeue());
            }





        }
    }
}
