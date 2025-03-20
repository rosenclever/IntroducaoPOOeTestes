using Financeiro.Model;

namespace TesteFinanceiro
{
    [TestClass]
    public class TestConta
    {
        [TestMethod]
        public void TestDeposito()
        {
            //cenario
            Conta conta1 = new Conta(123456, 10);
            decimal valorDepositado = 100;
            decimal saldoEsperado = 110;

            //ação
            conta1.Depositar(valorDepositado);

            //validação
            Assert.AreEqual(saldoEsperado, conta1.Saldo);
        }
    }
}
