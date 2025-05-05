package br.com.iteris.universidade;

import java.util.Scanner;

public class Desafio1140 {

    private static Scanner reader = new Scanner(System.in);

    public void metodoDesafio1140() {

        //System.out.println("Digite a frase: ");
        String fraseInicial = reader.nextLine();

        while (!fraseInicial.equals("*")){

            String[] fraseSeparada = fraseInicial.toLowerCase().split(" ");
            boolean ehTautograma = true;

            //FOR PARA TESTAR
            //for (int i = 0; i < fraseSeparada.length; i++) {
            //System.out.println(fraseSeparada[i] + " " + fraseSeparada[i].charAt(0));
            //System.out.println(fraseSeparada[i].charAt(0));
            // }

            for (int i = 0; i < fraseSeparada.length; i++) {

                if (i != 0) {
                    if (fraseSeparada[i].charAt(0) != fraseSeparada[i - 1].charAt(0)) {
                        ehTautograma = false;
                        break;
                    }
                }
            }

            if (ehTautograma) { //mesma coisa que "ehTautograma == true"
                System.out.println("Y");
            }

            if (!ehTautograma) { //mesma coisa que "ehTautograma == false"
                System.out.println("N");
            }

            fraseInicial = reader.nextLine();
        }



    }
}
