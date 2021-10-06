using System;

namespace Cadastro
{
    public class Serie : EntidadeBase
    {
        //Atributos

        private Genero Genero { get; set; }
        private string Título { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido {get; set;}

        //Metodos

        public Serie (int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Título = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString()
        {
            //environment.new line pula uma linha independente do sistema operacional, substituindo /n por exemplo
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Título + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Título;
        }

        public int retornaId()
        {
            return this.Id;
        }

        //Nao excluimos diretamente, esse metodo fornece a informacao do booleano q define tal status
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

         public void Excluir()
        {
            this.Excluido = true;
        }

    }
}