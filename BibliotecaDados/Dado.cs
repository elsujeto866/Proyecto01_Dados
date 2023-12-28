namespace BibliotecaDados;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

public class Dado
{
    private int num_caras;
    private int cara_obtenida;
    private string nombre;
    public Dado(Dados_Enum? dado_n) { 
        switch (dado_n)
        {
            case Dados_Enum.normal:num_caras = 6; break;
            case Dados_Enum.octaedro: num_caras = 8; break;
            case Dados_Enum.decaedro: num_caras = 10; break;
            case Dados_Enum.dodecaedro: num_caras = 0; break;
        }
        switch (dado_n)
        {
            case Dados_Enum.normal: nombre = "normal"; break;
            case Dados_Enum.octaedro: nombre = "octogonal"; break;
            case Dados_Enum.decaedro: nombre = "decaedro"; break;
            case Dados_Enum.dodecaedro: nombre = "dodecaedro"; break;
        }
    }
    public int ObtenerCara()
    {
        Random rnd = new Random();
        cara_obtenida=rnd.Next(0, num_caras + 1);
        return cara_obtenida;
    }
    public int getCara()
    {
        
        return cara_obtenida;
    }
    public override string ToString()
    {
        return nombre;
    }
}
