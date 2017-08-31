using System;

namespace Aula7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //vetoresExemplo();
            //vetoresExercicio1();
            //vetoresExercicio2();
            //vetoresExercicio3();
            //ExemploMatrizes();
            //matrizesExercicio1();
            //vetoresExercicio4();
            //vetoresExercicio5();
            vetoresExercicio6();

        }

        static void vetoresExemplo(){
			string[] nomes = new string[10];
			for (int x = 0; x < 10; x++)
			{
				Console.WriteLine("Informe o Nome do Aluno {0}:", (x + 1));
				nomes[x] = Console.ReadLine();
			}
        }

		static void vetoresExercicio1()
		{
			string[] nomes = new string[10];
			for (int x = 0; x < 10; x++)
			{
				Console.WriteLine("Informe o Nome do Aluno {0}:", (x + 1));
				nomes[x] = Console.ReadLine();
			}
			for (int x = 9; x > -1; x--)
			{
                Console.WriteLine("O nome do Aluno {0}: {1}", (x + 1), nomes[x]);
			}
		}

		static void vetoresExercicio2()
		{
			int[] valores = new int[10];
            int media = 0;
			for (int x = 0; x < 10; x++)
			{
				Console.WriteLine("Informe o valor {0}:", (x + 1));
                valores[x] = Convert.ToInt32(Console.ReadLine());
			}
			for (int x = 9; x > -1; x--)
			{
				Console.WriteLine("O valor {0} é: {1}", (x + 1), valores[x]);
                media += valores[x];
			}
            Console.WriteLine("A média dos números digitados é: {0}", media/10);
		}


		static void vetoresExercicio3()
		{
			string[] nomes = new string[10];
            string busca;
            bool verifica = false;
			for (int x = 0; x < 10; x++)
			{
				Console.WriteLine("Informe o Nome {0}:", (x + 1));
				nomes[x] = Console.ReadLine();
			}

            Console.WriteLine("Informe o nome a ser procurado:");
            busca = Console.ReadLine();

			for (int x = 0; x < 10; x++)
			{

                if (busca == Convert.ToString(nomes[x])){
                    verifica = true;
                    x = 10;
                }
                    
                else
                    verifica = false;
			}

            if (verifica)
                Console.WriteLine("ACHEI");
            else
                Console.WriteLine("NÃO ACHEI");
		}


		public static void ExemploMatrizes()
		{
			string[] Alunos = new string[10];
			decimal[,] Notas = new decimal[10, 4];
			int X, N;
			for (X = 0; X < 10; X++)
			{
				Alunos[X] = Console.ReadLine();
				for (N = 0; N < 4; N++)
				{
					Notas[X, N] = Convert.ToDecimal(Console.ReadLine());
				}
			}
		}


        static void matrizesExercicio1()
        {
            string nome, email, telefone;
            string[,] pedido = new string[5, 4];
            decimal total = 0;

            Console.WriteLine("Digite o nome do cliente: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o e-mail do cliente: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite o telefone do cliente: ");
            telefone = Console.ReadLine();

            for (int X = 0; X < 5; X++)
            {

                Console.WriteLine("Digite o nome do item: ");
                pedido[X, 0] = Console.ReadLine();

                Console.WriteLine("Digite o valor do item: ");
                pedido[X, 1] = Console.ReadLine();

                Console.WriteLine("Digite quantidade do item: ");
                pedido[X, 2] = Console.ReadLine();

                //subtotal
                pedido[X, 3] = Convert.ToString((Convert.ToDecimal(pedido[X, 1])) * (Convert.ToDecimal(pedido[X, 2])));


            }

            Console.WriteLine("Dados do cliente: ");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("E-mail: {0}", email);
            Console.WriteLine("Telefone: {0}", telefone);


            for (int X = 0; X < 5; X++) {
                Console.WriteLine("Item nº {0}: ", (X+1));
                Console.WriteLine("Nome do item: {0}", pedido[X, 0]);
                Console.WriteLine("Subtotal: {0:###,##0.00}", pedido[X, 3]);
                total += Convert.ToDecimal(pedido[X, 3]);
            }

            Console.WriteLine("Valor total do pedido: {0:###,##0.00}", total);

        }


		static void vetoresExercicio4()
		{
			int[] valores = new int[20];
            int maior = 0, menor = 0, pmaior = 0, pmenor = 0;

            Console.WriteLine("Informe o valor 1: ");
            valores[0] = Convert.ToInt32(Console.ReadLine());
			maior = valores[0];
			menor = valores[0];

			for (int x = 1; x < 20; x++)
			{
				Console.WriteLine("Informe o valor {0}:", (x + 1));
				valores[x] = Convert.ToInt32(Console.ReadLine());

                if (Convert.ToInt32(valores[x]) > maior){
                    maior = valores[x];
                    pmaior = x;
                }

				if (Convert.ToInt32(valores[x]) < menor)
				{
                    menor = valores[x];
					pmenor = x;
				}
			}



			Console.WriteLine("O maior número digitados é: {0}", maior);
            Console.WriteLine("Sua posição no array é: {0}", pmaior);
            Console.WriteLine("O menor número digitados é: {0}", menor);
            Console.WriteLine("Sua posição no array é: {0}", pmenor);
		}


		static void vetoresExercicio5()
		{
			int[] valores = new int[20];

			Console.WriteLine("Digite 20 valores: ");

			for (int x = 0; x < 20; x++)
			{
				Console.WriteLine("Informe o valor {0}:", (x + 1));
				valores[x] = Convert.ToInt32(Console.ReadLine());	
			}

            Console.WriteLine("Os números ímpares digitados são: ");

            for (int x = 0; x < 20; x++) {
                if ((valores[x] % 2) != 0)
                    Console.Write("{0}, ", valores[x]);
            }

            Console.Write("\b\b");
		}


        static void vetoresExercicio6(){
            int[] valores = new int[30];
            int busca, qtd = 0;

			Console.WriteLine("Digite 30 valores: ");

			for (int x = 0; x < 30; x++)
			{
				Console.WriteLine("Informe o valor {0}:", (x + 1));
				valores[x] = Convert.ToInt32(Console.ReadLine());
			}

            Console.WriteLine("Digite o valor para buscar no Array: ");
            busca = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < 30; x++) {
                if (busca == valores[x])
                    qtd++;
            }

            switch (qtd) {
                case 0: 
                    Console.WriteLine("A sua busca não foi encontrada");
                    break;
                case 1:
                    Console.WriteLine("A sua busca foi encontrada 1 vez");
                    break;
                default:
					Console.WriteLine("A sua busca foi encontrada {0} vezes", qtd);
					break;
            }


        }


    }
}
