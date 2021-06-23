using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercialon.Classes
{
    public class Endereco
    {
        private readonly int idCliente;
        public int IdCliente { get { return idCliente; } }
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

        public Endereco(int idCliente, string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string estado, string siglaEstado, string tipo)
        {
            this.idCliente = idCliente;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            SiglaEstado = siglaEstado;
            Tipo = tipo;
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
        public void Inserir(int idCliente) 
        {
            string query = "insert enderecos values(" +
                idCliente+", " +
                "'"+Cep+"', " +
                "'"+Logradouro+"'," +
                "'"+Numero+"', " +
                "'"+Complemento+"'," +
                "'"+Bairro+"', " +
                "'"+Cidade+"'," +
                "'"+Estado+"'," +
                "'"+SiglaEstado+"'," +
                "'"+Tipo+"')";
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id do cliente na tabela endereço. Use 0 se quiser listar todos com limite de resultados</param>
        /// <param name="incial">Valor incial da base de consulta. Zero é o valor padrão</param>
        /// <param name="limit">Número de registros por consulta.</param>
        /// <returns></returns>
        public static List<Endereco> ListaEnderecos(int id=0, int inicial=0, int limit = 0)
        {
            List<Endereco> lista = new List<Endereco>();
            string query = "";
            if (id > 0)
            {
                query = "select * from enderecos where Clientes_id = " + id;
            }
            else if (limit >= 0 && inicial >=0)
            {
                query = "select * from enderecos limit " + inicial + "," + limit;
            }
            var cmd = Banco.Abrir(); 
            cmd.CommandText = query;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Endereco(
                    dr.GetInt32(0),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(1),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9)
                    ));
            }
            return lista;
        }
    }
}
