using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Familiada
    {
        public string Question;
        public string[] Answers;

        public Familiada(string pytanie, string[] odpowiedzi)
        {
            this.Question = pytanie;
            this.Answers = odpowiedzi;
        }

        public string GetQuestion() 
        {
            return this.Question;
        }

        public bool Check(string TextFromUser)
        {
            return Answers.Contains<string>(TextFromUser); 
        }
    }
}
