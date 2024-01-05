namespace DAL;
using MySql.Data.MySqlClient;
using System;
using BOL;
using System.Data;
using System.Collections.Generic;
using System.Net.Http.Headers;

public class DBManager
{
    public static string constring=@"server=localhost;port=3306;user=root;password=Abhay@123;database=test";

    public static bool deletebyID(int id)
    {
        MySqlConnection conn=new MySqlConnection();
       conn.ConnectionString=constring;
       string query="delete from students where id=@id";
       conn.Open();
       try{
        MySqlCommand command=new MySqlCommand(query,conn);
        command.Parameters.AddWithValue("@id",id);
        int n=command.ExecuteNonQuery();
        if(n>0){
            return true;
        }
       }catch(Exception e){
        Console.WriteLine(e.Message);
       }
       finally{
        conn.Close();
       }
       return false;
    }

    public static bool deleteuser(string username, string password)
    {
       MySqlConnection conn=new MySqlConnection();
       conn.ConnectionString=constring;
       string query="delete from user where uname=@username and password=@password";
       conn.Open();
       try{
        MySqlCommand command=new MySqlCommand(query,conn);
        command.Parameters.AddWithValue("@username",username);
        command.Parameters.AddWithValue("@password",password);
        int n=command.ExecuteNonQuery();
        if(n>0){
            return true;
        }
       }catch(Exception e){
        Console.WriteLine(e.Message);
       }
       finally{
        conn.Close();
       }
       return false;
    }

    public static bool editbyid(int id, string name, string hobby)
    {
        MySqlConnection conn=new MySqlConnection();
       conn.ConnectionString=constring;
       string query="update students set name=@name,hobby=@hobby where id=@id";
       conn.Open();
       try{
        MySqlCommand command=new MySqlCommand(query,conn);
        command.Parameters.AddWithValue("@name",name);
        command.Parameters.AddWithValue("@hobby",hobby);
        command.Parameters.AddWithValue("@id",id);
        int n=command.ExecuteNonQuery();
        if(n>0){
            return true;
        }
       }catch(Exception e){
        Console.WriteLine(e.Message);
       }
       finally{
        conn.Close();
       }
       return false;
    }

    public static List<Student> getallstudents()
    {
        List<Student>list=new List<Student>();
        MySqlConnection conn =new MySqlConnection();
        conn.ConnectionString=constring;
        string query="select * from students";
        conn.Open();
        try{
            MySqlCommand command=new MySqlCommand(query,conn);
            MySqlDataReader reader=command.ExecuteReader();
            while(reader.Read()){
                int id=int.Parse(reader[0].ToString());
                string name=reader[1].ToString();
                string hobby=reader[2].ToString();
                Student s=new Student(id,name,hobby); 
                list.Add(s);   
                }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            conn.Close();
        }
        return list;
    }

    public static bool RegisterUser(string username, string password)
    {
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=constring;
        string query="insert into user(uname,password) values(@username,@password)";
        conn.Open();
        try{
            MySqlCommand command=new MySqlCommand(query,conn);
            command.Parameters.AddWithValue("@username",username);
            command.Parameters.AddWithValue("@password",password);
            int n=command.ExecuteNonQuery();
            if(n>0){
                return true;
            }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }
        return false;
    }

    public static bool UpdatePass(string username, string password)
    {

        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=constring;
        conn.Open();
        string query="update user set password=@password where uname=@username";
        try{
            MySqlCommand command=new MySqlCommand(query,conn);
            command.Parameters.AddWithValue("@username",username);
            command.Parameters.AddWithValue("@password",password);
            int n=command.ExecuteNonQuery();
            if(n>0){
                return true;
            }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }
        return false;

    }

    public static bool validateUser(string username, string password)
    {
        MySqlConnection conn =new MySqlConnection();
        conn.ConnectionString=constring;
        string query="select * from user where uname=@username and password=@password";
        conn.Open();
        try{
        MySqlCommand command=new MySqlCommand(query,conn);
        command.Parameters.AddWithValue("@username",username);
        command.Parameters.AddWithValue("@password",password);
        MySqlDataReader reader=command.ExecuteReader();
        if(reader.Read()){
            return true;
        }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            conn.Close();
        }
        return false;
    }
}
