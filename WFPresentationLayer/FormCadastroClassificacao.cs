using BusinessLogicalLayer;
using DataTypeObject;
using System;
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
    public partial class FormCadastroClassificacao : Form
    {
        public FormCadastroClassificacao()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Classificacao classificacao = new Classificacao();
            classificacao.Descricao = txtDescricao.Text;
            classificacao.Valor = Convert.ToDouble(txtValor.Text);
            classificacao.TempoEntrega = Convert.ToInt32(txtTempoEntrega.Text);
           
            ClassificacaoBLL bll = new ClassificacaoBLL();
            try
            {
                bll.Inserir(classificacao);
                MessageBox.Show("Cadastrado com sucesso!");
                txtDescricao.Clear();
                txtValor.Clear();
                txtTempoEntrega.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
