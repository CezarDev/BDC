using System;
using System.Linq;

class MainClass {

  public static string SearchingChallenge(string str) {

    string[] palavras = str.Split(' ');
    string melhorPalavra = "-1";
    int maxRepeticoes = 1;

    // Encontrar a palavra com mais letras repetidas
    foreach (string palavra in palavras) { 
      int maxContagemPalavra = palavra
          .Where(char.IsLetter)
          .GroupBy(char.ToLower)
          .Select(g => g.Count())
          .DefaultIfEmpty(0)
          .Max();

      if (maxContagemPalavra > maxRepeticoes)
      {
        maxRepeticoes = maxContagemPalavra;
        melhorPalavra = palavra;
      }
    }

    // Concatenar com o token
    string token = "usc1dnqo0f6";
    char[] resultado = (melhorPalavra + token).ToCharArray();

    // Trocar cada 3º caractere por 'X' (índices 2, 5, 8...)
    for (int i = 2; i < resultado.Length; i += 3)
      resultado[i] = 'X';
      
    return new string(resultado);
  }

  // keep this function call here
  static void Main() {

    Console.WriteLine(SearchingChallenge(Console.ReadLine()));
    
  } 

}
