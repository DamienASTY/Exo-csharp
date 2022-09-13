namespace Porgram;

public class Chien
{
    private string nom;
    private string race;
    
    public Chien(string nom, string race)
    {
        this.nom = nom;
        this.race = race;
    }

    public virtual string? ToString()
    {
        return "Nom : " + this.nom + " race : " + this.race;
    }
}
