using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Objetos;

namespace WinFormsApp1.Conexao
{
    public class sqlSemente
    {

        public int CadastrarSemente(SementeCadastro recSem)
        {
            SementeCadastro sCadas = new SementeCadastro();
            sCadas = recSem;

            BancoSqlServer banco = new BancoSqlServer();

            string queryInsert = $@"INSERT INTO dbo.semente (nome, valor, qualidade, tamanho, validade, germinacao, pureza, quantidade)
            VALUES('{sCadas.Nome}', {sCadas.Valor}, '{sCadas.Qualidade}', {(string.IsNullOrEmpty(sCadas.Tamanho) ? "NULL" : $"'{sCadas.Tamanho}'")}, '{sCadas.Validade:yyyy-MM-dd}', {sCadas.Germinacao}, {sCadas.Pureza}, '{sCadas.Quantidade}')";

            int linhasAfetadas = banco.ExecutarComando(queryInsert);
            return linhasAfetadas;
        }

        public int AtualizarSemente(SementeCadastro recSem)
        {
            SementeCadastro sCadas = new SementeCadastro();
            sCadas = recSem;

            BancoSqlServer banco = new BancoSqlServer();

            string queryUpdate = $@"UPDATE [dbo].[semente]
            SET 
                nome = '{sCadas.Nome}',
                valor = {sCadas.Valor},
                qualidade = '{sCadas.Qualidade}',
                tamanho = {(string.IsNullOrEmpty(sCadas.Tamanho) ? "NULL" : $"'{sCadas.Tamanho}'")},
                validade = '{sCadas.Validade:yyyy-MM-dd}',
                germinacao = {sCadas.Germinacao},
                pureza = {sCadas.Pureza},
                quantidade = '{sCadas.Quantidade}'
            WHERE id = {sCadas.id}";

            int linhasAfetadas = banco.ExecutarComando(queryUpdate);
            return linhasAfetadas;
        }

        public List<SementeCadastro> ListarSementes()
        {
            List<SementeCadastro> listaSemente = new List<SementeCadastro>();
            BancoSqlServer banco = new BancoSqlServer();

            string querySelect = "SELECT * FROM [dbo].[semente]";

            try
            {
                using (var leitor = banco.ExecutarConsulta(querySelect))
                {
                    if (leitor != null)
                    {
                        while (leitor.Read())
                        {
                            SementeCadastro semente = new SementeCadastro
                            {
                                id = Convert.ToInt32(leitor["id"]),
                                Nome = leitor["nome"].ToString(),
                                Valor = leitor["valor"].ToString(),
                                Qualidade = leitor["qualidade"].ToString(),
                                Tamanho = leitor["tamanho"] != DBNull.Value ? leitor["tamanho"].ToString() : null,
                                Validade = Convert.ToDateTime(leitor["validade"]),
                                Germinacao = leitor["germinacao"].ToString(),
                                Pureza = leitor["pureza"].ToString(),
                                Quantidade = leitor["quantidade"].ToString()
                            };

                            listaSemente.Add(semente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar sementes: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaSemente;
        }

        public SementeCadastro? BuscarSementePorId(int id)
        {
            SementeCadastro? semente = null;
            BancoSqlServer banco = new BancoSqlServer();

            string querySelect = $"SELECT * FROM [dbo].[semente] WHERE id = {id}";

            try
            {
                using (var leitor = banco.ExecutarConsulta(querySelect))
                {
                    if (leitor != null && leitor.Read())
                    {
                        semente = new SementeCadastro
                        {
                            id = Convert.ToInt32(leitor["id"]),
                            Nome = leitor["nome"].ToString(),
                            Valor = leitor["valor"].ToString(),
                            Qualidade = leitor["qualidade"].ToString(),
                            Tamanho = leitor["tamanho"] != DBNull.Value ? leitor["tamanho"].ToString() : null,
                            Validade = Convert.ToDateTime(leitor["validade"]),
                            Germinacao = leitor["germinacao"].ToString(),
                            Pureza = leitor["pureza"].ToString(),
                            Quantidade = leitor["quantidade"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar semente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return semente;
        }

        public bool DeletarSementePorId(int id)
        {
            BancoSqlServer banco = new BancoSqlServer();
            string queryDelete = $"DELETE FROM [dbo].[semente] WHERE id = {id}";

            try
            {
                int linhasAfetadas = banco.ExecutarComando(queryDelete);

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show($"Semente com ID {id} foi deletada com sucesso!", "Deleção bem-sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"Nenhuma semente com ID {id} foi encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao deletar a semente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
