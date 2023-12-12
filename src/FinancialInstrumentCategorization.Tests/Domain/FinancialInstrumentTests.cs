// FinancialInstrumentTests.cs

using System;
using Xunit;
using FinancialInstrumentCategorization.Domain;

namespace FinancialInstrumentCategorization.Tests.Domain
{
    /// <summary>
    /// Testes para a classe FinancialInstrument.
    /// </summary>
    public class FinancialInstrumentTests
    {
        // Teste para verificar se é possível criar uma instância da classe FinancialInstrument
        [Fact]
        public void PodeCriarInstrumentoFinanceiro()
        {
            // Arrange & Act
            var instrument = new FinancialInstrument(1000000, "Stock");

            // Assert
            Assert.NotNull(instrument);
        }

        // Teste para garantir que o construtor valida o valor de mercado não negativo
        [Fact]
        public void ConstrutorDeveValidarValorDeMercadoNaoNegativo()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new FinancialInstrument(-1000000, "Stock"));
        }

        // Teste para garantir que o construtor valida a especificação do tipo
        [Fact]
        public void ConstrutorDeveValidarEspecificacaoDoTipo()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new FinancialInstrument(1000000, string.Empty));
        }

        // Adicione mais testes conforme necessário para outros cenários ou validações
    }
}
