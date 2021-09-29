using System;

namespace api_catalogojogos.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException() : base("Este jogo já está cadastrado") { }
    }
}
