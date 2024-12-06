using SevenWonders.Models;

namespace SevenWonders.Static;

public static class PreDefs
{
    public static List<Card> AgeICards = new List<Card>()
    {
        new ResourceCard(age:1, name:"Lumber Yard", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:3, resources:new List<string>(){"Wood"}),
        new ResourceCard(age:1, name:"Lumber Yard", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:4, resources:new List<string>(){"Wood"}),
        new ResourceCard(age:1, name:"Stone Pit", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:3, resources:new List<string>(){"Stone"}),
        new ResourceCard(age:1, name:"Stone Pit", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:5 , resources:new List<string>(){"Stone"}),
        new ResourceCard(age:1, name:"Clay Pool", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:3 , resources:new List<string>(){"Clay"}),
        new ResourceCard(age:1, name:"Clay Pool", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:5 , resources:new List<string>(){"Clay"}),
        new ResourceCard(age:1, name:"Ore Vein", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:3 , resources:new List<string>(){"Ore"}),
        new ResourceCard(age:1, name:"Ore Vein", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:4 , resources:new List<string>(){"Ore"}),
        new ResourceCard(age:1, name:"Tree Farm", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:6 , resources:new List<string>(){"Wood", "Clay"}),
        new ResourceCard(age:1, name:"Excavation", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:4 , resources:new List<string>(){"Stone", "Clay"}),
        new ResourceCard(age:1, name:"Clay Pit", type:"Raw Material", cost: new List<(string, int)>(){("Wood", 3), ("Coin", 2)}, minimumPlayers:3 , resources:new List<string>(){"Clay", "Ore"}),
    };
    public static List<AbstractWonder> Wonders = new List<AbstractWonder>()
    {
        new Alexandria(),
        new Babylon(),
        new Ephesos(),
        new Gizah(),
        new Halikarnassos(),
        new Olympia(),
        new Rhodos()
    };
}