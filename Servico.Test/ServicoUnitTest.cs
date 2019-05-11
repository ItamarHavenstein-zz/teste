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
            var result = _separar.SeparaProdutos();

            Assert.AreEqual(result.Count,1 );
        }
    }
}