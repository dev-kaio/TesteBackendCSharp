//================ Atividade 1 - Palíndromo ================

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Informe uma frase: ");
//         string frase = Console.ReadLine();

//         string fraseFormatada = "";
//         foreach (char c in frase)
//         {
//             if (char.IsLetter(c))
//             {
//                 fraseFormatada += char.ToLower(c);
//             }
//         }

//         int inicio = 0;
//         int fim = fraseFormatada.Length - 1;
//         bool palindromo = true;

//         while (inicio < fim)
//         {
//             if (fraseFormatada[inicio] != fraseFormatada[fim])
//             {
//                 palindromo = false;
//                 break;
//             }
//             inicio++;
//             fim--;
//         }

//         switch (palindromo)
//         {
//             case true: Console.WriteLine("A frase é um palíndromo."); break;
//             case false: Console.WriteLine("A frase não é um palíndromo."); break;
//         }
//     }
// }

//================ Atividade 2 - Fibonacci ================

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Informe quantos números quer gerar: ");
//         int num = int.Parse(Console.ReadLine());

//         int primeiro = 0;
//         int segundo = 1;

//         if (num >= 1)
//         {
//             Console.Write(primeiro + " ");

//             if (num >= 2)
//             {
//                 Console.Write(segundo + " ");
//             }

//             int proximo;

//             for (int i = 3; i <= num; i++)
//             {
//                 proximo = primeiro + segundo;
//                 Console.Write(proximo + " ");

//                 primeiro = segundo;
//                 segundo = proximo;
//             }
//         }
//     }
// }



//================= Atividade 3 - Normalização de texto  ================
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Informe uma frase: ");
//         string frase = Console.ReadLine();
//         string fraseFormatada = "";

//         foreach (char c in frase)
//         {
//             if (char.IsLetter(c))
//             {
//                 fraseFormatada += c;
//             }
//             else if (char.IsWhiteSpace(c))
//             {
//                 fraseFormatada += " ";
//             }
//             else if (char.IsPunctuation(c))
//             {
//                 if (fraseFormatada.Last() != c)
//                 {
//                     fraseFormatada += c;
//                 }
//                 else
//                 {
//                     continue;
//                 }
//             }
//         }
//         Console.WriteLine("Frase formatada: " + fraseFormatada);
//     }
// }