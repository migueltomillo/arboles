using System.Collections.Generic;

namespace Arbol12
{
    class Nodo
    {
        public int Id { get; set; }//clases y metodos definidos
        public string Valor { get; set; }
        public string Valor2 { get; set; }
        public string Valor3 { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();// lista primaria de nodos
    }
}
