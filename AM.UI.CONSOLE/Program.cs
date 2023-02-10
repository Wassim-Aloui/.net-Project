// See https://aka.ms/new-console-template for more information

//declaratio d'un variable 
//int nb = int.Parse(Console.ReadLine());

//for (int i=0; i<nb; i++)
//{
//    string chaine = Console.ReadLine();
//    float age = 0;

//    while (age <= 0)
//    {
//        try
//        {
//            age = float.Parse(Console.ReadLine());
//        }
//        catch
//        {
//            Console.WriteLine("Erreur");
//        }
//    }
//    Console.WriteLine("Hello:" + chaine + "age:" + (age + 100));
//}
using AM.ApplicationCore.Domain;

Person person = new Person();
person.Id = 0;
person.Nom = "aloui";
person.Prenom = "wassim";
person.Password = "0000";
person.Email = "wass@gmail.com";
person.DateNaissance = new DateTime(2022, 12, 31);
//person.DateNaissance= DateTime.Now;
Console.WriteLine(person);  

//doit respecter l'ordre 
Person p = new Person(1,"wass","aloui","wass@gmail.com","0000",DateTime.Now);
Console.WriteLine(p);

//pas d'ordre de propriete
Person per = new Person() { 
    Id=1,
    Nom="houss",
    Prenom="al",
    Email="email",
    Password="pass",
    DateNaissance=DateTime.Now
};

//Etudiant e = new Etudiant();
//e.getMyType();
//person.getMyType();

//Methode1
Plane plane = new Plane();
plane.Capacity = 1; 
plane.PlaneId= 1;
plane.ManufactureDate = DateTime.Now;
plane.PlaneType = PlaneType.Boing;

//Methode2
Plane plane1= new Plane() { 
    Capacity= 1 ,
    PlaneId= 1 ,
    ManufactureDate=DateTime.Now,
    PlaneType=PlaneType.Airbus
   
};

Plane plane3 = new Plane(2, DateTime.Now, 1, PlaneType.Boing );



Passenger passenger = new Passenger();
passenger.passengerType();

Passenger Passenger1 = new Staff();
Passenger1.passengerType();

Passenger Passenger2 = new Traveller();
Passenger2.passengerType();







