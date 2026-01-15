
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using OsoznanieLibraryBeta;

namespace OzoznaieLauncher_1._1
{
    public partial class Activate_key_form : Form
    {
        string CurrentLogin;
        public Activate_key_form(string CurrentLogin)
        {
            InitializeComponent();
            this.CurrentLogin = CurrentLogin;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            string All_field = Field1.Text + Field2.Text + Field3.Text + Field4.Text;
            if ((Field1.Text != "") & (Field2.Text != "") & (Field3.Text != "") & (Field4.Text != "")){
                All_field = Field1.Text + Field2.Text + Field3.Text + Field4.Text;   //Складываем все поля в одну строку
                }
            else
                {
                 MessageBox.Show("Неверный ключ!");  //Если одно из полей пустое, выводит ошибку
                 return;
                }
         
            ConnectDB KeyLicense = new ConnectDB();
            MySqlDataAdapter AdapterKey = new MySqlDataAdapter();
            DataTable KeyFinded = new DataTable();
            MySqlCommand SearchKey = new MySqlCommand("SELECT * FROM test.`cd-key_keeper` WHERE CdKey = @Key AND Status = 'Deactivate';", KeyLicense.GetServerConnection());
            MySqlCommand UpdateKey = new MySqlCommand("UPDATE `test`.`cd-key_keeper` SET Login = @LogKeeper,Status = 'Activate' WHERE CdKey = @Key;",KeyLicense.GetServerConnection());
            UpdateKey.Parameters.Add("@LogKeeper", MySqlDbType.VarChar).Value = this.CurrentLogin;
            UpdateKey.Parameters.Add("@Key", MySqlDbType.VarChar).Value = All_field;

            SearchKey.Parameters.Add("@Key", MySqlDbType.VarChar).Value = All_field;

            AdapterKey.SelectCommand = SearchKey;
            AdapterKey.Fill(KeyFinded);
            if (KeyFinded.Rows.Count > 0)
            {
                MessageBox.Show("Ключ активирован");
                KeyLicense.ConnectToDataBase();
                UpdateKey.ExecuteNonQuery();
                KeyLicense.EndConnectWithDataBase();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ключ не найден или актирован на другом аккаунте");
                
            }



            
        }

        private void Field1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
