namespace UsineDeRobots;

public class Robot
{
    public string Nom { get; set; }
    public char Categorie { get; set; }  
    public Dictionary<string, Piece> Pieces { get; set; }
    public int Quantite { get; set; }
    public string SystemeInstalle { get; set; }

    public Robot(string nom, char categorie, int quantite = 0)
    {
        Nom = nom;
        Categorie = categorie;
        Quantite = quantite;
        Pieces = new Dictionary<string, Piece>();
    }

    public void AddPiece(string type, Piece piece)
    {
        Pieces[type] = piece;
    }

    public void SetSysteme(string systeme)
    {
        SystemeInstalle = systeme;
    }

    public override string ToString()
    {
        return $"{Quantite} {Nom}";
    }
}