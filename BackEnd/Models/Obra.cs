namespace BackEnd.Models;
public class Obra
{

    public int ObraId {get; set;}

    public string Titulo {get; set;}

    public string Descripcion {get; set;}

    public string Genero {get; set;}

    public string Imagen {get; set;}

    public Obra (){

    }

    public Obra(int obraId, string titulo, string descripcion, string genero, string imagen){

        ObraId = obraId;
        Titulo = titulo;
        Descripcion = descripcion;
        Genero = genero;
        Imagen = imagen;
    }

}
