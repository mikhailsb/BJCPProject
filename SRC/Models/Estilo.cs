
namespace SRC.Models;

public class Estilo
{
    public Estilo()
    {
        this.Nome = "";
    }
    public Estilo(string nome, decimal abv, int ibu, int srm)
    {
        this.Nome = nome;
        this.ABV = abv;
        this.IBU = ibu;
        this.SRM = srm;
        
    }
    public Estilo(string nome, string og, string fg, int srm, int ibu, decimal abv)
    {
        this.Nome = nome;
        this.OG = og;
        this.FG = fg;
        this.SRM = srm;
        this.IBU = ibu;
        this.ABV = abv;
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public string? ImpressaoGeral { get; set; }
    public string? Aroma { get; set; }
    public string? Aparencia { get; set; }
    public string? Sabor { get; set; }
    public string? SensacaoDeBoca { get; set; }
    public string? Comentarios { get; set; }
    public string? Historia { get; set; }
    public string? IngredientesCaracteristicos { get; set; }
    public string? ComparacaoDeEstilos { get; set; }
    public string? Etiqueta { get; set; }
    public string? OG { get; set; }
    public string? FG { get; set; }
    public int SRM { get; set; }
    public int IBU { get; set; }
    public decimal ABV { get; set; }
}