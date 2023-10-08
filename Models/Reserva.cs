namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
                // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            try
            {
                if (Suite.Capacidade >= hospedes.Count)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                    throw new InvalidOperationException("Capacidade da suite " + Suite.TipoSuite.ToUpper() + " excedida em " + (hospedes.Count - Suite.Capacidade) + " hósped" + ((hospedes.Count - Suite.Capacidade) > 1 ? "es" : "e") + "!");
                }
            }
            catch (InvalidOperationException Ex)
            {
                Console.WriteLine("\n * PROBLEMA: " + Ex.Message + "\n");
            }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
           try 
                {
                return Hospedes.Count();
                }
           catch (ArgumentNullException)
                {
                return 0;
                }
           
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da Estadia
            // Cálculo: DiasReservados X Suite.ValorDiaria
       
                decimal valor = DiasReservados*Suite.ValorDiaria;

                    // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
                    if (DiasReservados >= 10 )
                    {
                        valor = valor * 0.9m;
                    }
                return valor;
        }
    }
}