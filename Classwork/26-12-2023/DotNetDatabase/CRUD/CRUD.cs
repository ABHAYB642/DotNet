using System.Data;
using MySql.Data.MySqlClient;
namespace CRUDS;

public class CRUD{
MySqlConnection connection = new MySqlConnection();
public CRUD(){
    try{
    connection.ConnectionString ="server=localhost;port=3306;user=root;password=root;database=test";
    connection.Open();
    }
    catch(Exception e){
    Console.WriteLine(e.Message);
}
    }
     public void select(){
        string query="select * from product";
        MySqlDataReader reader=null;
        try{
        MySqlCommand command = new MySqlCommand(query, connection);
        reader=command.ExecuteReader();
        while(reader.Read()){
       int id=int.Parse(reader["pid"].ToString());
       string pname=reader["pname"].ToString();
       int qty=int.Parse(reader["qty"].ToString());
       Console.WriteLine(id+ " "+ pname+ " "+ qty);
        }
     }
     catch(Exception e){
    Console.WriteLine(e.Message);
    }
finally{
    reader?.Close();
}
}

    public void insert(int pid,String pname,int qty,double price){
        string query="INSERT INTO Product (pid,pname,qty,price)values(@pid,@pname,@qty,@price)";
        try{
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@pid",pid);
            command.Parameters.AddWithValue("@pname",pname);
            command.Parameters.AddWithValue("@qty",qty);
            command.Parameters.AddWithValue("@price",price);
            int n=command.ExecuteNonQuery();
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
     }

     public void update(int id,String name){
        string query="update product set pname=@name where pid=@pid";
        try{
            MySqlCommand command=new MySqlCommand(query,connection);
            command.Parameters.AddWithValue("@pid",id);
            command.Parameters.AddWithValue("@name",name);
            int n=command.ExecuteNonQuery();
            }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }    
     }

        public void deletebyid(){
        string query="delete from product where pid=@pid";
        try{
            Console.WriteLine("Enter ID to delete");
            int id=int.Parse(Console.ReadLine());
            MySqlCommand command=new MySqlCommand(query,connection);
            command.Parameters.AddWithValue("@pid",id);
            int n=command.ExecuteNonQuery();
            }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        }

        public void callproc(int id){
        string query="dotnetproc";
        MySqlCommand command = new MySqlCommand();
        command.Connection = connection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = query;
        command.Parameters.AddWithValue("@id",id);
        command.ExecuteNonQuery();
        }

        public void closeconnection(){
            connection.Close();
        }


}


