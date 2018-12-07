using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace HairSalon.Models
{
  public class Client
  {
    private string _name;
    private int _employeeId;
    private int _id;

    public Client (string clientName, int employeeId, int id=0)
    {
      _name = clientName;
      _employeeId = employeeId;
      _id = id;
    }

    public string GetName()
    {
    return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetId()
    {
      return _id;
    }

    public static List<Client> GetAll()
    {
      List<Client> allClients = new List<Client> { };
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText=@"SELECT * FROM clients;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int clientId = rdr.GetInt32(0);
        string clientName = rdr.GetString(1);
        int clientStylistId = rdr.GetInt32(0);
        Client newClient = new Client(clientName, clientStylistId, clientId);
        allClients.Add(newClient);
      }
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return allClients;
    }
    public void Save()
    {
      // MySqlConnection conn = DB.Connection();
      // conn.Open();
      // MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      // cmd.CommandText=@"INSERT INTO clients (name) VALUES (@ClientName);";
      // MySqlParameter name = new MySqlParameter();
      // name.ParameterName = "@ClientName";
      // name.Value = this._name;
      // cmd.Parameters.Add(name);
      // cmd.executeNonQuery();
      // _id = (int) cmd.LastInsertedId;
      // conn.Close();
      // if(con != null)
      // {
      //   conn.Dispose();
      // }
    }


  }
}
