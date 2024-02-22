using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace CrudEstudo;

public partial class Form1 : Form
{
    // Criação da string de conexão
    private string connectionString = "Data Source=JOAOPONTES;Initial Catalog=Egestora_Crud;User ID=Evandro;Password=mudama23;TrustServerCertificate=True";
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        CarregarGrid();
    }

    private void CarregarGrid()
    {
        using (SqlConnection conexao = new SqlConnection(connectionString))
        {
            try
            {
                //abre conexão
                conexao.Open();

                //executa o comando
                string sql = "SELECT * FROM Clientes";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    //criando para preencher o data table
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {

                        //cria um datatable
                        DataTable dataTable = new DataTable();

                        //preenche o datatable
                        adapter.Fill(dataTable);

                        //carrga no grid
                        dgClientes.DataSource = dataTable;

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Errro ao carregar dados: " + ex.Message);
            }
        }
    }

    private bool ValidarCampos()
    {
        if (string.IsNullOrEmpty(txtNome.Text) ||
        string.IsNullOrEmpty(txtCPF.Text) ||
        string.IsNullOrEmpty(txtIdade.Text) ||
        string.IsNullOrEmpty(txtSexo.Text) ||
        string.IsNullOrEmpty(txtTelefone.Text))
        {
            return false; //campo vazio
        }
        return true; //todos ok
    }

    private void LimpaCampos()
    {
        txtId.Text = "";
        txtCPF.Text = "";
        txtNome.Text = "";
        txtIdade.Text = "";
        txtSexo.Text = "";
        txtTelefone.Text = "";
    }

    private void btnCadastrar_Click(object sender, EventArgs e)
    {
        //verificar se os campos foram preenchidos

        if (ValidarCampos())
        {
            //poderia passar direto mais foi colocado na variavel
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            int idade = Convert.ToInt32(txtIdade.Text);
            string sexo = txtSexo.Text;
            string telefone = txtTelefone.Text;


            //cria uma conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //abre conexão
                    connection.Open();

                    //insere os dados
                    string sql = "INSERT INTO Clientes (Nome, CPF, Idade, Sexo, Telefone) VALUES (@Nome, @CPF, @Idade, @Sexo, @Telefone)";
                    //parametros passados para o banco
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@CPF", cpf);
                        cmd.Parameters.AddWithValue("@Idade", idade);
                        cmd.Parameters.AddWithValue("@Sexo", sexo);
                        cmd.Parameters.AddWithValue("@Telefone", telefone);
                        cmd.ExecuteNonQuery();
                    }

                    CarregarGrid();

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocorreu um erro ao cadastra: " + ex.Message);
                }
            }
        }

        else
        {

            MessageBox.Show("Por favor, preencha os campos");

        }
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {

        if (ValidarCampos())
        {
            //carregando as informações 
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            int idade = Convert.ToInt32(txtIdade.Text);
            string sexo = txtSexo.Text;
            string telefone = txtTelefone.Text;

            //criar conexão com o banco
            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                //abre conexão
                conexao.Open();

                //comando
                string sql = "UPDATE Clientes SET Nome = @Nome, CPF = @CPF, Idade = @Idade, Sexo = @Sexo, Telefone = @Telefone WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@CPF", cpf);
                    cmd.Parameters.AddWithValue("@Idade", idade);
                    cmd.Parameters.AddWithValue("@Sexo", sexo);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.ExecuteNonQuery();
                }

                CarregarGrid();
            }

            MessageBox.Show("Alterado com sucesso");


        }
        else
        {
            MessageBox.Show("Por favor, preencha os campos");
        }

    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {

    }

    private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            //obtem o indice da linha
            int linha = e.RowIndex;

            txtId.Text = dgClientes.Rows[linha].Cells["Id"].Value.ToString();
            txtNome.Text = dgClientes.Rows[linha].Cells["Nome"].Value.ToString();
            txtCPF.Text = dgClientes.Rows[linha].Cells["CPF"].Value.ToString();
            txtIdade.Text = dgClientes.Rows[linha].Cells["Idade"].Value.ToString();
            txtSexo.Text = dgClientes.Rows[linha].Cells["Sexo"].Value.ToString();
            txtTelefone.Text = dgClientes.Rows[linha].Cells["Telefone"].Value.ToString();
        }
    }

    private void btnLimpar_Click(object sender, EventArgs e)
    {
        LimpaCampos();
    }

    private void btnIr_Click(object sender, EventArgs e)
    {
        //primeiro cria a instancia
        FormFornecedor fmrFor = new FormFornecedor();

        //abre o form
        fmrFor.Show();    
    }
}

