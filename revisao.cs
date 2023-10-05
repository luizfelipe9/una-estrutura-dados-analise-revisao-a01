using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe o seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe a sua idade:");
        int idade = int.Parse(Console.ReadLine());

        int porcentagemRisco = 0;

        // Perguntas com respostas "SIM" ou "NAO"
        string[] perguntas = { "Seu cartão de vacina está em dia?", "Teve algum dos sintomas recentemente?", "Teve contato com pessoas com sintomas gripais nos últimos dias?", "Está retornando de viagem realizada no exterior?" };

        for (int i = 0; i < perguntas.Length; i++)
        {
            Console.WriteLine(perguntas[i]);
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "SIM")
            {
                // Aumenta a porcentagem de risco com base na pergunta
                switch (i)
                {
                    case 0:
                        porcentagemRisco += 10;
                        break;
                    case 1:
                    case 2:
                    case 3:
                        porcentagemRisco += 30;
                        break;
                }
            }
            else if (resposta != "NAO")
            {
                Console.WriteLine("Resposta inválida. Responda com 'SIM' ou 'NAO'.");
                i--; // Permite outra tentativa para a mesma pergunta
            }
        }

        // Determina a orientação final com base na porcentagem de risco
        string orientacaoFinal = "";
        if (porcentagemRisco <= 30)
            orientacaoFinal = "Paciente sob observação. Caso apareça algum sintoma, gentileza buscar assistência médica.";
        else if (porcentagemRisco <= 60)
            orientacaoFinal = "Paciente com risco de estar infectado. Gentileza aguardar em lockdown por 02 dias para ser acompanhado.";
        else if (porcentagemRisco <= 89)
            orientacaoFinal = "Paciente com alto risco de estar infectado. Gentileza aguardar em lockdown por 05 dias para ser acompanhado.";
        else
            orientacaoFinal = "Paciente crítico! Gentileza aguardar em lockdown por 10 dias para ser acompanhado";

        // Se retornando de viagem, imprima a orientação adicional
        if (porcentagemRisco > 0)
            orientacaoFinal += "\nVocê ficará sob observação por 05 dias.";

        // Exibe os resultados
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Probabilidade de infecção: " + porcentagemRisco + "%");
        Console.WriteLine("Orientação final:\n" + orientacaoFinal);
    }
}
