using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Cliente
    {
        private string nome;
        private int idade;
        private string endereço;
        private string compras;
        private decimal valorGasto;

        public Cliente(string nome, int idade, string endereço, string compras, decimal valorGasto)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereço = endereço;
            this.compras = compras;
            this.valorGasto = valorGasto;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public string GetEndereço()
        {
            return endereço;
        }

        public void SetEndereço(string endereço)
        {
            this.endereço = endereço;
        }

        public string GetCompras()
        {
            return compras;
        }

        public void SetCompras(string compras)
        {
            this.compras = compras;
        }

        public decimal GetValorGasto()
        {
            return valorGasto;
        }

        public void SetValorGasto(decimal valorGasto)
        {
            this.valorGasto = valorGasto;
        }

        public void Visualizar()
        {
            Console.WriteLine($"Nome do Cliente: {this.nome}");
            Console.WriteLine($"Idade do Cliente: {this.idade}");
            Console.WriteLine($"Endereço do Cliente: {this.endereço}");
            Console.WriteLine($"Compras do Cliente: {this.compras}");
            Console.WriteLine($"Valor das compras do Cliente: {this.valorGasto}");
        }
    }
}
