using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DjikstraAlgorithm;
using System.Windows.Forms;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace ProjetoIntegradorDijkstra
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            PopulaCidade();
            btnCalcular.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cidade cidade = new Cidade();

            if (String.IsNullOrEmpty(txtCidade.Text))
            {
                lblAlert1.Text = "Cidade não pode ser vazio";
                lblAlert1.Visible = true;
            }
            lblAlert1.Visible = false;
            cidade.Nome = txtCidade.Text;
            AddCidade(cidade);
            LimpaCampos();
        }

        private void AddCidade(Cidade cidade)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3");
            List<Cidade> listaCidade = new List<Cidade>();
            string query = "INSERT INTO TBL_CIDADES (CIDADE) VALUES (@CIDADE)";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@CIDADE", cidade.Nome);
                cmd.ExecuteNonQuery();
                cbxCidadeOrigem.Items.Add(cidade.Nome);
                ddlDestino.Items.Add(cidade.Nome);
                conn.Close();
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        private string GetCidade(List<Cidade> listaCidade)
        {
            foreach (var c in listaCidade)
            {
                return c.Nome;
            }
            return null;
        }

        private void PopulaCidade()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3");
            List<Cidade> listaCidade = new List<Cidade>();
            string query = "SELECT * FROM TBL_CIDADES";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cbxCidadeOrigem.Items.Add(row["Cidade"]);
                        ddlDestino.Items.Add(row["Cidade"]);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }
        private void LimpaCampos()
        {
            txtCidade.Text = "";
            if (cbxCidadeOrigem.Items.Count > 1)
            {
                btnCalcular.Enabled = true;
            }
        }

        private void cbxCidadeOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimparCidades_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3");
            List<Cidade> listaCidade = new List<Cidade>();
            string query = "DELETE FROM TBL_CIDADES";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                cbxCidadeOrigem.Items.Clear();
                ddlDestino.Items.Clear();
                PopulaCidade();
            }
            catch
            {
                conn.Close();
                throw;
            }
        }

        private void btnLimparCaminhos_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3");
            List<Cidade> listaCidade = new List<Cidade>();
            string query = "DELETE FROM TBL_CAMINHOS";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                txtLog.Text = "";
            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        private void btnAddDistancia_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3");
            List<Cidade> listaCidade = new List<Cidade>();
            string query = "INSERT INTO TBL_CAMINHOS (ORIGEM,DESTINO,DISTANCIA) VALUES (@ORIGEM,@DESTINO,@DISTANCIA)";
            string query2 = "INSERT INTO TBL_CAMINHOS (ORIGEM,DESTINO,DISTANCIA) VALUES (@ORIGEM,@DESTINO,@DISTANCIA)";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
            try
            {
                conn.Open();
                if (cbxCidadeOrigem.SelectedItem == ddlDestino.SelectedItem)
                {
                    cmd.Parameters.AddWithValue("@ORIGEM", cbxCidadeOrigem.SelectedItem);
                    cmd.Parameters.AddWithValue("@DESTINO", ddlDestino.SelectedItem);
                    cmd.Parameters.AddWithValue("@DISTANCIA", vlrDistancia.Value);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ORIGEM", cbxCidadeOrigem.SelectedItem);
                    cmd2.Parameters.AddWithValue("@DESTINO", cbxCidadeOrigem.SelectedItem);

                    cmd.Parameters.AddWithValue("@DESTINO", ddlDestino.SelectedItem);
                    cmd2.Parameters.AddWithValue("@ORIGEM", ddlDestino.SelectedItem);

                    cmd.Parameters.AddWithValue("@DISTANCIA", vlrDistancia.Value);
                    cmd2.Parameters.AddWithValue("@DISTANCIA", vlrDistancia.Value);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                }

                conn.Close();
                AddLog();
            }
            catch
            {
                conn.Close();
                throw;
            }
        }
        private void AddLog()
        {
            string newLine = Environment.NewLine;
            if (txtLog.Text == "")
            {
                txtLog.Text = cbxCidadeOrigem.SelectedItem.ToString() + " -> " + ddlDestino.SelectedItem.ToString() + " : " + vlrDistancia.Value.ToString();
                txtLog.AppendText(newLine + ddlDestino.SelectedItem.ToString() + " -> " + cbxCidadeOrigem.SelectedItem.ToString() + " : " + vlrDistancia.Value.ToString());
            }
            else
            {
                txtLog.AppendText(newLine + cbxCidadeOrigem.SelectedItem.ToString() + " -> " + ddlDestino.SelectedItem.ToString() + " : " + vlrDistancia.Value.ToString());
                txtLog.AppendText(newLine + ddlDestino.SelectedItem.ToString() + " -> " + cbxCidadeOrigem.SelectedItem.ToString() + " : " + vlrDistancia.Value.ToString());
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tamanho = cbxCidadeOrigem.Items.Count;
            int[] caminhos = GetCaminhos();
            int[,] graph = ConverterArray(caminhos, tamanho, tamanho);
            var retorno = Dijkstra.DijkstraAlgo(graph, cbxCidadeOrigem.SelectedIndex, tamanho);
            progressBar1.Increment(100);
            Print(retorno.distancia, retorno.qtdVertices);
            progressBar1.Refresh();
        }
        private static T[,] ConverterArray<T>(T[] input, int linhas, int colunas)
        {
            T[,] output = new T[linhas, colunas];
            if (linhas * colunas <= input.Length)
            {
                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        output[i, j] = input[i * colunas + j];
                    }
                }
            }
            return output;
        }

        public int[] GetCaminhos()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=database.db;Version=3");
            string query = "SELECT DISTANCIA FROM TBL_CAMINHOS WHERE ORIGEM = @ORIGEM";
            DataTable dt = new DataTable();
            int i = 0;
            int[] retorno = new int[200];
            try
            {
                conn.Open();
                foreach (var x in cbxCidadeOrigem.Items)
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("ORIGEM", x.ToString());
                    da.Fill(dt);
                }

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        retorno[i] = Convert.ToInt32(row["DISTANCIA"]);
                        i++;
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }

            return retorno;
        }
        public void Print(int[] distancia, int qtdVertices)
        {
            string newLine = Environment.NewLine;
            txtLog.Text = "";
            txtLog.Text = "Origem    Menor caminho";

            for (int i = 0; i < qtdVertices; ++i)
            {
                txtLog.AppendText(newLine +"  "+ i +" "+ distancia[i]);
            }
        }

    }
}