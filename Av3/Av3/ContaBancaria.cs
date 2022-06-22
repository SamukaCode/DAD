using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Av3
{
    public class contaBancaria
    {
        private String codigoConta;
        private int tipo; //0 = simples; 1 = especial
        private double saldo;
        private double limite;

        public contaBancaria()
        {
        }

        public contaBancaria(string codigoConta, int tipo, double saldo, double limite)
        {
            this.codigoConta = codigoConta;
            this.tipo = tipo;
            this.saldo = saldo;
            this.limite = limite;
        }

        public int Tipo { get => tipo; set => tipo = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Limite { get => limite; set => limite = value; }
        public string CodigoConta { get => codigoConta; set => codigoConta = value; }

        public static List<contaBancaria> geraContas()
        {
            List<contaBancaria> _listContas = new List<contaBancaria>();
            _listContas.Add(new contaBancaria("1-123", 0, 1000, 0));
            _listContas.Add(new contaBancaria("1-321", 0, 5500, 0));
            _listContas.Add(new contaBancaria("2-500", 1, 58900, 1500));
            _listContas.Add(new contaBancaria("2-501", 1, 103400, 3500));
            return _listContas;
        }
    }

}
