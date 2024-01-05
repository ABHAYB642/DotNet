using MySql.Data.MySqlClient;
using CRUDS;
CRUD conn=new CRUD();
conn.select();
conn.insert(27,"Abhay",45,200);
conn.update(20,"Sujit");
conn.deletebyid();
conn.callproc(26);











