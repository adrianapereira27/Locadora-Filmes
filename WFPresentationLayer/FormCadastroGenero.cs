using BusinessLogicalLayer;
using DataTypeObject;
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

namespace WFPresentationLayer
{
    public partial class FormCadastroGenero : Form
    {
        public FormCadastroGenero()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            genero.Descricao = txtDescricao.Text;

            GeneroBLL bll = new GeneroBLL();

            try
            {
                bll.Inserir(genero);
                MessageBox.Show("Cadastrado com sucesso!");
                txtDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
