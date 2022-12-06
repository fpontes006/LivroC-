using System;
using Xunit;

namespace loja.Tests;

public class DescontoTest
{
    [Fact]
    public void Quando_o_produto_eh_vermelho_o_desconto_eh_de_10_porcento()
    {
        //Preparar
        var desconto = new Desconto();

        //Executar
        var valor = desconto.Calcule(Cor.Vermelho);

        //Verificar
        Assert.Equal(10,valor);
    }

    [Fact]
    public void Quando_o_produto_eh_verde_o_desconto_eh_de_20_porcento()
    {
        //preparar
        var desconto = new Desconto();

        //Executar
        var valor = desconto.Calcule(Cor.Verde);

        //Verificar
        Assert.Equal(20,valor);
    }

    [Fact]
    public void Quando_o_produto_eh_Azul_o_desconto_eh_de_20_porcento()
    {
        // Given
        var desconto = new Desconto();
    
        // When
        var valor = desconto.Calcule(Cor.Azul);
    
        // Then
        Assert.Equal(30,valor);
    }

    [Fact]

    public void Quando_o_produto_eh_Laranja_o_desconto_eh_de_0_porcento()
    {
        // Given
        var desconto = new Desconto();

        // When
        var valor = desconto.Calcule(Cor.Laranja);

        //Then
        Assert.Equal(0,valor);
    }
}