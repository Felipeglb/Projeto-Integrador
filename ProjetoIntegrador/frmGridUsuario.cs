using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class frmGridUsuario : Form
    {
        string stringConexao = frmLogin.stringConexao;
        public int _codigo;

        public frmGridUsuario()
        {
            InitializeComponent();
        }

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(stringConexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

         private void frmGridUsuario_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarDataGrid();
        }
        private void CarregarDataGrid()
        {
            string sql = "select id_Produto as 'Codigo'," +
"Status_Usuario," +
"nome_Usuario," +
"CPF_Usuario," +
"Login_Usuario," +
"Senha_Usuario," +
"id_departamento_Usuario," +
"cep_Usuario," +
"logradouro_Usuario," +
"Numero_Usuario," +
"bairro_Usuario," +
"cidade_Usuario," +
"uf_Usuario," +
"Complemento_Usuario," +
"telefone1_Usuario," +
"telefone2_Usuario," +
"email_Usuario," +
"Obs_Usuario" +
    "from Produto where nome_Usuario like '%" + txtPesquisaUser.Text + "%'";


            SqlConnection conn = new SqlConnection(stringConexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();

            conn.Open();

            try
            {
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView1.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCells);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            _codigo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.Close();
        }
    }
}
