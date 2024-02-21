namespace BackEnd.Models;
public class Asiento
{

    public int AsientoId {get; set;}

    public int SesionId {get; set;}

    public int NumAsiento {get; set;}

    public bool Reservado {get; set;}

    
    public Asiento (){

    }

    public Asiento(int asientoId, int sesionId, int numasiento, bool reservado){

        AsientoId = asientoId;
        SesionId = sesionId;
        NumAsiento = numasiento;
        Reservado = reservado;
    }

}
