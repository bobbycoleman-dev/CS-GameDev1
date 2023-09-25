Enemy Gunslinger = new("Roland");

Attack Barrage = new("Barrage", 25);
Attack Curve = new("Bullet Curve", 10);
Attack Punch = new("Punch", 5);

Gunslinger.AddAttack(Barrage);
Gunslinger.AddAttack(Curve);
Gunslinger.AddAttack(Punch);

Gunslinger.RandomAttack();