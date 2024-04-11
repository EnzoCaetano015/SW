using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    internal class Pessoa
    {
        private string? Nome { get; set; }
        private DateTime Nascimento { get; set; }
        private Double Altura { get; set; }

        private int Idade { get; set; }
        public string Info()
        {
            Nome = "Enzo Caetano";
            Nascimento =  new DateTime(2007, 11, 24, 11,30,00);
            Altura = Convert.ToDouble(1.73);

            return $"Nome: {Nome}\nNAscimento: {Nascimento}\nAltura: {Altura}";
        }

        public string Calcularidade()
        {
            int Ano = 2024;
            Idade = Ano - Nascimento.Year;


            return $"Idade: {Idade}";

        }


    }
}
