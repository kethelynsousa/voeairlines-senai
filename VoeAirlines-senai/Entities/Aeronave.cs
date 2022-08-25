//Namespace é um conjunto de classes
//Namespace é uma divisão lógica
namespace VoeAirlinesSenai.Entities;
//Classe:é um conjunto de objetos
//Objeto: é uma instância de uma classe
public class Aeronave
{
    public Aeronave(string fabricante, string modelo, string codigo)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Codigo = codigo;
    }
    //Propriedades Automáticas
    //Características do objeto
    //Automático:gera o get set
    //Métodos set -atribui
    //Métodos get -recupera
    //POCO-foco é o objeto
    public int Id { get; set; }
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public string Codigo { get; set; }
    public ICollection<Manutencao> Manutencoes { get; set; } = null!;
    public ICollection<Voo> Voos {get;set;}=null!;
}