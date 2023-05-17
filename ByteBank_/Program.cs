using ByteBank_.ContaBanco;
using ByteBank_.Titular;

ContaCorrente conta = new ContaCorrente(1000,"19");

conta.DefinirSaldo(1500);

conta.Depositar(700);

Console.WriteLine(conta.ObterSaldo());

if (conta.Sacar(2300) == true)
{
    Console.WriteLine(conta.ObterSaldo());
}
else 
{ 
    Console.WriteLine("O saldo na conta é insuficiente.");
}

PessoaFisica Luiz = new PessoaFisica("Luiz B", "049.461.150-21","Programador");
conta.Titular = Luiz;

Console.WriteLine("Nome: "+conta.Titular.Nome);
Console.WriteLine("CPF: "+ conta.Titular.CPF);

ContaCorrente conta2 = new ContaCorrente(190, "15");
PessoaFisica henrique = new PessoaFisica("Henrique", "904.614.132.21", "Engenheiro");

ContaCorrente conta3 = new ContaCorrente(190, "15");
PessoaFisica claudio = new PessoaFisica("Claudio", "421.555.321.21", "Mecânico");

Console.WriteLine(ContaCorrente.totalContasCriadas);