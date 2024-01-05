namespace BlL;
using DAL;
using System;
using BOL;
using System.Collections.Generic;

public class Services
{
    public static bool deletebyID(int id)
    {
        return DBManager.deletebyID(id);
    }

    public static bool deleteuser(string username, string password)
    {
        return DBManager.deleteuser(username,password);
    }

    public static bool editbyid(int id, string name, string hobby)
    {
         return DBManager.editbyid(id,name,hobby);
    }

    public static List<Student> getallstudents()
    {
        return DBManager.getallstudents();
    }

    public static bool RegisterUser(string username, string password)
    {
        return DBManager.RegisterUser(username,password);
    }

    public static bool UpdatePass(string username, string password)
    {
        return DBManager.UpdatePass(username,password);
    }

    public static bool Validate(string username, string password)
    {
        return DBManager.validateUser(username,password);
}
}
