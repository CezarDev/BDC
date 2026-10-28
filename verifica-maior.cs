using System;
using System.Linq;

class MainClass {

  public static string ArrayChallenge(int[] arr) {

    // Encontra o maior do array
    var lista = arr.ToList();
    int maior = lista.Max();
    lista.Remove(maior);
    int[] restantes = lista.ToArray();

    // Verifica se alguma combinação dos restantes soma o valor maior
    return SomaPossivel(restantes, maior) ? "true" : "false";
  }

  private static bool SomaPossivel(int[] nums, int alvo) 
  {
    // testa as possiveis combinacoes usando a mascara de bits
    int total = 1 << nums.Length;
    for (int i = 1; i < total; i++) {
      int soma = 0;
      for (int j = 0; j < nums.Length; j++){ 
        if ((i & (1 << j)) != 0) 
            soma += nums[j];
          
      }
      if (soma == alvo) return true;
    }
    return false;
  }

  // keep this function call here
  static void Main() {

    Console.WriteLine(ArrayChallenge(Console.ReadLine()));
    
  } 

}