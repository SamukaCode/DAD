using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanSystem
{
    class Conta
    {
        private int id;
        private string nome;
        private string descricao;
        private int categoria;
        private int status;
        private List<Conta> _lstConta = new List<Conta>();

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Status { get => status; set => status = value; }

        public Conta()
        {
        }

        public Conta(int id, string nome, string descricao, int categoria, int status)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Categoria = categoria;
            this.Status = status;
        }

        public List<Conta> ToList()
        {
            return _lstConta;
        }

        public List<Conta> GeraContas()
        {
            Conta _cnt1 = new Conta(1, "Salário", "Salário da UNICAMP", 1, 1);
            Conta _cnt2 = new Conta(2, "Combustível", "Despesas com combustível", 2, 1);
            _lstConta.Add(_cnt1);
            _lstConta.Add(_cnt2);
            return _lstConta;
        }

        public void AddToList(int id, string nome, string descricao, int categoria, int status)
        {
            _lstConta.Add(new Conta(id, nome, descricao, categoria, status));
        }
    }
}
