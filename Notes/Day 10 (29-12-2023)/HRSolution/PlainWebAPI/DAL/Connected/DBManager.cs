namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;
//using inbuilt, external Object Models
public class DBManager{
    public static string conString=@"server=localhost;port=3306;user=root; password=password;database=transflower";       

    public static List<Product> GetAllProducts(){
       List<Product> list=new List<Product>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString ="server=localhost;port=3306;user=root;password=password;database=ecommerce";
        string query ="select * from products";
        MySqlCommand command = new MySqlCommand(query, connection);
        try{
            connection.Open();
            MySqlDataReader reader=command.ExecuteReader();
            
            while(reader.Read()){
            Product product=new Product();
            int id=int.Parse(reader["product_id"].ToString());
            string title=reader["product_title"].ToString();
            string description=reader["description"].ToString();
            product.Id=id;
            product.Title=title;
            product.Description=description;
            list.Add(product);
            }
            reader.Close();
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            connection.Close();
        }
        return list;
    }
    }