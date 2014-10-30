using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses
{
    public class Diagnostico
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private string informacoes;

        public string Informacoes
        {
            get { return informacoes; }
            set { informacoes = value; }
        }
    }
}
