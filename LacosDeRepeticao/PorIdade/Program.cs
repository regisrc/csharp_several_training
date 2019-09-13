using System;

namespace PorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramExecution();
        }

        private static void ProgramExecution()
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("Qual sua idade? : ");
                int idade = Convert.ToInt16(Console.ReadLine());
                bool situacao = VerifyAge(idade);
                String mensagem = SetMessageForSituation(situacao);
                Console.WriteLine(mensagem);
                Console.Write("Tentar novamente? (1 para sim e 2 para não) : ");
                string interesse = Convert.ToString(Console.ReadKey().KeyChar);
                switch (interesse)
                {
                    case "1":
                        Console.Clear();
                        break;
                    case "2":
                        flag = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private static bool VerifyAge(int idade) => idade >= 18;

        private static String SetMessageForSituation(bool situacao) => situacao ? "Hoje é sexta, bora beber" : "Tem leitinho na geladeira";
        
    }
}
