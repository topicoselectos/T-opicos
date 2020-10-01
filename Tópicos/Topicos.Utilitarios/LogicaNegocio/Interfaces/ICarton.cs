using System;
using System.Collections.Generic;
using System.Text;

namespace Topicos.Utilitarios
{
    public interface ICarton
    {

        //int[,] elCarton = new int[5, 5];

        public int[,] Inicializar();

        /// <summary>
        /// Este Metodo verifica si un numero esta dentro de un carton
        /// </summary>
        /// <param name="elNumero">el número a buscar en el carton</param>
        /// <returns></returns>

        public bool ContieneUnNumero(int elNumero);

        /// <summary>
        /// Verifica si las cautro esquinas del carton ya han salido
        /// </summary>
        /// <returns></returns>
        
        
        public bool CuatroEsquinas(IList<int> laLisaDeNumerosJugados);

        /// <summary>
        /// Verifica si alguna de las filas del carton se han completado
        /// de acuerdo con las lista de numeros que se han jugado
        /// </summary>
        /// <returns></returns>
        public bool AlgunaFilaCompleta(IList<int> laLisaDeNumerosJugados);
        /// <summary>
        /// Verifica si alguna de las columnas del cartono se han completado
        /// de acuerdo con las lista de numeros que se han jugado
        /// </summary>
        /// <returns></returns>
        public bool AlgunaColumnaCompleta(IList<int> laLisaDeNumerosJugados);


        /// <summary>
        /// Verifica si las posiciones del carton que forman la letra x ya han salido
        /// </summary>
        /// <param name="laLisaDeNumerosJugados">Una lista con todos los numeros que han salido en el juego</param>
        /// <returns></returns>
        public bool LetraX(IList<int> laLisaDeNumerosJugados);

        /// <summary>
        /// Este Método recibe una lista de numeros que han salido y un patron que desea verificar
        /// si cumple el carton para verifficar si ganó.
        /// </summary>
        /// <param name="laLisaDeNumerosJugados">Una lista con todos los numeros que han salido en el juego</param>
        /// <param name="elPatronDeJuegoDeseado">una matriz de 5x5 donde cada osicion
        /// indica mediante un 0 o algo distinito a 0 si una determinadad posicion del carton
        /// se debe tener. </param>
        /// <returns></returns>
        public bool ContienePatron(IList<int> laLisaDeNumerosJugados, int [,]
            elPatronDeJuegoDeseado);

        //   1  1  1  1  1
        //   1  0  0  0  1
        //   1  1  1  1  1
        //   1  0  0  0  1
        //   1  0  0  0  1

        /// <summary>
        /// Le informa al carton que un numero ha salido.
        /// </summary>
        /// <param name="elNumeroQueSalio"></param>
        public void ReflejarNumeroQueHaSalido(int elNumeroQueSalio);


    }
}
