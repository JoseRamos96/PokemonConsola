using ConsoleApp1;
using System.Collections.Generic;

namespace PokemonConsole
{
    internal static class ListaPokemons
    {
        static List<Pokemon> pokemonsDisponibles = new List<Pokemon>
        {
            new Pokemon(30, TipoPokemon.fuego, "Pikachu", 1),
            new Pokemon(30, TipoPokemon.fuego, "Charmander", 1),
            new Pokemon(30, TipoPokemon.agua, "Bulbasaur", 1),
            new Pokemon(30, TipoPokemon.agua, "Squirtle", 1),
            new Pokemon(15, TipoPokemon.agua, "Pidgey", 1),
            new Pokemon(20, TipoPokemon.agua, "Machop", 1),
            new Pokemon(25, TipoPokemon.agua, "Snorlax", 1),
            new Pokemon(20, TipoPokemon.tierra, "Geodude", 1),
            new Pokemon(20, TipoPokemon.agua, "Onix", 1),
            new Pokemon(30, TipoPokemon.agua, "Hitmonlee", 1),
            new Pokemon(30, TipoPokemon.agua, "Hitmonchan", 1),
            new Pokemon(40, TipoPokemon.tierra, "Tauros", 1),
            new Pokemon(40, TipoPokemon.agua, "Mew", 1),
            new Pokemon(40, TipoPokemon.agua, "Mewtwo", 1)
        };

        public static List<Pokemon> GetPokemonsDisponibles()
        {
            return pokemonsDisponibles;
        }

    }
}
