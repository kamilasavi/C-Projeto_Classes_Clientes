using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Clientes
{
    internal class Cliente
    {
        private string nome;
        private string endereco;
        private string contato;
        private double limiteCredito;
        private double numeroCartao;
        private string status;
        DateTime dataNasc;

        //Método Construtor
        public Cliente()
        {
            this.nome = "";
            this.endereco = "";
            this.contato = "";
            this.limiteCredito = 0;
            this.numeroCartao = 0;
            dataNasc = DateTime.Today; //inicializa com a data de hoje
        }
        //Método SET'S
        public void setNome(string paramNome)
        {
            this.nome = paramNome;
        }
        public void setEndereco(string paramEndereco)
        {
            this.endereco = paramEndereco;
        }
        public void setContato(string paramContato)
        {
            this.contato = paramContato;
        }
        public void setLimiteCredito(double paramLimiteCredito)
        {
            this.limiteCredito = paramLimiteCredito;
        }
        public void setNumeroCartao(double paramNumeroCartao)
        {
            this.numeroCartao = paramNumeroCartao;
        }
        public void setDataNasc(DateTime paramDataNasc)
        {
            this.dataNasc = paramDataNasc;
        }
        //Método GET'S
        public string getNome()
        {
            return this.nome;
        }
        public string getEndereco()
        {
            return this.endereco;
        }
        public string getContato()
        {
            return this.contato;
        }
        public double getLimiteCredito()
        {
            return this.limiteCredito;
        }
        public double getNumeroCartao()
        {
            return this.numeroCartao;
        }
        public string getStatus()
        {
            return this.status;
        }
        public DateTime getDataNasc()
        {
            return this.dataNasc;
        }
        //*****************************
        //Método para verificar limite de crédito
        public void verificaLimite()
        {
            if (this.limiteCredito < 1000)
            {
                this.status = "Bloqueado";
            }
            else
            {
                this.status = "Liberado";
            }
        }

    }
}
