using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Produto
    {
        /* categoria (acessorio, jogo, console e etc)
            valor
            nome
            status (novo, semi-novo, usado e etc)
            raridade (comum, raro, ultra-raro) */
        private string nome;
        private int categoria;
        private int raridade;
        private int status;
        private decimal valor;

        public Produto(string nome, int categoria, int raridade, int status, decimal valor)
        {
            this.nome = nome;
            this.categoria = categoria;
            this.raridade = raridade;
            this.status = status;
            this.valor = valor;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetCategoria()
        {
            return categoria;
        }

        public void SetCategoria(int categoria)
        {
            this.categoria = categoria;
        }

        public int GetRaridade()
        {
            return raridade;
        }

        public void SetRarirade(int raridade)
        {
            this.raridade = raridade;
        }

        public int GetStatus()
        {
            return status;
        }

        public void SetStatus(int status)
        {
            this.status = status;
        }

        public decimal GetValor()
        {
            return valor;
        }

        public void SetValor(decimal valor)
        {
            this.valor = valor;
        }

        public void Visualizar()
        {
            string categoria = string.Empty;
            switch (this.categoria)
            {
                case 1:
                    categoria = "Jogo";
                    break;
                case 2:
                    categoria = "Console";
                    break;
                case 3:
                    categoria = "Acessório";
                    break;
            }
            string raridade = string.Empty;
            switch (this.raridade)
            {
                case 1:
                    raridade = "Comum";
                    break;
                case 2:
                    raridade = "Raro";
                    break;
                case 3:
                    raridade = "Ultra-Raro";
                    break;
            }
            string status = string.Empty;
            switch (this.status)
            {
                case 1:
                    status = "Novo";
                    break;
                case 2:
                    status = "Semi-novo";
                    break;
                case 3:
                    status = "Usado";
                    break;
            }
            Console.WriteLine("*********************************************");
            Console.WriteLine("               Dados do Produto              ");
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Nome do produto: {this.nome}");
            Console.WriteLine($"Categoria do produto: {categoria}");
            Console.WriteLine($"Raridade do produto: {raridade}");
            Console.WriteLine($"Status do produto: {status}");
            Console.WriteLine($"Valor do produto: {this.valor.ToString(format: "C")}");
            Console.WriteLine("                                             ");
            Console.WriteLine("                                             ");
        }
    }
}
