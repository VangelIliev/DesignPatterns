using DesignPatterns.Creational;
using DesignPatterns.Structural.Bridge;
using System.Text;

var warrior = new Warrior(new AttackBehaviour());
var archer = new Archer(new AttackBehaviour());
var merchant = new Merchant(new TradeBehaviour());

warrior.Interact();

archer.Interact();

merchant.Interact();