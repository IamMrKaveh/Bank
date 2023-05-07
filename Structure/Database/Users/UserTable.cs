using System;
using System.Data;
using System.Data.SqlClient;
using Bank.Structure.Message;
using Bank.Structure.Models;

namespace Bank.Structure.Database.Users
{
  public class UserTable : Bank
  {
    public string AddUser(EncryptedUsers user)
    {
      using (SqlConnection sqlConnection = new SqlConnection(Bank_connectionString))
      {
        try
        {
          sqlConnection.Open();
          SqlCommand sqlCommand = new SqlCommand()
          {
            CommandText = "AddUser",
            Connection = sqlConnection,
            CommandType = CommandType.StoredProcedure,
          };

          sqlCommand.Parameters.AddWithValue("@username", user.EncryptedUsername);
          sqlCommand.Parameters.AddWithValue("@password", user.EncryptedPassword);

          sqlCommand.ExecuteNonQuery();

          return "success";
        }
        catch (Exception ex)
        {
          return ex.Message;
        }
      }
    }
  }
}
