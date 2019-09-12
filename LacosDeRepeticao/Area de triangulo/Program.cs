using System;

namespace Area_de_triangulo
{
    class Program
    {
        /// <summary>
        /// Metodo para verificar se o numero é igual a zero    
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Boolean, true se é zero, se não false</returns>
        public bool VerificaSeZero(double numero) => numero == 0;

        static void Main(string[] args)
        {
            Console.Write($"\r Digite: \r\n 1 - Área do Triângulo Retângulo \r\n 2 - Área do Quadrado \r\n Digite a área que quer calcular: ");
            int area = Convert.ToInt32(Console.ReadLine());
            Console.Write($" Digite a base: ");
            double baseNumero = Convert.ToDouble(Console.ReadLine());
            Console.Write($" Digite a altura: ");
            double alturaNumero = Convert.ToDouble(Console.ReadLine());
            String resposta = string.Empty;
            Program program = new Program();

            if (program.VerificaSeZero(baseNumero) || program.VerificaSeZero(alturaNumero))
            {
                resposta = $" Os dois números devem ser diferentes de zero";
            }
            else
            {
                switch (area)
                {
                    case 1:
                        resposta = $" Área do Triângulo Retângulo: {(baseNumero * alturaNumero) / 2}";
                        break;
                    case 2:
                        resposta = $" Área do Quadrado: {(baseNumero * alturaNumero)}";
                        break;
                    default:
                        resposta = $" Não existe uma opção '{area}'";
                        break;
                }
            }
            Console.WriteLine(resposta + $"\n\r-------- Pressione qualquer tecla para sair --------");
        }
    }
}
