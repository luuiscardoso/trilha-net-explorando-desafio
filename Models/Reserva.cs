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
            if (DiasReservados > Suite.Capacidade)
            {
                throw new InvalidOperationException("A quantidade de hospede não pode ser maior que a capacidade da suite.");
            }
            else
            {
                Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria; ;

            if (DiasReservados >= 10)
            {
                 valorDiaria *= 0.1;
            }

            return valorDiaria;
        }
    }
}