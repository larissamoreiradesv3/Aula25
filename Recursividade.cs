using System;

namespace Aula25
{
    public class Recursividade
    {
        //Fibonacci: irá inicar com um valor, intervalo específico e quantidade de vezes.
        public void Sequencia(int numero1, int numero2, int vezes){
            //Método para quebrar a recursividade, ou seja, impedir que ele se repita várias vezes
            if(vezes > 0){
                //mostrar o primeiro número
                Console.WriteLine(numero1);
                //o segundo número se torna o primeiro
                Sequencia(numero2, numero1+numero2, vezes -1);
             }
        }
             //Fatorial:
                //6!= 10 * 20 * 30 * 40 * 0
                public int Fatorar(int numero){
                    //Para quebrar a recursividade
                    if(numero == 1 ){
                        return 1;
                    }else{
                        return numero * Fatorar(numero -1);
                    }
        }
    }
 }
