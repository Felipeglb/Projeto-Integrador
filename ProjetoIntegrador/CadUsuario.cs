using System.Data;
using System.Data.SqlClient;
namespace ProjetoIntegrador
{
    public partial class CadUsuario : Form
    {
        //string stringConexao = frmLogin.stringConexao;

        public static string stringConexao = " data source = Localhost; initial Catalog=ProjetoIntegradorT_13;User ID=sa; password=123456";
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
                MessageBox.Show("Erro: " + ex.ToString());
                Application.Exit();
            }
        }
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void CadUsuario_Load(object sender, EventArgs e)
        {

        }
        private bool Validar()
        {
            if (cboStatus.Text == "")
            {
                MessageBox.Show("Erro, o campo Status deve ser preenchido");
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return false;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Erro, o campo Nome deve ser preenchido");
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }

            if (mtbCPF.Text == "")
            {
                MessageBox.Show("Erro, o CPF deve ser informado");
                mtbCPF.Text = "";
                mtbCPF.Focus();
                return false;
            }

            if (txtLogin.Text == "")
            {
                MessageBox.Show("Erro, um Login deve ser criado");
                txtLogin.Text = "";
                txtLogin.Focus();
                return false;
            }

            if (txtSenha.Text == "")
            {
                MessageBox.Show("Erro, um Login deve ser criado");
                txtSenha.Text = "";
                txtSenha.Focus();
                return false;
            }

            if (mtbCEP.Text == "")
            {
                MessageBox.Show("Erro, informe o CEP ");
                mtbCEP.Text = "";
                mtbCEP.Focus();
                return false;
            }

            if (mtbCEP.Text == "")
            {
                MessageBox.Show("Erro, informe o CEP ");
                mtbCEP.Text = "";
                mtbCEP.Focus();
                return false;
            }
            return true;
        }

        private void btoCadastro_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string sql = "insert into Usuario  " +
        "(" +
    
     "Status_Usuario,"+
     "nome_Usuario,"+
     "CPF_Usuario,"+
     "Login_Usuario,"+
     "Senha_Usuario,"+
     "id_departamento_Usuario,"+
     "cep_Usuario,"+
     "logradouro_Usuario,"+
     "Numero_Usuario,"+
     "bairro_Usuario,"+
     "cidade_Usuario,"+
     "uf_Usuario,"+
"Compemento_Usuario,"+
"telefone1_Usuario,"+
"telefone2_Usuario,"+
"email_Usuario,"+
"Obs_Usuario,"+

    ")" +
        "Values" +
        "(" +
        "'" + cboStatus.SelectedItem + "'," +
        "'" + txtNome.Text + "'," +
        "'" + mtbCPF.Text + "'," +
        "'" + txtLogin.Text + "'" +
        "'" + txtSenha.Text + "'" +
        "'" + cboIDdepart.Text + "'" +
        "'" + mtbCEP.Text + "'" +
        "'" + txtLogradouro.Text + "'" +
        "'" + txtNumero.Text + "'" +
        "'" + txtBairro.Text + "'" +
        "'" + txtCity.Text + "'" +
        "'" + cboUF.Text + "'" +
        "'" + txtComple.Text + "'" +
        "'" + mtbTel1.Text + "'" +
        "'" + mtbTel2.Text + "'" +
        "'" + txtEmail.Text + "'" +
        "'" + txtObs.Text + "'" +

        ") Select SCOPE_Identity()";
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
                        MessageBox.Show("Cadastro realizado com sucesso", "C�digo Gerado:" + leitura[0].ToString());
                        txtCodigo.Text = leitura[0].ToString();
                        mtbDataC.Text = leitura[1].ToString();
                        cboStatus.SelectedItem = leitura[2].ToString();                   
                        txtNome.Text = leitura[3].ToString();
                        mtbCPF.Text = leitura[4].ToString();
                        txtLogin.Text = leitura[5].ToString();
                        txtSenha.Text = leitura[6].ToString();                       
                        cboIDdepart.Text = leitura[7].ToString();
                        mtbCEP.Text = leitura[8].ToString();
                        txtLogradouro.Text = leitura[9].ToString();
                        txtNumero.Text = leitura[10].ToString();
                        txtBairro.Text = leitura[11].ToString();
                        txtCity.Text = leitura[11].ToString();
                        cboUF.Text = leitura[12].ToString();
                        txtComple.Text = leitura[13].ToString();
                        mtbTel1.Text = leitura[14].ToString();
                        mtbTel2.Text = leitura[15].ToString();
                        txtEmail.Text = leitura[16].ToString();
                        txtObs.Text = leitura[17].ToString();

                btoPesquisar.PerformClick();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    CarregarDataGrid();
                    conn.Close();
                }
            }
        }

        private void btoPesquisa_Click(object sender, EventArgs e)
        {
            //if (txtCodigo.Text.Trim() == "")
            {
                //frmProdutoPesquisa dor = new frmProdutoPesquisa();
                //dor.ShowDialog();
                //txtCodigo.Text = dor._codigo;
            }

            string sql = "select * from Produto where id_Produto =" + txtCodigo.Text;

            SqlConnection conexao = new SqlConnection(stringConexao);
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conexao.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txtCodigo.Text = leitura[0].ToString();
                    mtbDataC.Text = leitura[1].ToString();
                    cboStatus.SelectedItem = leitura[2].ToString();
                    txtNome.Text = leitura[3].ToString();
                    mtbCPF.Text = leitura[4].ToString();
                    txtLogin.Text = leitura[5].ToString();
                    txtSenha.Text = leitura[6].ToString();
                    cboIDdepart.Text = leitura[7].ToString();
                    mtbCEP.Text = leitura[8].ToString();
                    txtLogradouro.Text = leitura[9].ToString();
                    txtNumero.Text = leitura[10].ToString();
                    txtBairro.Text = leitura[11].ToString();
                    txtCity.Text = leitura[11].ToString();
                    cboUF.Text = leitura[12].ToString();
                    txtComple.Text = leitura[13].ToString();
                    mtbTel1.Text = leitura[14].ToString();
                    mtbTel2.Text = leitura[15].ToString();
                    txtEmail.Text = leitura[16].ToString();
                    txtObs.Text = leitura[17].ToString();

                    CarregarDataGrid();
                }
                else
                {
                    MessageBox.Show("C�digo de Produto inexistente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conexao.Close();
            }
        }
        }
    }

