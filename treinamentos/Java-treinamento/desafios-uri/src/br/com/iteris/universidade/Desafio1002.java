package br.com.iteris.universidade;

import java.util.Scanner;

public class Desafio1002 {

    private static Scanner reader = new Scanner(System.in);

    public void metodoDesafio1002() {
        //DESAFIO 1002 - Área do Círculo
        double n = 3.14159;
        //System.out.println("Digite o valor do raio: ");
        String r = reader.nextLine();
        double raio = Double.parseDouble(r);

        double area = n * (raio * raio);

        System.out.printf("A=%.4f\n", area);
    }
}
