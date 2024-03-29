using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Medio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array Original: {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"Array Distinto: {string.Join(", ", arrayUnico)}");

            // var numerosParesQuerry =
            //         from num in arrayNumeros
            //         where num % 2 == 0
            //         orderby num
            //         select num;
            
            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Numeros pares querry: " + string.Join(", ", numerosParesQuerry));
            // System.Console.WriteLine("Numeros pares metodo: " + string.Join(", ", numerosParesMetodo));

//======================================================================== 
            // Dictionary<string, string> estados = new Dictionary<string, string>();
            
            // estados.Add("SP", "Sao paulo");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("BA", "Bahia");

            // foreach (var item in estados)
            // {
            //     //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // string valorProcurado = "SC";

            // if(estados.TryGetValue(valorProcurado, out string estadoEncontrando))
            // {
            //     System.Console.WriteLine(estadoEncontrando);
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave: {valorProcurado} nao existe no dicionario");
            // }

            // System.Console.WriteLine("Removento o valor: {0}", valorProcurado);

            // estados.Remove(valorProcurado);
            
            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // System.Console.WriteLine("Valor original: ");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "BA - teste atualizacao";

            // System.Console.WriteLine("Valor atualizado: ");
            // System.Console.WriteLine(estados[valorProcurado]);

//======================================================================== 
            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Codigo Limpo");

            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count} ");

            // while(pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Proximo livro para a leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
            // }

            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count} ");

//======================================================================== 
            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Nicolas");
            // fila.Enqueue("Vitoria");
            // fila.Enqueue("Gabriel");
    
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while(fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

//======================================================================== 
            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>{"SP", "MG", "BA"};
            // string[] estadosArray = new string[2] {"SC", "MT"};

            // System.Console.WriteLine("Quantidade de elementos na lista: {0}", estados.Count);
            
            // opLista.ImprimirListarString(estados);

            // // System.Console.WriteLine("Removendo o elemento...");
            // // estados.Remove("MG");

            // //estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ");

            // opLista.ImprimirListarString(estados);

//======================================================================== 
            // OperacoesArray op = new OperacoesArray();

            // int[] array = new int[5] { 6, 3, 8, 1, 9};
            // int[] arrayCopia = new int [10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // //int valorProcurado = 10;

            // System.Console.WriteLine($"Capacidade atual do Array: {array.Length}");

            // op.RedimensionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do Array apos redimensionar: {array.Length}");

//======================================================================== 
            // int indice = op.ObterIndice(array, valorProcurado);

            // if(indice >-1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor nao existente no array");
            // }

//======================================================================== 
            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Nao encontrei o valor");
            // }

//======================================================================== 
            // bool todosMaiorQue = op.TodosMaiorQue(array,valorProcurado);

            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores sao maiores que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existe valores que nao sao maiores do que {0}", valorProcurado);
            // }

//========================================================================  
            // bool existe = op.Existe(array, valorProcurado);

            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Nao encontrei o valor: {0}", valorProcurado);
            // }

//========================================================================  
            //System.Console.WriteLine("Array Original:");
            //op.ImprimirArray(array);

            //op.OrdernarBubbleSort(ref array);
            //System.Console.WriteLine("Array Ordenado:");
            //op.ImprimirArray(array);

//========================================================================  
            // System.Console.WriteLine("Array antes da copia:");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array apos a copia:");
            // op.ImprimirArray(arrayCopia);

//========================================================================            
            // int[,] matriz = new int[4,2]
            // {
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200}
            // };
            
            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }

//========================================================================
            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");

            // System.Console.WriteLine("Percorrendo pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}