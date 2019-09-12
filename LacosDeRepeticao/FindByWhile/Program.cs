using System;

namespace FindByWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write($"Digite uma palavra: ");
                var quantidade = FindByWhile(Console.ReadLine());
                Console.WriteLine($"Quantidade de vezes que foi achada: {quantidade}");
                Console.Write($"Tentar de novo? (sim ou não): ");
                string tentar = Console.ReadLine();
                switch (tentar)
                {
                    case "sim":
                        Console.Clear();
                        break;
                    case "não":
                        flag = false; ;
                        break;
                    case "nao":
                        flag = false;
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Utilizado para percorrer o textContent e ver a quantidade de palavras que contem iguais as do parametro
        /// </summary>
        /// <param name="wordFind">Palavra a ser comparada na string</param>
        /// <returns>Quantidade de vezes achada</returns>
        private static int FindByWhile(string wordFind)
        {
            int i = 0, j = 0;
            var qtdVezes = 0;
            while (i < TextContent().Length - 1)
            {
                var palavraParaComparar = "";
                while (j <= wordFind.Length - 1)
                {
                    if (!(i + j >= TextContent().Length))
                        palavraParaComparar += TextContent()[i + j].ToString();
                    j++;
                }
                j = 0;
                if (wordFind.Equals(palavraParaComparar))
                    qtdVezes++;
                i++;
            }
            return qtdVezes;
        }

        /// <summary>
        /// Texto a ser utilizado na aplicação
        /// </summary>
        /// <returns>String passada</returns>
        private static String TextContent() => @"Pensando mais a longo prazo, a execução dos pontos do programa estimula a padronização dos modos de operação convencionais.O empenho em analisar a constante divulgação das informações acarreta um processo de reformulação e modernização dos relacionamentos verticais entre as hierarquias.No entanto, não podemos esquecer que o fenômeno da Internet faz parte de um processo de gerenciamento dos níveis de motivação departamental.A certificação de metodologias que nos auxiliam a lidar com o entendimento das metas propostas apresenta tendências no sentido de aprovar a manutenção do sistema de participação geral.Do mesmo modo, o novo modelo estrutural aqui preconizado garante a contribuição de um grupo importante na determinação do fluxo de informações.";
    }
}
