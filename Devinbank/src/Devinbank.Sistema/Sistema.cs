using Devinbank.Contas.Entidades;

class Program
{
    public static void Main(string[] args)
    {
        List<Conta> contaCorrente = new();
        List<Conta> contaPoupanca = new();
        List<Conta> contaInvestimento = new();

        List<Transacoes> depositoContaCorrente = new();
        List<Transacoes> depositoContaPoupanca = new();
        List<Transacoes> depositoContaInvestimento = new();

        List<Transacoes> saqueContaCorrente = new();
        List<Transacoes> saqueContaPoupanca = new();
        List<Transacoes> saqueContaInvestimento = new();

        List<Transacoes> transfereciaContaCorrente = new();
        List<Transacoes> transfereciaContaPoupanca = new();
        List<Transacoes> transfereciaContaInvestimento = new();

        int numConta = 1234567890;

        try
        {
            while (true)
            {
                Console.WriteLine("Devinbank\n");
                Console.Write("1. Cadastrar Conta\n2. Saldo\n3. Deposito\n4. Saque\n5. Simular Juros Compostos\n6. Listar Contas\n7. Extrato\n8. Transferencia\n9. Finalizar\n\nSelecione uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("\n----------------------------------");
                    Console.Write("\n1. Cadastrar Conta Corrente\n2. Cadastrar Conta Poupança\n3. Cadastrar Conta Investimento\n\nSelecione uma opção: ");
                    string sel = Console.ReadLine();
                    if (sel == "1")
                    {
                        Console.WriteLine("\n----------------------------------");
                        numConta++;
                        Console.Write($"\nConta: {numConta}");
                        string agencia = "001";
                        Console.Write("\nAgencia: {0}", agencia);
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine();
                        Console.Write("Insira CPF: ");
                        string cpf = Console.ReadLine();
                        Console.Write("Insira endereço: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Insira renda mensal: ");
                        double renda = double.Parse(Console.ReadLine());
                        Console.Write("Insira saldo inicial: ");
                        double firstDep = double.Parse(Console.ReadLine());

                        contaCorrente.Add(new Conta(numConta, name, cpf, endereco, agencia, renda, firstDep));
                        Console.WriteLine("\nConta bancária adicionada");
                        Console.ReadLine();
                    }
                    else if (sel == "2")
                    {
                        Console.WriteLine("\n----------------------------------");
                        numConta++;
                        Console.Write($"\nConta: {numConta}");
                        string agencia = "001";
                        Console.Write("\nAgencia: {0}", agencia);
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine();
                        Console.Write("Insira CPF: ");
                        string cpf = Console.ReadLine();
                        Console.Write("Insira endereço: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Insira renda mensal: ");
                        double renda = double.Parse(Console.ReadLine());
                        Console.Write("Insira saldo inicial: ");
                        double init = double.Parse(Console.ReadLine());

                        contaPoupanca.Add(new Conta(numConta, name, cpf, endereco, agencia, renda, init));
                        Console.WriteLine("\nConta bancária adicionada");
                        Console.ReadLine();
                    }
                    else if (sel == "3")
                    {
                        Console.WriteLine("\n----------------------------------");
                        numConta++;
                        Console.Write($"\nConta: {numConta}");
                        string agencia = "001";
                        Console.Write("\nAgencia: {0}", agencia);
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine();
                        Console.Write("Insira CPF: ");
                        string cpf = Console.ReadLine();
                        Console.Write("Insira endereço: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Insira renda mensal: ");
                        double renda = double.Parse(Console.ReadLine());
                        Console.Write("Insira saldo inicial: ");
                        double init = double.Parse(Console.ReadLine());

                        contaInvestimento.Add(new Conta(numConta, name, cpf, endereco, agencia, renda, init));
                        Console.WriteLine("\nConta bancária adicionada");
                        Console.ReadLine();
                    }
                }

                else if (opcao == "2")
                {
                    Console.WriteLine("\n----------------------------------");
                    Console.Write("\nInsira nome: ");
                    string name = Console.ReadLine();

                    foreach (var i in contaCorrente)
                    {
                        if (i.name == name)
                        {
                            Console.Write("\nConta Corrente: ");
                            Console.WriteLine("\nConta: {0}\nSaldo: {1}", i.numConta, i.saldo);
                        }
                    }
                    foreach (var i in contaPoupanca)
                    {
                        if (i.name == name)
                        {
                            Console.Write("\nConta Poupanca: ");
                            Console.WriteLine("\nConta: {0}\nSaldo: {1}", i.numConta, i.saldo);
                        }
                    }
                    foreach (var i in contaInvestimento)
                    {
                        if (i.name == name)
                        {
                            Console.Write("\nConta Investimento: ");
                            Console.WriteLine("\nConta: {0}\nSaldo: {1}", i.numConta, i.saldo);
                        }
                    }
                    Console.ReadLine();
                }

                else if (opcao == "3")
                {
                    Console.WriteLine("\n----------------------------------");
                    Console.Write("\n1. Deposito Conta Corrente\n2. Deposito Conta Poupanca\n3. Deposito Conta Investimento\n\nSelecione uma opção: ");
                    string sel = Console.ReadLine();
                    if (sel == "1")
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine(), nomeAtual = null;
                        int index = -1;
                        for (int i = 0; i < contaCorrente.Count; i++)
                        {
                            if (contaCorrente[i].name == name)
                            {
                                nomeAtual = name;
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Valor a depositar: ");
                            double dep = double.Parse(Console.ReadLine());
                            contaCorrente[index].Depositar(dep);
                            string nome = contaCorrente[index].name;
                            DateTime data = DateTime.Now;
                            data.ToShortDateString();
                            depositoContaCorrente.Add(new Transacoes(nome, dep, data));
                            Console.WriteLine("\nValor depositado com sucesso");
                        }
                        else { Console.WriteLine("\nConta não encontrada"); }
                        Console.ReadLine();
                    }
                    else if (sel == "2")
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine(), nomeAtual = null;
                        int index = -1;
                        for (int i = 0; i < contaPoupanca.Count; i++)
                        {
                            if (contaPoupanca[i].name == name)
                            {
                                nomeAtual = name;
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Valor a depositar: ");
                            double dep = double.Parse(Console.ReadLine());
                            contaPoupanca[index].Depositar(dep);
                            string nome = contaPoupanca[index].name;
                            DateTime data = DateTime.Now;
                            data.ToShortDateString();
                            depositoContaPoupanca.Add(new Transacoes(nome, dep, data));
                            Console.WriteLine("\nValor depositado com sucesso");
                        }
                        else { Console.WriteLine("\nConta não encontrada"); }
                        Console.ReadLine();
                    }
                    else if (sel == "3")
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine(), noAtual = null;
                        int index = -1;
                        for (int i = 0; i < contaInvestimento.Count; i++)
                        {
                            if (contaInvestimento[i].name == name)
                            {
                                noAtual = name;
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Valor a depositar: ");
                            double dep = double.Parse(Console.ReadLine());
                            contaInvestimento[index].Depositar(dep);
                            string nome = contaInvestimento[index].name;
                            DateTime data = DateTime.Now;
                            data.ToShortDateString();
                            depositoContaInvestimento.Add(new Transacoes(nome, dep, data));
                            Console.WriteLine("\nValor depositado com sucesso");
                        }
                        else { Console.WriteLine("\nConta não encontrada"); }
                        Console.ReadLine();
                    }
                }

                else if (opcao == "4")
                {
                    Console.WriteLine("\n----------------------------------");
                    Console.Write("\n1. Saque Conta Corrente\n2. Saque Conta Poupanca\n3. Saque Conta Investimento\n\nSelecione uma opção: ");
                    string sel = Console.ReadLine();
                    if (sel == "1")
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine(), nomeAtual = null;
                        int index = -1;
                        for (int i = 0; i < contaCorrente.Count; i++)
                        {
                            if (contaCorrente[i].name == name)
                            {
                                nomeAtual = name;
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Valor à sacar: ");
                            double transacao = double.Parse(Console.ReadLine());
                            bool ok = contaCorrente[index].Sacar(transacao);
                            if (ok)
                            {
                                string nome = contaCorrente[index].name;
                                DateTime data = DateTime.Now;
                                data.ToShortDateString();
                                saqueContaCorrente.Add(new Transacoes(nome, transacao, data));
                                Console.WriteLine("\nValor retirado com sucesso");
                                if (contaCorrente[index].saldo == 0)
                                {
                                    contaCorrente[index] = null;
                                    Console.WriteLine("\nConta fechada");
                                }
                            }
                            else { Console.WriteLine("\nSaldo insuficiente"); }
                        }
                        else { Console.WriteLine("\nConta não encontrada"); }
                        Console.ReadLine();
                    }
                    else if (sel == "2")
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine(), nomeAtual = null;
                        int index = -1;
                        for (int i = 0; i < contaPoupanca.Count; i++)
                        {
                            if (contaPoupanca[i].name == name)
                            {
                                nomeAtual = name;
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Valor à sacar: ");
                            double transacao = double.Parse(Console.ReadLine());
                            bool ok = contaPoupanca[index].Sacar(transacao);
                            if (ok)
                            {
                                string nome = contaPoupanca[index].name;
                                DateTime data = DateTime.Now;
                                data.ToShortDateString();
                                saqueContaPoupanca.Add(new Transacoes(nome, transacao, data));
                                Console.WriteLine("\nValor retirado com sucesso");
                                if (contaPoupanca[index].saldo == 0)
                                {
                                    contaPoupanca[index] = null;
                                    Console.WriteLine("\nConta fechada");
                                }
                            }
                            else { Console.WriteLine("\nSaldo insuficiente"); }
                        }
                        else { Console.WriteLine("\nConta não encontrada"); }
                        Console.ReadLine();
                    }
                    else if (sel == "3")
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nInsira nome: ");
                        Console.Write("\nEnter name: ");
                        string name = Console.ReadLine(), nomeAtual = null;
                        int index = -1;
                        for (int i = 0; i < contaInvestimento.Count; i++)
                        {
                            if (contaInvestimento[i].name == name)
                            {
                                nomeAtual = name;
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Valor à sacar: ");
                            double transacao = double.Parse(Console.ReadLine());
                            bool ok = contaInvestimento[index].Sacar(transacao);
                            if (ok)
                            {
                                string nome = contaInvestimento[index].name;
                                DateTime data = DateTime.Now;
                                data.ToShortDateString();
                                saqueContaInvestimento.Add(new Transacoes(nome, transacao, data));
                                Console.WriteLine("\nValor retirado com sucesso");
                                if (contaInvestimento[index].saldo == 0)
                                {
                                    contaInvestimento[index] = null;
                                    Console.WriteLine("\nConta fechada");
                                }
                            }
                            else { Console.WriteLine("\nSaldo insuficiente"); }
                        }
                        else { Console.WriteLine("\nConta não encontrada"); }
                        Console.ReadLine();
                    }
                }

                else if (opcao == "5")
                {
                    Console.WriteLine("\n----------------------------------");
                    Console.Write("\nInsira nome: ");
                    string name = Console.ReadLine(), nomeAtual = null;
                    int index = -1;
                    for (int i = 0; i < contaPoupanca.Count; i++)
                    {
                        if (contaPoupanca[i].name == name)
                        {
                            nomeAtual = name;
                            index = i;
                        }
                    }
                    if (index != -1)
                    {
                        Console.Write("Meses de juros compostos: ");
                        int mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Saldo após {0} meses: {1:N2}", mes, contaPoupanca[index].JurosCompostos(mes));
                    }
                    else { Console.WriteLine("\nConta não encontrada"); }
                    Console.ReadLine();
                }


                else if (opcao == "6")
                {
                    foreach (var i in contaCorrente)
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nConta Corrente: ");
                        Console.WriteLine("\nConta: {0}\nAgencia: {1}\nNome: {2}\nCPF: {3}\nEndereco: {4}\nRenda Mensal: {5}\nSaldo: {6}", i.numConta, i.agencia, i.name, i.cpf, i.endereco, i.rendaMensal, i.saldo);
                    }
                    foreach (var i in contaPoupanca)
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nConta Poupanca: ");
                        Console.WriteLine("\nConta: {0}\nAgencia: {1}\nNome: {2}\nCPF: {3}\nEndereco: {4}\nRenda Mensal: {5}\nSaldo: {6}", i.numConta, i.agencia, i.name, i.cpf, i.endereco, i.rendaMensal, i.saldo);
                    }
                    foreach (var i in contaInvestimento)
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nConta Investimento: ");
                        Console.WriteLine("\nConta: {0}\nAgencia: {1}\nNome: {2}\nCPF: {3}\nEndereco: {4}\nRenda Mensal: {5}\nSaldo: {6}", i.numConta, i.agencia, i.name, i.cpf, i.endereco, i.rendaMensal, i.saldo);
                    }
                    Console.ReadLine();
                }

