namespace UsineDeRobots;

public class Stock
{
    public Dictionary<string, Piece> Pieces { get; private set; }
    public Dictionary<string, Robot> Robots { get; private set; }

    public Stock()
    {
        Pieces = new Dictionary<string, Piece>();
        Robots = new Dictionary<string, Robot>();
        InitializeStock();
    }

    private void InitializeStock()
    {
        // Modules principaux
        Pieces["Core_CM1"] = new Piece("Core_CM1", 'M', 10, true);
        Pieces["Core_CD1"] = new Piece("Core_CD1", 'D', 10, true);
        Pieces["Core_CI1"] = new Piece("Core_CI1", 'I', 10, true);
        
        // Générateurs
        Pieces["Generator_GM1"] = new Piece("Generator_GM1", 'M', 10);
        Pieces["Generator_GD1"] = new Piece("Generator_GD1", 'D', 10);
        Pieces["Generator_GI1"] = new Piece("Generator_GI1", 'I', 10);
        
        // Modules de préhension
        Pieces["Arms_AM1"] = new Piece("Arms_AM1", 'M', 10);
        Pieces["Arms_AD1"] = new Piece("Arms_AD1", 'D', 10);
        Pieces["Arms_AI1"] = new Piece("Arms_AI1", 'I', 10);
        
        // Modules de déplacement
        Pieces["Legs_LM1"] = new Piece("Legs_LM1", 'M', 10);
        Pieces["Legs_LD1"] = new Piece("Legs_LD1", 'D', 10);
        Pieces["Legs_LI1"] = new Piece("Legs_LI1", 'I', 10);
        
        // Systèmes
        Pieces["System_SB1"] = new Piece("System_SB1", 'G', 30);
        Pieces["System_SM1"] = new Piece("System_SM1", 'M', 10);
        Pieces["System_SD1"] = new Piece("System_SD1", 'D', 10);
        Pieces["System_SI1"] = new Piece("System_SI1", 'I', 10);

        // Robots
        var xm1 = new Robot("XM-1", 'M', 5);
        xm1.AddPiece("module", new Piece("Core_CM1", 'M', 0, true));
        xm1.AddPiece("generator", new Piece("Generator_GM1", 'M', 0));
        xm1.AddPiece("arms", new Piece("Arms_AM1", 'M', 0));
        xm1.AddPiece("legs", new Piece("Legs_LM1", 'M', 0));
        xm1.SetSysteme("System_SB1");
        Robots["XM-1"] = xm1;
        
        var rd1 = new Robot("RD-1", 'D', 5);
        rd1.AddPiece("module", new Piece("Core_CD1", 'D', 0, true));
        rd1.AddPiece("generator", new Piece("Generator_GD1", 'D', 0));
        rd1.AddPiece("arms", new Piece("Arms_AD1", 'D', 0));
        rd1.AddPiece("legs", new Piece("Legs_LD1", 'D', 0));
        rd1.SetSysteme("System_SB1");
        Robots["RD-1"] = rd1;
        
        var wi1 = new Robot("WI-1", 'I', 5);
        wi1.AddPiece("module", new Piece("Core_CI1", 'I', 0, true));
        wi1.AddPiece("generator", new Piece("Generator_GI1", 'I', 0));
        wi1.AddPiece("arms", new Piece("Arms_AI1", 'I', 0));
        wi1.AddPiece("legs", new Piece("Legs_LI1", 'I', 0));
        wi1.SetSysteme("System_SB1");
        Robots["WI-1"] = wi1;
    }

}