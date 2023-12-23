using GenericTemplateAPI.API.Context;
using GenericTemplateAPI.API.Entities;

namespace GenericTemplateAPI.API.Framework
{
    public static class DataSeeder
    {
        public static void Seed(DatabaseContext context)
        {

            var normal = new PokemonType()
            {
                Name = "Normal",
            };
            var fire = new PokemonType()
            {
                Name = "Fire",
            };
            var water = new PokemonType()
            {
                Name = "Water",
            };
            var electric = new PokemonType()
            {
                Name = "Electric",
            };
            var grass = new PokemonType()
            {
                Name = "Grass",
            };
            var ice = new PokemonType()
            {
                Name = "Ice",
            };
            var fighting = new PokemonType()
            {
                Name = "Fighting",
            };
            var poison = new PokemonType()
            {
                Name = "Poison",
            };
            var ground = new PokemonType()
            {
                Name = "Ground",
            };
            var flying = new PokemonType()
            {
                Name = "Flying",
            };
            var psychic = new PokemonType()
            {
                Name = "Psychic",
            };
            var bug = new PokemonType()
            {
                Name = "Bug",
            };
            var rock = new PokemonType()
            {
                Name = "Rock",
            };
            var ghost = new PokemonType()
            {
                Name = "Ghost",
            };
            var dragon = new PokemonType()
            {
                Name = "Dragon",
            };
            var types = new List<PokemonType>() { normal, fire, water, electric, grass, ice, fighting, poison, ground, flying, psychic, bug, rock, ghost, dragon };
            context.PokemonTypes.AddRange(types);

            var venosaur = new Pokemon()
            {
                Id = 3,
                Name = "Venosaur",
                PokemonTypes = new List<PokemonType> { grass, poison },
                Evolution = null,
            };
            var ivysaur = new Pokemon()
            {
                Id = 2,
                Name = "Ivysaur",
                PokemonTypes = new List<PokemonType> { grass, poison },
                Evolution = new Evolution()
                {
                    Level = 32,
                    Pokemon = venosaur,
                }
            };
            var bulbasaur = new Pokemon()
            {
                Id = 1,
                Name = "Bulbasaur",
                PokemonTypes = new List<PokemonType>() { grass, poison },
                Evolution = new Evolution()
                {
                    Level = 16,
                    Pokemon = ivysaur,
                },
            };
            var charizard = new Pokemon()
            {
                Id = 6,
                Name = "Charizard",
                PokemonTypes = new List<PokemonType> { fire, flying },
                Evolution = null,
            };
            var charmeleon = new Pokemon()
            {
                Id = 5,
                Name = "Charmeleon",
                PokemonTypes = new List<PokemonType> { fire },
                Evolution = new Evolution()
                {
                    Level = 36,
                    Pokemon = charizard,
                },
            };
            var charmander = new Pokemon()
            {
                Id = 4,
                Name = "Charmander",
                PokemonTypes = new List<PokemonType>() { fire },
                Evolution = new Evolution()
                {
                    Level = 16,
                    Pokemon = charmeleon,
                },
            };
            var blastoise = new Pokemon()
            {
                Id = 9,
                Name = "Blastoise",
                PokemonTypes = new List<PokemonType>() { water },
                Evolution = null,
            };
            var wartortle = new Pokemon()
            {
                Id = 8,
                Name = "Wartortle",
                PokemonTypes = new List<PokemonType>() { water },
                Evolution = new Evolution()
                {
                    Level = 36,
                    Pokemon = blastoise,
                },
            };
            var squirtle = new Pokemon()
            {
                Id = 7,
                Name = "Squirtle",
                PokemonTypes = new List<PokemonType>() { water },
                Evolution = new Evolution()
                {
                    Level = 16,
                    Pokemon = wartortle,
                },
            };
            var butterfree = new Pokemon()
            {
                Id = 12,
                Name = "Butterfree",
                PokemonTypes = new List<PokemonType>() { bug, flying },
                Evolution = null,
            };
            var metapod = new Pokemon()
            {
                Id = 11,
                Name = "Metapod",
                PokemonTypes = new List<PokemonType>() { bug },
                Evolution = new Evolution()
                {
                    Level = 10,
                    Pokemon = butterfree,
                },
            };
            var caterpie = new Pokemon()
            {
                Id = 10,
                Name = "Caterpie",
                PokemonTypes = new List<PokemonType>() { bug },
                Evolution = new Evolution()
                {
                    Level = 7,
                    Pokemon = metapod,
                },
            };
            var beedrill = new Pokemon()
            {
                Id = 15,
                Name = "Beedrill",
                PokemonTypes = new List<PokemonType>() { bug, poison },
                Evolution = null,
            };
            var kakuna = new Pokemon()
            {
                Id = 14,
                Name = "Kakuna",
                PokemonTypes = new List<PokemonType>() { bug, poison },
                Evolution = new Evolution()
                {
                    Level = 11,
                    Pokemon = beedrill,
                },
            };
            var weedle = new Pokemon()
            {
                Id = 13,
                Name = "Weedle",
                PokemonTypes = new List<PokemonType>() { bug, poison },
                Evolution = new Evolution()
                {
                    Level = 7,
                    Pokemon = kakuna,
                },
            };
            var pidgeot = new Pokemon()
            {
                Id = 18,
                Name = "Pidgeot",
                PokemonTypes = new List<PokemonType>() { normal, flying },
                Evolution = null,
            };
            var pidgeotto = new Pokemon()
            {
                Id = 17,
                Name = "Pidgeotto",
                PokemonTypes = new List<PokemonType>() { normal, flying },
                Evolution = new Evolution()
                {
                    Level = 36,
                    Pokemon = pidgeot,
                },
            };
            var pidgey = new Pokemon()
            {
                Id = 16,
                Name = "Pidgey",
                PokemonTypes = new List<PokemonType>() { normal, flying },
                Evolution = new Evolution()
                {
                    Level = 18,
                    Pokemon = pidgeotto,
                },
            };


            var pokemon = new List<Pokemon>() 
            { 
                bulbasaur, ivysaur, venosaur, 
                charmander, charmeleon, charizard,
                squirtle, wartortle, blastoise,
                caterpie, metapod, butterfree,
                weedle, kakuna, beedrill,
                pidgey, pidgeotto, pidgeot

            };
            context.Pokemon.AddRange(pokemon);

            context.SaveChanges();
        }
    }
}