                else if (opcao == "7")
                {
                    Console.WriteLine("\n----------------------------------");
                    Console.Write("\nInsira nome: ");
                    string name = Console.ReadLine();
                    for (int i = 0; i < depositoContaCorrente.Count; i++)
                    {
                        if (depositoContaCorrente[i].name == name)
                        {
                            Console.WriteLine("\n----------------------------------");
                            Console.Write("\nConta Corrente: ");
                            Console.WriteLine("\nDeposito: {0}\nData: {1}", depositoContaCorrente[i].transacao, depositoContaCorrente[i].dataTransacao);
                        }
                    }
                    for (int i = 0; i < depositoContaPoupanca.Count; i++)
                    {
                        if (depositoContaPoupanca[i].name == name)
                        {
                            Console.WriteLine("\n----------------------------------");
                            Console.Write("\nConta Poupança: ");
                            Console.WriteLine("\nDeposito: {0}\nData: {1}", depositoContaPoupanca[i].transacao, depositoContaPoupanca[i].dataTransacao);
                        }
                    }
                    for (int i = 0; i < depositoContaInvestimento.Count; i++)
                    {
                        if (depositoContaInvestimento[i].name == name)
                        {
                            Console.WriteLine("\n----------------------------------");
                            Console.Write("\nConta Investimento: ");
                            Console.WriteLine("\nDeposito: {0}\nData: {1}", depositoContaInvestimento[i].transacao, depositoContaInvestimento[i].dataTransacao);
                        }
                    }
                    for (int i = 0; i < saqueContaCorrente.Count; i++)
                    {
                        if (saqueContaCorrente[i].name == name)
                        {
                            Console.WriteLine("\n----------------------------------");
                            Console.Write("\nConta Corrente: ");
                            Console.WriteLine("\nSaque: {0}\nData: {1}", saqueContaCorrente[i].transacao, saqueContaCorrente[i].dataTransacao);
                        }
                    }
                    for (int i = 0; i < saqueContaPoupanca.Count; i++)
                    {
                        if (saqueContaPoupanca[i].name == name)
                        {
                            Console.WriteLine("\n----------------------------------");
                            Console.Write("\nConta Corrente: ");
                            Console.WriteLine("\nSaque: {0}\nData: {1}", saqueContaPoupanca[i].transacao, saqueContaPoupanca[i].dataTransacao);
                        }
                    }
                    for (int i = 0; i < saqueContaInvestimento.Count; i++)
                    {
                        if (saqueContaInvestimento[i].name == name)
                        {
                            Console.WriteLine("\n----------------------------------");
                            Console.Write("\nConta Corrente: ");
                            Console.WriteLine("\nSaque: {0}\nData: {1}", saqueContaInvestimento[i].transacao, saqueContaInvestimento[i].dataTransacao);
                        }
                    }

                    for (int i = 0; i < transfereciaContaCorrente.Count; i++)
                    {
                        if (transfereciaContaCorrente[i].name == name)
                        {
                            Console.WriteLine("\n----------------------------------");
                            Console.Write("\nConta Corrente: ");
                            Console.WriteLine("\nTransferencia: {0}\nData: {1}", transfereciaContaCorrente[i].transacao, transfereciaContaCorrente[i].dataTransacao);
                        }
                    }
                    Console.ReadLine();
                }

