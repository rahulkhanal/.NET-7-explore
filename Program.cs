using MyConsoleApp.entities;

List<Game> games = new(){
    new Game(){
        Id = 18,
        Name= "Stree fighter",
        Genre = "Fighting",
        Price = 19.99M,
        ReleaseDate = new DateTime(1991,2,1),
        ImageUri = "https://placehold.co/100"
    },
     new Game(){
        Id = 10,
        Name= "PUBG",
        Genre = "Fighter",
        Price = 69.99M,
        ReleaseDate = new DateTime(1991,2,1),
        ImageUri = "https://placehold.co/100"
    },
     new Game(){
        Id = 1,
        Name= "Clash of Clan",
        Genre = "Strategies",
        Price = 90.99M,
        ReleaseDate = new DateTime(1991,2,1),
        ImageUri = "https://placehold.co/100"
    },
     new Game(){
        Id = 2,
        Name= "UEFA football",
        Genre = "Sport",
        Price = 7.99M,
        ReleaseDate = new DateTime(1991,2,1),
        ImageUri = "https://placehold.co/100"
    },
};

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/games", () => games);

app.Run();