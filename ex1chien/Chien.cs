namespace Porgram;

public class Chien
{
    private string nom;
    private string race;
    private int age;
    private static int instance;
    
    public Chien(string nom, string race, int age)
    {
        this.nom = nom;
        this.race = race;
        this.age = age;
        instance++;
    }

    public int getAge()
    {
        return this.age;
    }

    public static int getIstance()
    {
        return instance;
    }

    public virtual string? ToString()
    {
        return "Nom : " + this.nom + " race : " + this.race + " age : " + age + " ans";
    }
}
