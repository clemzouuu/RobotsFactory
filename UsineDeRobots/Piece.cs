namespace UsineDeRobots;

public class Piece
{
    public string Nom { get; set; }
    public char Categorie { get; set; }  
    public int Quantite { get; set; }
    public bool NecessiteSysteme { get; set; }

    public Piece(string nom, char categorie, int quantite, bool necessiteSysteme = false)
    {
        Nom = nom;
        Categorie = categorie;
        Quantite = quantite;
        NecessiteSysteme = necessiteSysteme;
    }

    public override string ToString()
    {
        return $"{Quantite} {Nom}";
    }
}