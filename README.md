<img src="https://hermes.dio.me/tracks/169e3d0f-263a-4efb-86c5-244bdf1ce8d6.png" width=100>
<br>
<br>

# Sistema de Hospedagem

## Descrição

Este desafio foi proposto pela [DIO](web.dio.me) como desafio de projeto do módulo Explorando a Linguagem C# da formação .NET developer.

## Proposta

O programa deverá calcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações

1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.

2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).

3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

## Extra

Como os mentores da DIO sempre nos incentivam a ir além, decidi adicionar testes ao meu código com xUnit de acordo com as regras da proposta de desafio.