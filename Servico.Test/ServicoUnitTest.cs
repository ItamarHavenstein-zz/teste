using System.Collections.Generic;
using Dominio;
using NUnit.Framework;

namespace Servico
{
    public class ServicoTest
    {
        private readonly Separacao _separar;

        public ServicoTest()
        {
            _separar = new Separacao();
        }

        [Test]
        public void UmProduto()
        {
            List<Registro> produtos = new List<Registro>();

            var result = _separar.SeparaProdutos(produtos);

            Assert.AreEqual(result.Count,1 );
        }
    }
}