using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoTeste.Model;

namespace ProjetoTeste.Services.Implementations
{
    public class PessoaServiceImplementation
    {

        private volatile int count;

        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }


        public void Delete(long id)
        {

        }


        public List<Pessoa> FindAll()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            for (int i = 0; i < 8; i++)
            {
                Pessoa pessoa = MockPessoa(i);
                pessoas.Add(pessoa);
            }
            return pessoas;
        }


        public Pessoa FindByID(long id)
        {
            return new Pessoa
            {
                Id = IncrementAndGet(),
                Nome = "Leandro",
                Sobrenome = "Costa",
                Endereco = "Uberlandia - Minas Gerais - Brasil",
                Genero = "Male"
            };
        }


        public Pessoa Update(Pessoa pessoa)
        {
            return pessoa;
        }

        private Pessoa MockPessoa(int i)
        {
            return new Pessoa
            {
                Id = IncrementAndGet(),
                Nome = "Pessoa Nome" + i,
                Sobrenome = "Pessoa Sobrenome" + i,
                Endereco = "Some Endereco" + i,
                Genero = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

    }

    internal class Interlocked
    {
        internal static long Increment(ref int count)
        {
            throw new NotImplementedException();
        }
    }

    internal class pessoas
    {
        internal static void Add(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }
    }
}
