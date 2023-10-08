using System.Data.Common;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "José");
Pessoa p2 = new Pessoa(nome: "Maria");
Pessoa p3 = new Pessoa(nome: "Pedro");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 100);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
if (reserva.ObterQuantidadeHospedes()>0)
{
Console.WriteLine($"\n - Número de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"\n - Valor da Estadia: {reserva.CalcularValorDiaria().ToString("C")} para {reserva.DiasReservados} diária(s)\n");
}