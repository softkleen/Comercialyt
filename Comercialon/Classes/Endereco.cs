using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { set; get; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string SiglaEstado { get; set; }
        public string Tipo { get; set; }
        public Endereco()
        {
        }

        public Endereco(string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string tipo,string estado=null, string siglaEstado=null)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Tipo = tipo;
            Estado = estado;
            SiglaEstado = siglaEstado;
        }
        public static List<Endereco> ListaEnderecos(int id=0, int limit = 0)
        {
            List<Endereco> lista = new List<Endereco>();
            // codigo buscar os endereços 
            return lista;
        }
    }
}
