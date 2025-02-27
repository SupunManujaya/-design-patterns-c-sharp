using design_patterns;

GameManager game1 = GameManager.Instance;
GameManager game2 = GameManager.Instance;
GameManager game3 = GameManager.Instance;

Console.WriteLine(game1.GetHashCode());
Console.WriteLine(game2.GetHashCode());
Console.WriteLine(game3.GetHashCode());

//Vehicle car1 = new Vehicle("Toyota", "141");
//Vehicle car2 = new Vehicle("Lancer", "Evolusion");

//car1.ShowDetails();
//car2.ShowDetails();

//Console.WriteLine(car1.GetHashCode());
//Console.WriteLine(car2.GetHashCode());