                else if (opcao == "8")
                {
                    Console.WriteLine("\n----------------------------------");
                    Console.Write("\n1. Transferencia Conta Corrente\n2. Transferencia Conta Poupanca\n3. Transferencia Conta Investimento\n\nSelecione uma opção: ");
                    string sel = Console.ReadLine();
                    if (sel == "1")
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine(), nomeAtual = null;
                        int index = -1;
                        for (int i = 0; i < contaCorrente.Count; i++)
                        {
                            if (contaCorrente[i].name == name)
                            {
                                nomeAtual = name;
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Valor à transferir: ");
                            double transferencia = double.Parse(Console.ReadLine());
                            bool ok = contaCorrente[index].Sacar(transferencia);
                            if (ok)
                            {
                                string nome = contaCorrente[index].name;
                                DateTime data = DateTime.Now;
                                data.ToShortDateString();
                                transfereciaContaCorrente.Add(new Transacoes(nome, transferencia, data));
                                if (contaCorrente[index].saldo == 0)
                                {
                                    contaCorrente[index] = null;
                                    Console.WriteLine("\nConta fechada");
                                }
                                else
                                {
                                    Console.WriteLine("\n----------------------------------");
                                    Console.Write("\n1. Transferencia para Conta Corrente\n2. Transferencia para Conta Poupanca\n3. Transferencia para Conta Investimento\n\nSelecione uma opção: ");
                                    string se = Console.ReadLine();
                                    if (se == "1")
                                    {
                                        Console.WriteLine("\n----------------------------------");
                                        Console.Write("\nInsira nome: ");
                                        string destinatario = Console.ReadLine(), nomeDestinatario = null;
                                        int indexDestinatario = -1;
                                        for (int i = 0; i < contaCorrente.Count; i++)
                                        {
                                            if (contaCorrente[i].name == name)
                                            {
                                                Console.WriteLine("\nTransferencia invalida");
                                            }
                                            else if (contaCorrente[i].name == destinatario)
                                            {
                                                nomeDestinatario = destinatario;
                                                indexDestinatario = i;
                                            }
                                        }
                                        if (index != -1)
                                        {
                                            contaCorrente[indexDestinatario].Depositar(transferencia);                   
                                            Console.WriteLine("\nValor transferido com sucesso");
                                        }
                                        else { Console.WriteLine("\nConta não encontrada"); }
                                        Console.ReadLine();
                                    }
                                    else if (se == "2")
                                    {
                                        Console.WriteLine("\n----------------------------------");
                                        Console.Write("\nInsira nome: ");
                                        string destinatario = Console.ReadLine(), nomeDestinatario = null;
                                        int indexDestinatario = -1;
                                        for (int i = 0; i < contaPoupanca.Count; i++)
                                        {
                                            if (contaPoupanca[i].name == name)
                                            {
                                                Console.WriteLine("\nTransferencia invalida");
                                            }
                                            else if (contaPoupanca[i].name == destinatario)
                                            {
                                                nomeDestinatario = destinatario;
                                                indexDestinatario = i;
                                            }
                                        }
                                        if (index != -1)
                                        {
                                            contaPoupanca[indexDestinatario].Depositar(transferencia);
                                            Console.WriteLine("\nValor transferido com sucesso");
                                        }
                                        else { Console.WriteLine("\nConta não encontrada"); }
                                        Console.ReadLine();
                                    }
                                    else if (se == "3")
                                    {
                                        Console.WriteLine("\n----------------------------------");
                                        Console.Write("\nInsira nome: ");
                                        string destinatario = Console.ReadLine(), nomeDestinatario = null;
                                        int indexDestinatario = -1;
                                        for (int i = 0; i < contaInvestimento.Count; i++)
                                        {
                                            if (contaInvestimento[i].name == name)
                                            {
                                                Console.WriteLine("\nTransferencia invalida");
                                            }
                                            else if (contaInvestimento[i].name == destinatario)
                                            {                                              
                                                nomeDestinatario = destinatario;
                                                indexDestinatario = i;
                                            }
                                        }

                                        if (index != -1)
                                        {
                                            contaInvestimento[indexDestinatario].Depositar(transferencia);          
                                            Console.WriteLine("\nValor transferido com sucesso");
                                        }
                                        else { Console.WriteLine("\nConta não encontrada"); }
                                        Console.ReadLine();
                                    }
                                }
                            }
                            else { Console.WriteLine("\nSaldo insuficiente"); }
                        }
                        else { Console.WriteLine("\nConta não encontrada"); }
                        Console.ReadLine();
                    }
                    if (sel == "2")
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine(), nomeAtual = null;
                        int index = -1;
                        for (int i = 0; i < contaPoupanca.Count; i++)
                        {
                            if (contaPoupanca[i].name == name)
                            {
                                nomeAtual = name;
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Valor à transferir: ");
                            double transferencia = double.Parse(Console.ReadLine());
                            bool ok = contaPoupanca[index].Sacar(transferencia);
                            if (ok)
                            {
                                string nome = contaPoupanca[index].name;
                                DateTime data = DateTime.Now;
                                data.ToShortDateString();
                                transfereciaContaPoupanca.Add(new Transacoes(nome, transferencia, data));               
                                if (contaPoupanca[index].saldo == 0)
                                {
                                    contaPoupanca[index] = null;
                                    Console.WriteLine("\nConta fechada");
                                }
                                else
                                {
                                    Console.WriteLine("\n----------------------------------");
                                    Console.Write("\n1. Transferencia para Conta Corrente\n2. Transferencia para Conta Poupanca\n3. Transferencia para Conta Investimento\n\nSelecione uma opção: ");
                                    string se = Console.ReadLine();
                                    if (se == "1")
                                    {
                                        Console.WriteLine("\n----------------------------------");
                                        Console.Write("\nInsira nome: ");
                                        string destinatario = Console.ReadLine(), nomeDestinatario = null;
                                        int indexDestinatario = -1;
                                        for (int i = 0; i < contaCorrente.Count; i++)
                                        {
                                            if (contaCorrente[i].name == name)
                                            {
                                                Console.WriteLine("\nTransferencia invalida");
                                            }
                                            else if (contaCorrente[i].name == destinatario)
                                            {
                                                nomeDestinatario = destinatario;
                                                indexDestinatario = i;
                                            }
                                        }
                                        if (index != -1)
                                        {
                                            contaCorrente[indexDestinatario].Depositar(transferencia);
                                            Console.WriteLine("\nValor transferido com sucesso");
                                        }
                                        else { Console.WriteLine("\nConta não encontrada"); }
                                        Console.ReadLine();
                                    }
                                    else if (se == "2")
                                    {
                                        Console.WriteLine("\n----------------------------------");
                                        Console.Write("\nInsira nome: ");
                                        string destinatario = Console.ReadLine(), nomeDestinatario = null;
                                        int indexDestinatario = -1;
                                        for (int i = 0; i < contaPoupanca.Count; i++)
                                        {
                                            if (contaPoupanca[i].name == name)
                                            {
                                                Console.WriteLine("\nTransferencia invalida");
                                            }
                                            else if (contaPoupanca[i].name == destinatario)
                                            {
                                                nomeDestinatario = destinatario;
                                                indexDestinatario = i;
                                            }
                                        }
                                        if (index != -1)
                                        {
                                            contaPoupanca[indexDestinatario].Depositar(transferencia);
                                            Console.WriteLine("\nValor transferido com sucesso");
                                        }
                                        else { Console.WriteLine("\nConta não encontrada"); }
                                        Console.ReadLine();
                                    }
                                    else if (se == "3")
                                    {
                                        Console.WriteLine("\n----------------------------------");
                                        Console.Write("\nInsira nome: ");
                                        string destinatario = Console.ReadLine(), nomeDestinatario = null;
                                        int indexDestinatario = -1;
                                        for (int i = 0; i < contaInvestimento.Count; i++)
                                        {
                                            if (contaInvestimento[i].name == name)
                                            {
                                                Console.WriteLine("\nTransferencia invalida");
                                            }
                                            else if (contaInvestimento[i].name == destinatario)
                                            {
                                                nomeDestinatario = destinatario;
                                                indexDestinatario = i;
                                            }
                                        }
                                        if (index != -1)
                                        {
                                            contaInvestimento[indexDestinatario].Depositar(transferencia);
                                            Console.WriteLine("\nValor transferido com sucesso");
                                        }
                                        else { Console.WriteLine("\nConta não encontrada"); }
                                        Console.ReadLine();
                                    }
                                }
                            }
                            else { Console.WriteLine("\nSaldo insuficiente"); }
                        }
                        else { Console.WriteLine("\nConta não encontrada"); }
                        Console.ReadLine();
                    }
                    if (sel == "3")
                    {
                        Console.WriteLine("\n----------------------------------");
                        Console.Write("\nInsira nome: ");
                        string name = Console.ReadLine(), nomeAtual = null;
                        int index = -1;
                        for (int i = 0; i < contaInvestimento.Count; i++)
                        {
                            if (contaInvestimento[i].name == name)
                            {
                                nomeAtual = name;
                                index = i;
                            }
                        }
                        if (index != -1)
                        {
                            Console.Write("Valor à transferir: ");
                            double transferencia = double.Parse(Console.ReadLine());
                            bool ok = contaInvestimento[index].Sacar(transferencia);
                            if (ok)
                            {
                                string nome = contaInvestimento[index].name;
                                DateTime data = DateTime.Now;
                                data.ToShortDateString();
                                transfereciaContaInvestimento.Add(new Transacoes(nome, transferencia, data));
                                if (contaInvestimento[index].saldo == 0)
                                {
                                    contaInvestimento[index] = null;
                                    Console.WriteLine("\nConta fechada");
                                }
                                else
                                {
                                    Console.WriteLine("\n----------------------------------");
                                    Console.Write("\n1. Transferencia para Conta Corrente\n2. Transferencia para Conta Poupanca\n3. Transferencia para Conta Investimento\n\nSelecione uma opção: ");
                                    string se = Console.ReadLine();
                                    if (se == "1")
                                    {
                                        Console.WriteLine("\n----------------------------------");
                                        Console.Write("\nInsira nome: ");
                                        string destinatario = Console.ReadLine(), nomeDestinatario = null;
                                        int indexDestinatario = -1;
                                        for (int i = 0; i < contaCorrente.Count; i++)
                                        {
                                            if (contaCorrente[i].name == name)
                                            {
                                                Console.WriteLine("\nTransferencia invalida");
                                            }
                                            else if (contaCorrente[i].name == destinatario)
                                            {
                                                nomeDestinatario = destinatario;
                                                indexDestinatario = i;
                                            }
                                        }
                                        if (index != -1)
                                        {
                                            contaCorrente[indexDestinatario].Depositar(transferencia);
                                            Console.WriteLine("\nValor transferido com sucesso");
                                        }
                                        else { Console.WriteLine("\nConta não encontrada"); }
                                        Console.ReadLine();
                                    }
                                    else if (se == "2")
                                    {
                                        Console.WriteLine("\n----------------------------------");
                                        Console.Write("\nInsira nome: ");
                                        string destinatario = Console.ReadLine(), nomeDestinatario = null;
                                        int indexDestinatario = -1;
                                        for (int i = 0; i < contaPoupanca.Count; i++)
                                        {
                                            if (contaPoupanca[i].name == name)
                                            {
                                                Console.WriteLine("\nTransferencia invalida");
                                            }
                                            else if (contaPoupanca[i].name == destinatario)
                                            {
                                                nomeDestinatario = destinatario;
                                                indexDestinatario = i;
                                            }
                                        }

                                        if (index != -1)
                                        {
                                            contaPoupanca[indexDestinatario].Depositar(transferencia);
                                            Console.WriteLine("\nValor transferido com sucesso");
                                        }
                                        else { Console.WriteLine("\nConta não encontrada"); }
                                        Console.ReadLine();
                                    }
                                    else if (se == "3")
                                    {
                                        Console.WriteLine("\n----------------------------------");
                                        Console.Write("\nInsira nome: ");
                                        string destinatario = Console.ReadLine(), nomeDestinatario = null;
                                        int indexDestinatario = -1;
                                        for (int i = 0; i < contaInvestimento.Count; i++)
                                        {
                                            if (contaInvestimento[i].name == name)
                                            {
                                                Console.WriteLine("\nTransferencia invalida");
                                            }
                                            else if (contaInvestimento[i].name == destinatario)
                                            {
                                                nomeDestinatario = destinatario;
                                                indexDestinatario = i;
                                            }
                                        }
                                        if (index != -1)
                                        {      
                                            contaInvestimento[indexDestinatario].Depositar(transferencia);
                                            Console.WriteLine("\nValor transferido com sucesso");
                                        }
                                        else { Console.WriteLine("\nConta não encontrada"); }
                                        Console.ReadLine();
                                    }
                                }
                            }
                            else { Console.WriteLine("\nSaldo insuficiente"); }
                        }
                        else { Console.WriteLine("\nConta não encontrada"); }
                        Console.ReadLine();
                    }
                }

                else if (opcao == "9")
                {
                    break;
                }
                else
                {
                    throw new Exception("\nOpção invalida");
                    Console.ReadLine();
                }
                Console.Clear();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}