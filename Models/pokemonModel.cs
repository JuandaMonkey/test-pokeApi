using test_pokeApi.Models;

namespace test_pokeApi.Models
{

    /* modelo base del pokémon */
    public class pokemonModel
    {

        /* id pokémon */
        public string? id { get; set; }
        /* nombre pokémon */
        public string? name { get; set; }
        /* url pokémon */
        public string? url { get; set; }
        /* sprite pokémon */
        public sprites? sprites { get; set; }
        /* tipo pokémon*/
        public IList<types>? types { get; set; }
        /* movimientos pokémon */
        public IList<moves> moves { get; set; }

    }

    /* sprite pokémon */
    public class sprites
    {

        /* foto default pokémon */
        public string? front_default { get; set; }
        /* foto shiny pokémon */
        public string? front_shiny { get; set; }
    }

    /* tipos pokémon */
    public class types
    {

        /* slot tipo pokémon */
        public string? slot { get; set; }
        /* tipo pokémon */
        public type? type { get; set; }

    }

    /* tipo pokémon */
    public class type
    {

        /* nombre tipo pokémon */
        public string? name { get; set; }

    }

    /* movimientos pokémon */
    public class moves
    {

        /* movimientos pokémon */
        public move? move { get; set; }

    }

    /* movimineot pokémon */
    public class move
    {

        public string? name { get; set; }

    }

}
