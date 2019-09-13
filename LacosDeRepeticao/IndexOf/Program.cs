using System;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            int index = getIndexOf(Console.ReadLine());
            Console.WriteLine($"Quantidade: {index}");
        }

        public static int getIndexOf(String palavra)
        {
            int lastIndex = getLastIndexOf(palavra), index = 0, qtdVezes = 0;
            if (lastIndex == -1) return 0;
            while (index <= lastIndex)
            {
                int indexTemp = index;
                index = TextContent().IndexOf(palavra, index) + 1;
                if (index == 0) return qtdVezes;
                if (indexTemp != index) qtdVezes++;
            }
            return qtdVezes;
        }

        private static int getLastIndexOf(String palavra) => TextContent().LastIndexOf(palavra);

        private static String TextContent() => @"Pensando mais a longo prazo, a execução dos pontos do programa estimula a padronização dos modos de operação convencionais.O empenho em analisar a constante divulgação das informações acarreta um processo de reformulação e modernização dos relacionamentos verticais entre as hierarquias.No entanto, não podemos esquecer que o fenômeno da Internet faz parte de um processo de gerenciamento dos níveis de motivação departamental.A certificação de metodologias que nos auxiliam a lidar com o entendimento das metas propostas apresenta tendências no sentido de aprovar a manutenção do sistema de participação geral.Do mesmo modo, o novo modelo estrutural aqui preconizado garante a contribuição de um grupo importante na determinação do fluxo de informações.";


    }
}
