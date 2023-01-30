namespace DesafioProjetoHospedagem.Models;

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
        if (hospedes.Count <= this.Suite.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new System.Exception("A quantidade de hóspedes é maior que a capacidade da suíte");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return this.Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = this.Suite.ValorDiaria * this.DiasReservados;

        if (this.DiasReservados >= 10)
        {
            double valorDescontado = (double)valor * 0.1;
            valor = valor - Decimal.Parse(valorDescontado.ToString());
        }

        return valor;
    }
}
