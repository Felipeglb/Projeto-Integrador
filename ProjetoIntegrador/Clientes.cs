namespace ProjetoIntegrador
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btoCadastro_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string sql = "insert into Parceiro  " +
        "(" +
    "DataCadastro_Parceiro,"+
    "Status_Parceiro,"+
    "nome_Parceiro,"+
    "CNPJ_Parceiro,"+
    "Login_Parceiro,"+
    "Senha_Parceiro,"+
    "Especialidade_Parceiro,"+
    "TipoServico_Parceiro,"+
    "cep_Parceiro,"+
    "logradouro_Parceiro,"+
    "Numero_Parceiro,"+
    "bairro_Parceiro,"+
    "cidade_Parceiro,"+
    "uf_Parceiro,"+
    "Complemento_Parceiro,"+
    "HorarioFuncionamento_Parceiro,"+
    "telefone1_Parceiro,"+
    "telefone2_Parceiro,"+
    "email_Parceiro,"+
    "Obs_Parceiro,"+
    ")" +
        "Values" +
        "(" +
        "'" + mtbDataC.Text + "'," +
        "'" + cboStatus.SelectedItem + "'," +
        "'" + txtNome.Text + "'," +
        "'" + mtbCnpj.Text + "'," +
        "'" + txtLogin.Text + "'" +
        "'" + txtSenha.Text + "'" +
        "'" + cboEspecialidade.Text + "'" +
        "'" + txtTipoServico.Text + "'" +
        "'" + txtCep.Text + "'" +


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
                        MessageBox.Show("Cadastro realizado com sucesso", "Código Gerado:" + leitura[0].ToString());
                        txtCodigo.Text = leitura[0].ToString();
                        mtbDataC.Text = leitura[1].ToString();
                        txtNome.Text = leitura[2].ToString();
                        txtLogin.Text = leitura[2].ToString();
                        cboStatus.SelectedItem = leitura[3].ToString();
                        txtLogin.Text = leitura[4].ToString();
                        txtSenha.Text = leitura[5].ToString();
                        txtObservacao.Text = leitura[6].ToString();





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
    }
}
