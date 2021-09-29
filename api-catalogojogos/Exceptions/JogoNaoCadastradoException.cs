using System;

namespace api_catalogojogos.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException() : base("Este jogo não está cadastrado"){ }
    }
}
