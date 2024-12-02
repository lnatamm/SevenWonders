namespace SevenWonders.Models;

public class Alexandria : AbstractWonder, IWonder
{
    public Alexandria()
    {
        Name = "Alexandria";
        NumberOfStages = 3;
        StageCosts = new List<List<(string, int)>>()
        {
            new List<(string, int)>()
            {
                ("Stone", 2)
            },
            new List<(string, int)>()
            {
                ("Ore", 2)
            },
            new List<(string, int)>()
            {
                ("Paper", 1),
                ("Fabric", 1)
            }
        };
    }

    public void Effect(Player player, int stageNumber){
        
    }

}

public class Babylon : AbstractWonder, IWonder
{

    public Babylon()
    {
        Name = "Babylon";
        NumberOfStages = 3;
        StageCosts = new List<List<(string, int)>>()
        {
            new List<(string, int)>()
            {
                ("Clay", 2)
            },
            new List<(string, int)>()
            {
                ("Ore", 2),
                ("Fabric", 1)
            },
            new List<(string, int)>()
            {
                ("Wood", 4)
            }
        };
    }

    public void Effect(Player player, int stageNumber){
        
    }
}

public class Ephesos : AbstractWonder, IWonder
{

    public Ephesos()
    {
        Name = "Éphesos";
        NumberOfStages = 3;
        StageCosts = new List<List<(string, int)>>()
        {
            new List<(string, int)>()
            {
                ("Clay", 2)
            },
            new List<(string, int)>()
            {
                ("Wood", 2)
            },
            new List<(string, int)>()
            {
                ("Ore", 2),
                ("Glass", 1)
            }
        };
    }

    public void Effect(Player player, int stageNumber){
        
    }
}

public class Gizah : AbstractWonder, IWonder
{
    public Gizah()
    {
        Name = "Gizah";
        NumberOfStages = 3;
        StageCosts = new List<List<(string, int)>>()
        {
            new List<(string, int)>()
            {
                ("Wood", 2)
            },
            new List<(string, int)>()
            {
                ("Clay", 2),
                ("Fabric", 1)
            },
            new List<(string, int)>()
            {
                ("Stone", 4)
            }
        };
    }

    public void Effect(Player player, int stageNumber){
        
    }
}

public class Halikarnassos : AbstractWonder, IWonder
{

    public Halikarnassos()
    {
        Name = "Halikarnassos";
        NumberOfStages = 3;
        StageCosts = new List<List<(string, int)>>()
        {
            new List<(string, int)>()
            {
                ("Ore", 2)
            },
            new List<(string, int)>()
            {
                ("Glass", 1),
                ("Paper", 1)
            },
            new List<(string, int)>()
            {
                ("Stone", 3)
            }
        };
    }

    public void Effect(Player player, int stageNumber){
        
    }
}

public class Olympia : AbstractWonder, IWonder
{
    public Olympia()
    {
        Name = "Olympia";
        NumberOfStages = 3;
        StageCosts = new List<List<(string, int)>>()
        {
            new List<(string, int)>()
            {
                ("Ore", 2)
            },
            new List<(string, int)>()
            {
                ("Clay", 3)
            },
            new List<(string, int)>()
            {
                ("Glass", 1),
                ("Paper", 1),
                ("Fabric", 1)
            }
        };
    }

    public void Effect(Player player, int stageNumber){
        
    }
}

public class Rhodos : AbstractWonder, IWonder
{

    public Rhodos()
    {
        Name = "Rhodos";
        NumberOfStages = 3;
        StageCosts = new List<List<(string, int)>>()
        {
            new List<(string, int)>()
            {
                ("Wood", 2)
            },
            new List<(string, int)>()
            {
                ("Clay", 3)
            },
            new List<(string, int)>()
            {
                ("Ore", 4)
            }
        };
    }

    public void Effect(Player player, int stageNumber){
        
    }
}