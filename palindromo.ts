function SearchingChallenge(str: string) {


    // VERIFICA SE A STRING É UM PALINDROMO
    function isPalindrome(texto: string) {
        return texto.split('').reverse().join('');
    }

    let maior = "";

    // Encontrar a maior string palindroma
    for (let i = 0; i < str.length; i++) {
        for (let j = i + 1; j <= str.length; j++) {
            let sub = str.substring(i, j)

            //verifica se palindro e maior, se for salva como maior
            if (isPalindrome(sub) && sub.length > maior.length)
                maior = sub
        }
    }
    // Se não houver palindromo maior que 2, retorna 'none'
    if (maior.length <= 2)
        return "none";

    // armazena o valor do token pra concatenar depois
    let challengeToken = "usc1dnqo0f6";

    let textoCombinado = maior + challengeToken;

    // Substitui o terceiro caractere por `X`

    let resultado = "";

    for (let k = 0; k < textoCombinado.length; k++) {
        // se posição em 1 for multiplo de 3 (indice + 1)
        if ((k + 1) % 3 === 0) {
            resultado += "X";
        } else {
            resultado += textoCombinado[k]
        }
    }

    return resultado

}

// keep this function call here 
// @ts-ignore
console.log(SearchingChallenge(readline()));