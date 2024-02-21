namespace BackEnd.Models;
public class Sesion
{

    public int SesionId {get; set;}

    public DateTime DiaSesion {get; set;}

    public TimeSpan HoraSesion {get; set;}

    public int ObraId {get; set;}

    public List<Asiento> Asientos {get; set;}

    

    public Sesion (){

    }

    public Sesion(int sesionId, DateTime diasesion, TimeSpan horasesion, int obraId){

        SesionId = sesionId;
        DiaSesion = diasesion;
        HoraSesion = horasesion;
        ObraId = obraId;
    }

}
