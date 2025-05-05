package br.com.iteris.universidade;

import java.util.Scanner;

public class Desafio1153 {

    private static Scanner reader = new Scanner(System.in);

    public void metodoDesafio1153() {
        //System.out.println("Digite um numero inteiro: ");
        int n = reader.nextInt();
        int ene = n;

        for (int i = 1; (ene - i) >= 1; i++){
            n = n * (ene - i);
        }

        System.out.println(n);
    }
}
