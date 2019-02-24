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
    public class GeneroBLL
    {
        public void Inserir(Genero genero)
        {
            StringBuilder erros = new StringBuilder();

            if (string.IsNullOrWhiteSpace(genero.Descricao))
             {
                //Adicionar erro
                erros.AppendLine("A descrição deve ser informada.");
            }
            else
            {
                genero.Descricao = genero.Descricao.Trim();
                if (genero.Descricao.Length > 30)
                {
                    //Adicionar erro
                    erros.AppendLine("A descrição não pode conter mais de 30 caracteres.");
                }
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
            GeneroDAL dal = new GeneroDAL();
            dal.Inserir(genero);
        }
    }
}
