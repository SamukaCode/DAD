using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSystem
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public int Status { get; set; }

        private List<Categoria> _lstCategoria = new List<Categoria>();

        public Categoria()
        {
        }

        public Categoria(int id, string nome, string descricao, int tipo, int status)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Tipo = tipo;
            Status = status;
        }

        public List<Categoria> ToList()
        {
            return _lstCategoria;
        }

        public List<Categoria> GeraCategorias()
        {
            Categoria _cat1 = new Categoria(1, "Salário", "Salário da UNICAMP", 1, 1);
            Categoria _cat2 = new Categoria(2, "Combustível", "Despesas com combustível", 2, 1);
            _lstCategoria.Add(_cat1);
            _lstCategoria.Add(_cat2);
            return _lstCategoria;
        }

        public void AddToList(int id, string nome, string descricao, int tipo, int status)
        {
            _lstCategoria.Add(new Categoria(id, nome, descricao, tipo, status));
        }
        
    }
}
