using System;
using System.Collections.Generic;


namespace Comercialon.Classes
{
    public class Cliente
    {
        //declaração de propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        // métodos construtores
        public Cliente(){ Id = 0; }
        
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
