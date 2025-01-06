using System;

using Microsoft.Data.SqlClient;

internal class Connection 
{
    private string connectionString = "";

    public SqlConnection ObterConexao() {
      return new SqlConnection(connectionString);
    }
}