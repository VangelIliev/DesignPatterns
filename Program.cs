using DesignPatterns.Creational;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using System.Text;

var coach = new Coach();
var players = new List<Player>()
{
    new("John", 10),
    new("Vangel", 7)
};
var team = new Team(coach, players);
team.PlayGame();