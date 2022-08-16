//Namespace é um conjunto de classes
//Namespace é uma divisão lógica
namespace VoeAirlinesSenai.Entities;

//Classe: é um conjunto de objeto
//Objeto: é uma instância de uma classe
public class Aeronave{
    public Aeronave(string? codigo, string? modelo, string? fabricante)
    {
        Codigo = codigo;
        Modelo = modelo;
        Fabricante = fabricante;
    }

    //Propriedades Automáticas
    // Caracteristicas de objeto
    //Automático:gera o get set
    //Métodos set  -atribui
    //Métodod ger -recupera
    //POCO-foco é o objeto
    public int? Id{get;set;}
public string? Codigo{ get;set;} 
public string? Modelo {get;set;}

public string? Fabricante{get;set;}
public ICollection<Manutencao> manutencaos {get;set;}
}
