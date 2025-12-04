using Oracle.ManagedDataAccess.Client;

namespace CRUD
{
    public partial class Form1 : Form
    {
        // ==== CONFIGURAÇÃO DO ORACLE ====
        // Substitua pelos dados do seu banco Oracle
        string cs = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));User Id=SEU_USUARIO;Password=SUA_SENHA;";

        // Objetos do Oracle (equivalentes aos do SQLite)
        OracleConnection ? con;
        OracleCommand ? cmd;
        OracleDataReader ? dr;

        public Form1()
        {
            InitializeComponent();
            // Não precisamos mais criar arquivo - o Oracle já existe no servidor
        }

        // Mostra os dados na tabela da tela
        private void Data_show()
        {
            dataGridView1.Rows.Clear();

            using (con = new OracleConnection(cs))
            {
                con.Open();
                string sql = "SELECT NAME, ID FROM TEST";  // tabela em maiúsculo é convenção Oracle
                cmd = new OracleCommand(sql, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // No Oracle os nomes das colunas vêm em MAIÚSCULO
                    dataGridView1.Rows.Insert(0,
                        dr["NAME"].ToString() ?? "" ,
                        dr["ID"].ToString() ?? "");
                }
            } // using fecha automaticamente a conexão
        }

        // Cria a tabela no Oracle (só precisa rodar UMA VEZ)
        private void Create_Table_If_Not_Exists()
        {
            using (con = new OracleConnection(cs))
            {
                try
                {
                    con.Open();
                    string sql = @"CREATE TABLE TEST (
                                    NAME VARCHAR2(50),
                                    ID   VARCHAR2(12)
                                   )";
                    cmd = new OracleCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tabela TEST criada com sucesso no Oracle!");
                }
                catch (OracleException ex)
                {
                    // ORA-00955 = tabela já existe → normal
                    if (ex.Number != 955)
                        MessageBox.Show("Erro ao criar tabela: " + ex.Message);
                }
            }
        }

        // INSERIR
        private void Btn_insert_Click(object sender, EventArgs e)
        {
                
            using (con = new OracleConnection(cs))
            {
                con.Open();

                cmd = new OracleCommand("INSERT INTO TEST (NAME, ID) VALUES (:name, :id)", con);

                cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = txt_name.Text;
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = txt_id.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    Data_show();
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir: " + ex.Message);
                }
            }
        }

        

        // ATUALIZAR
        private void Btn_update_Click(object sender, EventArgs e)
        {
            using (con = new OracleConnection(cs))
            {
                con.Open();

                cmd = new OracleCommand("UPDATE TEST SET ID = :id WHERE NAME = :name", con);


                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = txt_id.Text;
                cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = txt_name.Text;

                try
                {
                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0)
                        MessageBox.Show("Atualizado com sucesso!");
                    else
                        MessageBox.Show("Nenhum registro encontrado com esse nome.");
                    Data_show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }
        }

        // DELETAR
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text))
            {
                MessageBox.Show("Digite ou selecione um nome para deletar.");
                return;
            }

            using (con = new OracleConnection(cs))
            {
                con.Open();

                cmd = new OracleCommand("DELETE FROM TEST WHERE NAME = :name", con);

                cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = txt_name.Text;

                try
                {
                    int linhas = cmd.ExecuteNonQuery();
                    if (linhas > 0)
                        MessageBox.Show("Registro deletado!");
                    else
                        MessageBox.Show("Nenhum registro encontrado.");
                    Data_show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Id";

            // Descomente a linha abaixo só na primeira execução
            Create_Table_If_Not_Exists();

            Data_show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString() ?? "";
                txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString() ?? "";
            }
        }
    }
}