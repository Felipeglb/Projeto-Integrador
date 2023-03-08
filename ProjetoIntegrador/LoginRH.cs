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
    public partial class LoginRH : Form
    {
        public LoginRH()
        {
            InitializeComponent();
        }

        private void LoginRH_Load(object sender, EventArgs e)
        {
            TesteConexao();

        }

        public static string stringConexao = "Data Source=localhost; Initial Catalog = ProjetoIntegradorT_13; User ID =sa ; Password =123456";
        public static string IDUsuario = "";
        public static string NomeUsuario = "";
        public static string LoginUsuario = "";
        private void TesteConexao()
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
        private void btoCadastrar_Click(object sender, EventArgs e)
        {

            Boolean validar = false;
            string sql = "select * from CadastroEmpresa where login_Usuario = '" + txtLogin.Text + "' and senha_Usuario = '" + txtSenha.Text + "'";

            SqlConnection conn = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    validar = true;
                    IDUsuario = leitura[0].ToString();
                    NomeUsuario = leitura[1].ToString();
                    LoginUsuario = leitura[2].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            if (validar)
            {
                MDIrh frm = new MDIrh();
                frm.Show();
                this.Hide();
            }






        }
    }
}
    

