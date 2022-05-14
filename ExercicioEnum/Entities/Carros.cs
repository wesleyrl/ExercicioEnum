using System;
using System.Collections.Generic;
using System.Text;
using ExercicioEnum.Entities.Enums;

namespace ExercicioEnum.Entities
{
    class Carros
    {
        //cor, tipo do cambio, tipo de combustível, ano, modelo e marca
        public string Cor;
        public TipoCambio CambioTipo { get; set; }

        public TipoCombustivel CombustivelTipo { get; set; }

        public string Ano { get; set; }

        public TipoModelo ModeloTipo { get; set; }

        public string Marca { get; set; }


        public Carros(string cor, string ano)
        {
            Cor = cor;
            Ano = ano;
        }


        public void Cambio(int opt)
        {
            CambioTipo = (TipoCambio)opt;
        }

        public void Combustivel(int opt)
        {
            CombustivelTipo = (TipoCombustivel)opt;
        }

        public void Modelo(int opt)
        {
            ModeloTipo = (TipoModelo)opt;
        }

        public override string ToString()
        {
            return $"Cor: {Cor} Tipo de cambio: {CambioTipo} Tipo de combustivel: {CombustivelTipo} Ano: {Ano} Modelo: {ModeloTipo}";
        }

    }
}
