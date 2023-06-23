using System;

namespace Sistema.Entidades
{
    public class UsuarioEnt
    {
        private int id;
        private string nome;
        public string usuario;
        private string senha;

        public int Id { get =>id; set=>id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public string Senha { get => senha; set => senha = value; }


    }
}
