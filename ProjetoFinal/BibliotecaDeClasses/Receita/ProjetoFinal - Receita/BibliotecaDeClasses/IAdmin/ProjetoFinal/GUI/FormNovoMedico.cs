using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IAdmin.GUI
{
    public partial class FormNovoMedico : Form
    {

        public FormNovoMedico()
        {
            InitializeComponent();
            ListaUF();
        }

        private void ListaUF()
        {
            string[] UF = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };

            foreach (var item in UF)
            {
                cbbUF.Items.Add(item);
            }

        }
    }
}
