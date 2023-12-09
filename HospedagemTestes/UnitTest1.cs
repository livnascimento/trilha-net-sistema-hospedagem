namespace HospedagemTestes;

public class UnitTest1
{
    [Fact]
    public void DeveRetornarQuantidaCorretaDeHospedes()
    {
        // Arrange
        List<Pessoa> hospedes =
        [
            new Pessoa(nome: "Hóspede 1"),
            new Pessoa(nome: "Hóspede 2")
        ];

        Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        Reserva reserva = new(diasReservados: 5);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Act
        int quantidadeHospedes = reserva.ObterQuantidadeHospedes();

        // Assert
        Assert.Equal(2, quantidadeHospedes);
    }
    [Fact]
    public void DeveRetornarExceptionLimiteDeHospedes()
    {
        // Arrange
        List<Pessoa> hospedes =
        [
            new Pessoa(nome: "Hóspede 1"),
            new Pessoa(nome: "Hóspede 2"),
            new Pessoa(nome: "Hóspede 3")
        ];

        Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        Reserva reserva = new(diasReservados: 5);
        reserva.CadastrarSuite(suite);

        // Act & Assert
        Assert.Throws<Exception>(() => reserva.CadastrarHospedes(hospedes));
    }
    [Fact]
    public void DeveCalcularValorDiarioCorreto()
    {
        List<Pessoa> hospedes =
        [
            new Pessoa(nome: "Hóspede 1"),
            new Pessoa(nome: "Hóspede 2"),
            new Pessoa(nome: "Hóspede 3"),
            new Pessoa(nome: "Hóspede 4")
        ];
        
        Suite suite = new(tipoSuite: "Premium", capacidade: 4, valorDiaria: 100);

        Reserva reserva = new(diasReservados: 10);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Act
        decimal diaria = reserva.CalcularValorDiaria();

        // Assert
        Assert.Equal(900, diaria);
    }
}