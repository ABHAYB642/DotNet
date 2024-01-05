namespace DAL.DisConnected;
using BOL;
using System.Data;
using MySql.Data.MySqlClient;
using System.Net.Quic;

public class DBManager{

    public static string conString=@"server=localhost;port=3306;user=root; password=root;database=test";       
    public  static List<Product> GetAllProducts(){
        List<Product> allDepartments=new List<Product>();

        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        try{
            DataSet ds=new DataSet();  //empty data set
            string query="SELECT * FROM Product";
            MySqlCommand cmd=new MySqlCommand(query,con);
            //cmd.Connection=con;
            // SELECT * FROM employees; SELECT * FROM roles";
            //cmd.CommandText=query;
            //disconnected Data Access logic
            MySqlDataAdapter da=new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);  // this method would fetch data from backend mysql and 
                          //fill results into dataset collection
                          //deal with data which has been fetched from back end
        
            DataTable dt=ds.Tables[0];
          
            DataRowCollection rows=dt.Rows;
            foreach( DataRow row in rows)
            {
                int id = int.Parse(row["pid"].ToString());
                string name = row["pname"].ToString();
                int qty = int.Parse(row["qty"].ToString());
                int price = int.Parse(row["price"].ToString());
                Product dept=new Product{
                                                id = id,
                                                name = name,
                                                qty=qty,
                                                Price=price                
                };
                allDepartments.Add(dept);
            }
        }
        catch(Exception e){
                Console.WriteLine(e.Message);
        }
        return allDepartments;
    }

    
}