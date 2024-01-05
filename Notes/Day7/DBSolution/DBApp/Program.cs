// Entry Poin Main function Code

//dotnet add package MySql.Data

using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to database App");

//Define connection string
//Create connection object
//set connection string to connection object
//defined sql query
//create command object
//Open connection
//Execute Command
//retrived result into DataReader
//iterate data from reader object
//Show data
//Close connection

MySqlConnection connection = new MySqlConnection();
connection.ConnectionString ="server=localhost;port=3306;user=root;password=password;database=ecommerce";
//string query ="select * from products";
//string query="select count(*) from products";
Console.WriteLine("Enter the id of product to be deleted:");
int id=int.Parse(Console.ReadLine());
//string query="update products set product_title='iPhone' where product_id=14";



//Parameterized Query

MySqlCommand command = new MySqlCommand(query, connection);
//string query="delete from products where product_id=@id";
//command.Parameters.AddWithValue("@id",id);

//To invoke Stored Procedure
//string query="CalculateSalary";
//command.CommandType=MySqlCommandType.StoredProcedure;
//command.CommandText="CalculateSalary"

try{
    connection.Open();
   /* MySqlDataReader reader=command.ExecuteReader();
    while(reader.Read()){
       int id=int.Parse(reader["product_id"].ToString());
       string title=reader["product_title"].ToString();
       string description=reader["description"].ToString();
       Console.WriteLine(id+ " "+ title+ " "+ description);
    }
    reader.Close();
    */

   command.ExecuteNonQuery();
   /*int count=int.Parse((command.ExecuteScalar()).ToString());
   Console.WriteLine( " Number of products available for sale "+ count);
   */

}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}

/*
MySqlConnection: Represents an open connection to a MySQL database.
MySqlConnectionStringBuilder: Aids in the creation of a connection string by exposing the connection options as properties.
MySqlCommand: Represents an SQL statement to execute against a MySQL database.
MySqlCommandBuilder: Automatically generates single-table commands used to reconcile changes made to a DataSet object with the associated MySQL database.
MySqlDataAdapter: Represents a set of data commands and a database connection that are used to fill a data set and update a MySQL database.
MySqlDataReader: Provides a means of reading a forward-only stream of rows from a MySQL database.
MySqlException: The exception that is thrown when MySQL returns an error.
MySqlHelper: Helper class that makes it easier to work with the provider.
MySqlTransaction: Represents an SQL transaction to be made in a MySQL database.
MySQLMembershipProvider: Manages storage of membership information for an ASP.NET application in a MySQL database.
MySQLRoleProvider: Manages storage of role membership information for an ASP.NET application in a MySQL database.
MySqlEFConfiguration: Adds the dependency resolvers for MySQL classes.
MySqlExecutionStrategy: Enables automatic recovery from transient connection failures.





*/