namespace Authentication;
public class AuthManager{
    public bool  Validate(string username, string password){
        bool status=false;
        if(username == "" && password==""){

            status=true;
        }
        
        return status;
    }

     
}

//TDD
//Test Driven Development