class Enemy
{
    string Name;
    int Health;
    public int _Health 
    {
        get {return Health;}
    }
    public List<Attack> AttackList;

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new();
    }

    public void RandomAttack()
    {
        Random attack = new();
        Attack randAttack = AttackList[attack.Next(AttackList.Count-1)];
        Console.WriteLine($"Attack: {randAttack.Name}\nDamage Dealt: {randAttack.DamageAmount}");
        
    }

    public void AddAttack(Attack newAttack)
    {
        AttackList.Add(newAttack);
    }
}