using System;
					
public class Program
{
	public static void Main()
	{	
		int contaminacao = 0;
		string resposta = "";
		
		Console.WriteLine("Escreva seu nome");
		string nome = Console.ReadLine();
		
		Console.WriteLine("Escreva sua idade:");
		int idade = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Responda 'sim' ou 'nao' para as perguntas abaixo:");
		Console.WriteLine("Seu cartão de vacina está em dia?");
		resposta = Console.ReadLine();
		if (resposta == "nao"){
			contaminacao = contaminacao + 10;
		}
		Console.WriteLine("Teve algum dos sintomas recentemente? (dor de cabeça, febre, náusea, dor articular, gripe)");
		resposta = Console.ReadLine();
		if (resposta == "sim"){
			contaminacao = contaminacao + 30;
		}
		Console.WriteLine("Teve contato com pessoas com sintomas gripais nos últimos dias?");
		resposta = Console.ReadLine();
		if (resposta == "sim"){
			contaminacao = contaminacao + 30;
		}
		Console.WriteLine("Está retornando de viagem realizada no exterior?");
		resposta = Console.ReadLine();
		if (resposta == "sim"){
			contaminacao = contaminacao + 30;
			Console.WriteLine("Você ficará sob observação por 05 dias.");
		}
		
	}	
}
