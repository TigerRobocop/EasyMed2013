
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaDeClasses
{
    public class DadosVitais
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        string pressao;

        public string Pressao
        {
            get { return pressao; }
            set { pressao = value; }
        }

        string pulso;

        public string Pulso
        {
            get { return pulso; }
            set { pulso = value; }
        }
        string temperatura;

        public string Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        string respiracao;

        public string Respiracao
        {
            get { return respiracao; }
            set { respiracao = value; }
        }
    }
}
