package br.com.iteris.universidade;

import java.util.Scanner;

public class Main {

    private static Scanner reader = new Scanner(System.in);

        public static void main(String[] args) {

            //DESAFIO 1001 - Extremamente Básico
            //var d1 = new Desafio1001();
            //d1.metodoDesafio1001();

            //DESAFIO 1002 - Área do Círculo
            //var d2 = new Desafio1002();
            //d2.metodoDesafio1002();

            //DESAFIO 1050 - DDD
            //var d3 = new Desafio1050();
            //d3.metodoDesafio1050();

            //DESAFIO 1074 - Par ou Ímpar
            //var d4 = new Desafio1074();
            //d4.metodoDesafio1074();

            //DESAFIO 1140 - Flores Florescem da França
            //var d5 = new Desafio1140();
            //d5.metodoDesafio1140();

            //Desafio 1153 - Fatorial Simples
            //var d6 = new Desafio1153();
            //d6.metodoDesafio1153();

            //Desafio 1160 - Crescimento Populacional
            //var d7 = new Desafio1160();
            //d7.metodoDesafio1160();

            //Desafio 1272 - Mensagem Oculta
            //var d8 = new Desafio1272();
            //d8.metodoDesafio1272();


            //Desafio 2593 - Eachianos I
            //System.out.println("Digite a frase: ");
            String fraseLida = reader.nextLine();
            String[] fraseSeparada = fraseLida.split(" ");

            //System.out.println("Digite a quantidade de palavras a serem lidas: ");
            String quantidade = reader.nextLine();
            int qtdPalavras = Integer.parseInt(quantidade);

            //System.out.println("Digite a frase com as palavras que deseja comparar: ");
            String palavrasLidas = reader.nextLine();
            String[] palavrasSeparadas = palavrasLidas.split(" ");

            int i, j, posicao;


            for (i = 0; i < palavrasSeparadas.length; i++) {

                boolean iguais = false;

                for(j = 0; j < fraseSeparada.length; j++){

                    int contador = 0;
                    //O "contador" é para contar o número de espaços "em branco" na string "fraseLida"
                    //Aí eu comparo as palavrasSeparadas[i] com a fraseSeparada[j]
                    //Onde for igual, a posição da palavra repetida estará na posição j da fraseSeparada[j]
                    //Ou seja, eu sei que a palavra que está na posição [j], ja passou por uma quantidade "j" de espaços em branco
                    //Aí é só comparar o "contador" de espaços em branco com [j]
                    //Onde contador == j, eu sei que ali estará a posição do último espaço em branco anterior à palavra que eu quero
                    //Para descobrir a posição da palavra, basta fazer: "posição do espaço em branco" + 1

                    if(fraseSeparada[j].equals(palavrasSeparadas[i])){
                        iguais = true;

                        //System.out.print(palavrasSeparadas[i] + " - " + "posicao: ");

                        for (posicao = 0; posicao <= fraseLida.length(); posicao++){

                            if (fraseLida.charAt(posicao) == ' '){
                                contador++;
                            }
                            if(contador == j){
                                System.out.print((posicao+1));
                                break;
                            }
                        } //fim do FOR interno
                        System.out.print(" ");

                    } //fim do IF de comparação de strings

                } //fim do FOR externo
                if(!iguais){
                    System.out.print("-1");
                }
                System.out.print("\n");
            }

    }
}



