package br.com.iteris.universidade;

import java.util.Scanner;

public class Desafio1074 {

    private static Scanner reader = new Scanner(System.in);

    public void metodoDesafio1074() {

        //System.out.println("Digite a quantidade de repetições: ");
        String repeticoes = reader.nextLine();
        int n = Integer.parseInt(repeticoes);

        for (int i = 0; i < n; i++) {

            //System.out.println("Digite um valor inteiro: ");
            String valor_lido = reader.nextLine();
            int valor = Integer.parseInt(valor_lido);

            if (valor % 2 == 0) {

                if (valor == 0) {
                    System.out.println("NULL");
                } else {
                    System.out.print("EVEN ");

                    if (valor > 0) {
                        System.out.println("POSITIVE");
                    }
                    if (valor < 0) {
                        System.out.println("NEGATIVE");
                    }
                }
            }

            if (valor % 2 != 0) {
                System.out.print("ODD ");

                if (valor > 0) {
                    System.out.println("POSITIVE");
                }

                if (valor < 0) {
                    System.out.println("NEGATIVE");
                }

            }
        }

    }
}
