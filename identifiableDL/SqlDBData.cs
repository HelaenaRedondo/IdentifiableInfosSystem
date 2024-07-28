using identifiableModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace identifiableDl
{
    public class SqlDBData
    {
        string connection = "Data Source =LILXX\\SQLEXPRESS; Initial Catalog = studinfoss; Integrated Security = True;";
        //static string connection = "Server=tcp:20.205.142.95,1433; Database=StudentInfoManagement; User Id=sa; Password=Ainaganda546511";

        SqlConnection sqlConnection;

        public SqlDBData()
        {
            sqlConnection = new SqlConnection(connection);
        }


        public List<identifiableDatas> Getidentifiable()
        {
            string SELECT = "SELECT * FROM Student";

            SqlCommand selcom = new SqlCommand(SELECT, sqlConnection);

            sqlConnection.Open();
            List<identifiableDatas> stud = new List<identifiableDatas>();

            SqlDataReader re = selcom.ExecuteReader();

            while (re.Read())
            {
                string firstname = re["firstname"].ToString();
                string middlename = re["middlename"].ToString();
                string lastname = re["lastname"].ToString();
                string email = re["email"].ToString();
                string contactnumber = re["contactnumber"].ToString();
                string address = re["address"].ToString();
                string password = re["password"].ToString();

                identifiableDatas read = new identifiableDatas();
                read.firstname = firstname;
                read.middlename = middlename;
                read.lastname = lastname;
                read.email = email;
                read.contactnumber = contactnumber;
                read.address = address;
                read.password = password;


                stud.Add(read);

            }
            sqlConnection.Close();

            return stud;
        }

        public int Addidentifiable(string firstname, string middlename, string lastname, string contactnumber, string email, string address, string password)
        {
            int success;

            string INSERT = "INSERT INTO Student VALUES(@firstname, @middlename, @lastname,@contactnumber, @address,@password)";

            SqlCommand incom = new SqlCommand(INSERT, sqlConnection);

            incom.Parameters.AddWithValue("@firstname", firstname);
            incom.Parameters.AddWithValue("@middlename", middlename);
            incom.Parameters.AddWithValue("@lastname", lastname);
            incom.Parameters.AddWithValue("@email", email);
            incom.Parameters.AddWithValue("@contactnumber", contactnumber);
            incom.Parameters.AddWithValue("@Address", address);
            incom.Parameters.AddWithValue("@password", password);
            sqlConnection.Open();

            success = incom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }
        public int Updateidentifiable(string firstname, string middlename, string lastname, string email, string contactnumber, string address, string password)
        {
            int success;

            string UPDATE = $"UPDATE identifiable SET firstname = @firstname, middlename = @middlename, @lastname = lastname, email = @email,contactnumber = @contactnumber,address=@address WHERE StudentID = @password";

            SqlCommand upcom = new SqlCommand(UPDATE, sqlConnection);


            upcom.Parameters.AddWithValue("@firstname", firstname);
            upcom.Parameters.AddWithValue("@middlename", middlename);
            upcom.Parameters.AddWithValue("@lastname", lastname);
            upcom.Parameters.AddWithValue("@email", email);
            upcom.Parameters.AddWithValue("@contactnumber", contactnumber);
            upcom.Parameters.AddWithValue("@Address", address);
            upcom.Parameters.AddWithValue("@password", password);
            sqlConnection.Open();

            success = upcom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;

        }
        public int Deleteidentifiable(string password)
        {
            int success;

            string DELETE = $"DELETE FROM identifiable WHERE password = @password";
            SqlCommand delcom = new SqlCommand(DELETE, sqlConnection);
            sqlConnection.Open();

            delcom.Parameters.AddWithValue("@password", password);

            success = delcom.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

    }
}