namespace BackEnd.Models;
public class Reserva
{

    public int ReservaId {get; set;}
    public int SesionId {get; set;}

    public DateTime DiaReservado {get; set;}

    public TimeSpan HoraReserva {get; set;}

    public List<Asiento> AsientosReservados {get; set;}

       

    public Reserva (){

    }

    public Reserva(int reservaId, int sesionId, DateTime diareservado, TimeSpan horareserva){

        ReservaId = reservaId;
        SesionId = sesionId;
        DiaReservado = diareservado;
        HoraReserva = horareserva;
    }

}
