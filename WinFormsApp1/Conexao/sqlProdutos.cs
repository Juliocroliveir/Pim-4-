using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objetos;

namespace WinFormsApp1.Conexao
{
    public class sqlProdutos
    {

        public int CadastrarProduto(ProdutoCadastro recPro)
        {
            ProdutoCadastro pCadas = new ProdutoCadastro();
            pCadas = recPro;

            BancoSqlServer banco = new BancoSqlServer();

            // Exemplo: Inserir um novo usuário
            string queryInsert = $@"INSERT INTO dbo.Produto (Nome, Validade, PrecoKg, Germinacao, Qualidade, Pureza, Tamanho, Quantidade)
            VALUES('{pCadas.Nome}', '{pCadas.Validade}', {pCadas.PrecoKg}, {pCadas.Germinacao}, {pCadas.Qualidade}, {pCadas.Pureza}, {pCadas.Tamanho}, '{pCadas.Quantidade}')";

            int linhasAfetadas = banco.ExecutarComando(queryInsert);
            //MessageBox.Show($"Linhas afetadas: {linhasAfetadas}");

            return linhasAfetadas;
        }
        public int AtualizarProduto(ProdutoCadastro recPro)
        {
            ProdutoCadastro pCadas = new ProdutoCadastro();
            pCadas = recPro;

            BancoSqlServer banco = new BancoSqlServer();

            // Exemplo: Inserir um novo usuário
            string queryUpdate = $@"UPDATE [dbo].[Produto]
            SET 
                [Nome] = '{pCadas.Nome}',
                [Validade] = '{pCadas.Validade}',
                [PrecoKg] = {pCadas.PrecoKg},
                [Germinacao] = {pCadas.Germinacao},
                [Qualidade] = {pCadas.Qualidade},
                [Pureza] = {pCadas.Pureza},
                [Tamanho] = {pCadas.Tamanho},
                [Quantidade] = '{pCadas.Quantidade}'
            WHERE [id] = {pCadas.id}";


            int linhasAfetadas = banco.ExecutarComando(queryUpdate);
            //MessageBox.Show($"Linhas afetadas: {linhasAfetadas}");

            return linhasAfetadas;
        }

        public List<ProdutoCadastro> ListarProdutos()
        {
            List<ProdutoCadastro> listaProduto = new List<ProdutoCadastro>();
            BancoSqlServer banco = new BancoSqlServer();

            string querySelect = "SELECT * FROM [dbo].[Produto]";

            try
            {
                using (var leitor = banco.ExecutarConsulta(querySelect))
                {
                    if (leitor != null)
                    {
                        while (leitor.Read())
                        {
                            ProdutoCadastro produto = new ProdutoCadastro
                            {
                                id = Convert.ToInt32(leitor["id"]),
                                Nome = leitor["Nome"].ToString(),
                                Validade = leitor["Validade"] != DBNull.Value
                                    ? Convert.ToDateTime(leitor["Validade"])
                                    : DateTime.MinValue,
                                PrecoKg = leitor["PrecoKg"].ToString(),
                                Germinacao = leitor["Germinacao"].ToString(),
                                Qualidade = leitor["Qualidade"].ToString(),
                                Pureza = leitor["Pureza"].ToString(),
                                Tamanho = leitor["Tamanho"].ToString(),
                                Quantidade = leitor["Quantidade"].ToString()
                            };

                            listaProduto.Add(produto);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaProduto;
        }
        public ProdutoCadastro? BuscarProdutoPorId(int id)
        {
            ProdutoCadastro? produto = null;
            BancoSqlServer banco = new BancoSqlServer();

            string querySelect = $"SELECT * FROM [dbo].[Produto] WHERE id = {id}";

            try
            {
                using (var leitor = banco.ExecutarConsulta(querySelect))
                {
                    if (leitor != null && leitor.Read())
                    {
                        produto = new ProdutoCadastro
                        {
                            id = Convert.ToInt32(leitor["id"]),
                            Nome = leitor["Nome"].ToString(),
                            Validade = leitor["Validade"] != DBNull.Value
                                ? Convert.ToDateTime(leitor["Validade"])
                                : DateTime.MinValue,
                            PrecoKg = leitor["PrecoKg"].ToString(),
                            Germinacao = leitor["Germinacao"].ToString(),
                            Qualidade = leitor["Qualidade"].ToString(),
                            Pureza = leitor["Pureza"].ToString(),
                            Tamanho = leitor["Tamanho"].ToString(),
                            Quantidade = leitor["Quantidade"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return produto;
        }
        public bool DeletarProdutoPorId(int id)
        {
            BancoSqlServer banco = new BancoSqlServer();
            string queryDelete = "DELETE FROM [dbo].[Produto] WHERE id = @id";

            try
            {

                int linhasAfetadas = banco.ExecutarComando(queryDelete);
               
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show($"Produto com ID {id} foi deletado com sucesso!", "Deleção bem-sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show($"Nenhum produto com ID {id} foi encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar o produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
