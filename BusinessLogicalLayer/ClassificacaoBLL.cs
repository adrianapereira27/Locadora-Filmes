using DataAccessLayer;
using DataAccessLayer.Impl;
using DataTypeObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class ClassificacaoBLL
    {
        public void Inserir(Classificacao classificacao)
        {
            StringBuilder erros = new StringBuilder();

            if (string.IsNullOrWhiteSpace(classificacao.Descricao))
             {
                //Adicionar erro
                erros.AppendLine("A descrição deve ser informada.");
            }
            else
            {
                classificacao.Descricao = classificacao.Descricao.Trim();
                if (classificacao.Descricao.Length > 40)
                {
                    //Adicionar erro
                    erros.AppendLine("A descrição não pode conter mais de 30 caracteres.");
                }
            }

            if(classificacao.Valor == 0)
            {
                erros.AppendLine("O valor não pode ser ZERO");
            }

            if(classificacao.TempoEntrega == 0)
            {
                erros.AppendLine("O tempo de entrega não pode ser ZERO");
            }

            //Verifica se o StringBuilder possui erros
            if (erros.Length != 0)
            {
                //Lança uma exceção informando
                //os erros concatenados da operação
                throw new Exception(erros.ToString());
            }
            //Se chegou aqui, não tivemos erros \o/
            //Vamos ao DAL cadastro o gênero!
            ClassificacaoDAL dal = new ClassificacaoDAL();
            dal.Inserir(classificacao);
        }
    }
}
