using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objetos;

namespace WinFormsApp1.Conexao
{
    public class sqlFornecedor
    {

        public int CadastrarFornecedor(FornecedorCadastro recSem)
        {
            FornecedorCadastro fCadas = new FornecedorCadastro();
            fCadas = recSem;

            BancoSqlServer banco = new BancoSqlServer();

            string queryInsert = $@"INSERT INTO dbo.Fornecedor (nome, cnpj, email, endereco, telefone)
            VALUES('{fCadas.Nome}', {fCadas.cnpj}, '{fCadas.Email}', '{fCadas.Endereco}',  '{fCadas.Telefone}')";

            int linhasAfetadas = banco.ExecutarComando(queryInsert);
            return linhasAfetadas;
        }

        //public int AtualizarFornecedor(FornecedorCadastro recSem)
        //{
        //    FornecedorCadastro sCadas = new FornecedorCadastro();
        //    sCadas = recSem;

        //    BancoSqlServer banco = new BancoSqlServer();

        //    string queryUpdate = $@"UPDATE [dbo].[Fornecedor]
        //    SET 
        //        nome = '{sCadas.Nome}',
        //        valor = {sCadas.Valor},
        //        qualidade = '{sCadas.Qualidade}',
        //        tamanho = {(string.IsNullOrEmpty(sCadas.Tamanho) ? "NULL" : $"'{sCadas.Tamanho}'")},
        //        validade = '{sCadas.Validade:yyyy-MM-dd}',
        //        germinacao = {sCadas.Germinacao},
        //        pureza = {sCadas.Pureza},
        //        quantidade = '{sCadas.Quantidade}'
        //    WHERE id = {sCadas.id}";

        //    int linhasAfetadas = banco.ExecutarComando(queryUpdate);
        //    return linhasAfetadas;
        //}

        public List<FornecedorCadastro> ListarFornecedors()
        {
            List<FornecedorCadastro> listaFornecedor = new List<FornecedorCadastro>();
            BancoSqlServer banco = new BancoSqlServer();

            string querySelect = "SELECT * FROM [dbo].[Fornecedor]";

            try
            {
                using (var leitor = banco.ExecutarConsulta(querySelect))
                {
                    if (leitor != null)
                    {
                        while (leitor.Read())
                        {
                            FornecedorCadastro Fornecedor = new FornecedorCadastro
                            {
                                id = Convert.ToInt32(leitor["id"]),
                                Nome = leitor["nome"].ToString(),
                                cnpj = leitor["cnpj"].ToString(),
                                Email = leitor["email"].ToString(),
                                Endereco = leitor["endereco"].ToString(),
                                Telefone = leitor["telefone"].ToString(),

                            };

                            listaFornecedor.Add(Fornecedor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar Fornecedors: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaFornecedor;
        }


        public bool DeletarFornecedorPorId(int id)
        {
            BancoSqlServer banco = new BancoSqlServer();
            string queryDelete = $"DELETE FROM [dbo].[Fornecedor] WHERE id = {id}";

            try
            {
                int linhasAfetadas = banco.ExecutarComando(queryDelete);

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show($"Fornecedor com ID {id} foi deletada com sucesso!", "Deleção bem-sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"Nenhuma Fornecedor com ID {id} foi encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar a Fornecedor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
