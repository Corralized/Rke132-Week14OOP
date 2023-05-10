Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);
Dog DogmyDog2 = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog._name}.");
Console.WriteLine($"My other dogs name is {DogmyDog2._name },");



class Dog
{
    public string _name = "Koer" ;
    public int _levelOfHapiness = 0 ;

    public Dog(string name)
    {
        _name = name ;
        _levelOfHapiness = 0 ;
    }

}
