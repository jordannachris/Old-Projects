package br.com.iteris.universidade;

import java.util.Scanner;

public class Desafio1272 {

    private static Scanner reader = new Scanner(System.in);

    public void metodoDesafio1272() {

        String repeticoes = reader.nextLine();
        int n = Integer.parseInt(repeticoes);

        for (int cont = 0; cont < n; cont++){

            String frase = reader.nextLine();

            for (int i = 0; i < frase.length(); i++) {

                if ((i == 0) && (frase.charAt(i) != ' '))
                {
                    System.out.print(frase.charAt(i));
                }

                if (i != 0)
                {
                    if ((frase.charAt(i) != ' ') && (frase.charAt(i-1) == ' ')) {
                        System.out.print(frase.charAt(i));
                    }
                }
            }
            System.out.print("\n");
        }
    }

}
