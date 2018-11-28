using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14ProgSem2
{
    class CheckCode
    {
        public SqlConnection connection;
        public SqlCommand command;
        public bool accsees = false;
        public CheckCode()
        {
            string constr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection();
            connection.ConnectionString = constr;

            if (connection == null)
            {
                MessageBox.Show("Connection Error");
                return;
            }
            connection.ConnectionString = constr;
            connection.Open();


        }
        public bool Check(string code)
        {
            List<string> values = new List<string>();
            command = new SqlCommand("select * from dbo.CodeAutorization", connection);
            if (command == null)
            {
                MessageBox.Show("Connection Error");
            }
            using (DbDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    values.Add($"{dataReader["Id"]}");
                    values.Add($"{dataReader["Code"]}");

                }
            }
            Console.ReadLine();

            bool isPresent = false;
            foreach (string value in values)
            {
                MessageBox.Show(value);
                isPresent = code == value ? true : false;
            }
            if (isPresent) accsees = true;
            return isPresent;
        }
        public void InsertCode(string code)
        {
            try
            {
                command = new SqlCommand("insert into dbo.CodeAutorization(Code) values(@code )", connection);
                command.Parameters.Add(new SqlParameter("@code", code));
                command.ExecuteNonQuery();
                if (command == null)
                {
                    MessageBox.Show("Connection Error");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
