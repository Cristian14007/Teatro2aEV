namespace BackEnd.Models;
public class User
{

    public int UserId {get; set;}
    public string Nombre {get; set;}

    public string Password {get; set;}

    public int ReservaId {get; set;}

    public User (){

    }

    public User(int userId, string nombre, string password, int reservaId){

        UserId = userId;
        Nombre = nombre;
        Password = password;
        ReservaId = reservaId;
    }

}
