using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// new SQLFunctions().CreateDataInDatabase()


namespace UICleanProductsCompany
{
    internal class SQLFunctions
    {
        public DataTable GetDataFromDatabase(string sql)
        {
            //select * from users

            CreateTables();

            //caminho de configuração do servidor
            string data_source = "datasource=localhost;username=root;password='';database=sistema;";

            //abrindo a conexão
            MySqlConnection conexao = new MySqlConnection(data_source);

            //montar o script sql para executar
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            //abrir o banco de dados
            conexao.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            conexao.Close();
            return dt;
        }
        public void GenericChangeDataInDatabase(string sql)
        {
            //$"insert into planos(nome,preco,periodo,desconto,caixoesPremium,agendamentosAcompanhados,arranjosFloraisEspeciais) values('{NameTextBox.Text}', {PriceTextBox.Text}, {PeriodTextBox.Text}, {desconto}, {caixoesPremium}, {agendamentosAcompanhados}, {arranjosFloraisEspeciais})"
            string data_source = "datasource=localhost;username=root;password='';database=sistema;";

            MySqlConnection conexao = new MySqlConnection(data_source);

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            conexao.Open();

            comando.ExecuteNonQuery();

            SharedValues.Instance.InvokeOnValueUpdate();
        }
        public void CreateTables()
        {

            string data_source = "datasource=localhost;username=root;password='';database=sistema;";

            // Users

            // > Username
            // > Email
            // > Password
            // > Type:
            /* There are 3 types of users: (denoted by type 1, 2 and 3 in order)
             - Consumer, has access to buying and most of the apps information
             - Manager, can see all on-going shopping and all users
             - Administrator, all of the above and can also delete users and create/delete products */
            // > Is Currently Logged In

            MySqlConnection conexao = new MySqlConnection(data_source);

            string sql = "create table if NOT EXISTS users(id int primary key auto_increment, username varchar(50), email varchar(255), password varchar(255), type int, isCurrentlyLoggedIn bool);";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            conexao.Open();

            comando.ExecuteNonQuery();


            // Products

            // > Name
            // > Type
            // > Price

            MySqlConnection conexaoB = new MySqlConnection(data_source);

            sql = "create table if NOT EXISTS products(id int primary key auto_increment, name varchar(50), type varchar(50), price int);";

            MySqlCommand comandoB = new MySqlCommand(sql, conexaoB);

            conexaoB.Open();

            comandoB.ExecuteNonQuery();


            // Shopping

            // > Name
            // > Type
            // > Tag
            // > Price

            MySqlConnection conexaoC = new MySqlConnection(data_source);

            sql = "create table if NOT EXISTS currentShopping(id int primary key auto_increment, idBuyer int, idProducts varchar(1000), status varchar(5));";

            MySqlCommand comandoC = new MySqlCommand(sql, conexaoB);

            conexaoC.Open();

            comandoC.ExecuteNonQuery();




            // Configurações

            // > Theme
            // > Volume
            // > Currency


            MySqlConnection conexaoD = new MySqlConnection(data_source);

            sql = "create table if NOT EXISTS configuration(id int primary key auto_increment, userId int, theme varchar(5), volume int, currency varchar(2) );";

            MySqlCommand comandoD = new MySqlCommand(sql, conexaoB);

            conexaoD.Open();

            comandoD.ExecuteNonQuery();
        }
    }
}
