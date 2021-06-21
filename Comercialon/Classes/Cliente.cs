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
        public List<Endereco> Endereco { get; set; }
        public bool Ativo { get; set; }

        // métodos construtores
        /// <summary>
        /// inicializa uma nova instância da Classe
        /// Cliente
        /// </summary>
        public Cliente(){ Id = 0; }

        public Cliente(string nome, string cpf, string email, string telefone, bool ativo=true, List<Endereco> endereco=null)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }

        public Cliente(int id, string nome, string cpf, string email, string telefone, bool ativo = true,List<Endereco> endereco=null)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }


        // métodos da classe
        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            //inserir usando concatenações
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert clientes " +
                "(nome, cpf, email, telefone, ativo) " +
                "values('"+Nome+"', '"+Cpf+"', '"+Email+"', '"+Telefone+"', default); ";
            cmd.ExecuteNonQuery();//
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }
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
