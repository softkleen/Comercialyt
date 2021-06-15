using System;
using System.Collections.Generic;


namespace Comercialon.Classes
{
    public class Cliente
    {
        //declaração de atributo
        public int Id { get; set; }
        public string Nome { get; set; }
        // métodos construtores
        public Cliente()
        {
        }
        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public Cliente(string nome)
        {
            Nome = nome;
        }
        // métodos da classe
        public void Inserir() 
        { }
        public bool Alterar(int id) 
        {
            return true;
        }
        public static List<Cliente> ListarTodos() 
        {
            List<Cliente> lista = new List<Cliente>();
            // code de listar ...
            return lista;
        }
        public void BuscarPorId(int id) 
        { 
            
        }
    }
}
