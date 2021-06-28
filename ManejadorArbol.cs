using System;
using System.Linq;//libreria que hay que poner para usar (Any)


namespace Arbol12
{
    class ManejadorArbol
    {
        //Metodo recursivo, por que se llama asi mismo
        internal string ImrprimirArbolInfijo(Nodo nodo)
        {
            //analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //Analizo cuando no soy hoja
            return $"( {ImrprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor}  {ImrprimirArbolInfijo(nodo.Hijos[1])} )";
        }

        internal string ImrprimirArbolPrefijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            //Analizo cuando no soy hoja
            return $"{nodo.Valor} ( {ImrprimirArbolPrefijo(nodo.Hijos[0])} {ImrprimirArbolPrefijo(nodo.Hijos[1])} )";
            // un arbol que siempre va a ser binario
        }

        internal string ImrprimirArbolPostfijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            //Analizo cuando no soy hoja
            return $"( {ImrprimirArbolPostfijo(nodo.Hijos[0])} {ImrprimirArbolPostfijo(nodo.Hijos[1])} {nodo.Valor} )";

        }

        internal string ImpresionDivision(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor2;
            //Analizo cuando no soy hoja
            return $"( {ImpresionDivision(nodo.Hijos[0])} {nodo.Valor2}  {ImpresionDivision(nodo.Hijos[1])} )";
        }
        internal string ImpresionSumaBin(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor3;
            //Analizo cuando no soy hoja
            return $"( {ImpresionSumaBin(nodo.Hijos[0])} {nodo.Valor3}  {ImpresionSumaBin(nodo.Hijos[1])} )";
        }
        internal string ImprimirArbol(Nodo nodo, Notacion notacion)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            switch (notacion)
            {
                case Notacion.Infijo:
                    return $"( {ImrprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor}  {ImrprimirArbolInfijo(nodo.Hijos[1])} )";
                case Notacion.Prefijo:
                    return $"{nodo.Valor} ( {ImrprimirArbolPrefijo(nodo.Hijos[0])} {ImrprimirArbolPrefijo(nodo.Hijos[1])} )";
                case Notacion.Postfijo:
                    return $"( {ImrprimirArbolPostfijo(nodo.Hijos[0])} {ImrprimirArbolPostfijo(nodo.Hijos[1])} {nodo.Valor} )";
                case Notacion.Num:
                    return $"( {ImpresionDivision(nodo.Hijos[0])} {nodo.Valor2}  {ImpresionDivision(nodo.Hijos[1])} )";
                case Notacion.Bin:
                    return $"( {ImpresionSumaBin(nodo.Hijos[0])} {nodo.Valor3}  {ImpresionSumaBin(nodo.Hijos[1])} )";
                //define el valor default si no se implementa ningun dato a los case
                default:
                    return "Tipo de notacion no implementada";

            };
        }
        internal int HojasNumero(Nodo nodo)
        {
            if (NumHoja(nodo))
                return 1;
            int totalSumaHojas = 0;
            foreach (var hijosActualesImp in nodo.Hijos)
            {
                totalSumaHojas += HojasNumero(hijosActualesImp);//imprime el total de hojas
            }
            return totalSumaHojas;//devuelve al programa el valor total
        }

        internal int NumeroNodo(Nodo nodo)
        {
            if (NumHoja(nodo))
                return 1;
            int SumaNodos = 0;
            foreach (var nodosActuales in nodo.Hijos)
            {
                SumaNodos += NumeroNodo(nodosActuales);
            }
            return SumaNodos + 1;

        }

        internal int NivelesNumero(Nodo nodo, int nivel)
        {
            if (nodo == null)
                return 0;
            nivel++;
            foreach (var nodosActuales in nodo.Hijos)
            {
                var nivelActual = NivelesNumero(nodosActuales, nivel);
                if (nivel < nivelActual)
                    nivel = nivelActual;

            }
            return nivel;
        }

        private bool NumHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }
    }
}
