﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Topicos.Utilitarios
{
    public class MiCarton : ICarton
    {

        private const int _dimension = 5;
        //int[,] elCarton = new int[5, 5];

        private int[,] _elCarton = new int[_dimension, _dimension];

        public int[,] Carton
        {
            get { return _elCarton; }
            set {  }
        }
        private int EsquinaSuperiorIzquierda()
        {
            return Carton[0, 0];
        }
        private int EsquinaSuperiorDerecha()
        {
            return Carton[0, _dimension -1];
        }
        private int EsquinaInferiorIzquierda()
        {
            return Carton[_dimension-1, 0];
        }
        private int EsquinaInferiorDerecha()
        {
            return Carton[_dimension -1, _dimension - 1];
        }


        private int Posicion(int i, int j)
        {
            if (i < _dimension && j < _dimension)
                return Carton[i, j];
            else
                throw new IndexOutOfRangeException(string.Format("Error al consultar la posicion [{0}, {1}]"
                    , i.ToString(), j.ToString()));
        }

        public bool AlgunaColumnaCompleta(IList<int> laLisaDeNumerosJugados)
        {
            
            //hHacer Este
            throw new NotImplementedException();
        }

        public bool AlgunaFilaCompleta(IList<int> laLisaDeNumerosJugados)
        {
            
            //Hacer este
            throw new NotImplementedException();
        }

        public bool ContienePatron(IList<int> laLisaDeNumerosJugados, int[,] elPatronDeJuegoDeseado)
        {
            
            //Hacer este
            throw new NotImplementedException();
        }

        public bool ContieneUnNumero(int elNumero)
        {
            var elResultado = false;
            for (int i = 0; !elResultado && i < _dimension; i++)
            {
                for (int j= 0; !elResultado && j < _dimension; j++)
                {
                    elResultado = Carton[i, j] == elNumero;
                }

            }

            return elResultado;
        }

        public bool CuatroEsquinas(IList<int> laLisaDeNumerosJugados)
        {
            var elResultado = false;
            elResultado = (laLisaDeNumerosJugados.Contains(EsquinaInferiorIzquierda())
                && laLisaDeNumerosJugados.Contains(EsquinaInferiorDerecha())
                && laLisaDeNumerosJugados.Contains(EsquinaSuperiorIzquierda())
                && laLisaDeNumerosJugados.Contains(EsquinaSuperiorDerecha()));
            return elResultado;
    
        }

        public int[,] Inicializar()
        {
            //hacer este
            throw new NotImplementedException();
        }

        public bool LetraX(IList<int> laLisaDeNumerosJugados)
        {
            //Hacer este
            throw new NotImplementedException();
        }

        public void ReflejarNumeroQueHaSalido(int elNumeroQueSalio)
        {
            //Hacer este
            throw new NotImplementedException();
        }
    }
}
