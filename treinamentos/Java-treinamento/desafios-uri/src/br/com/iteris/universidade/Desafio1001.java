package br.com.iteris.universidade;

import java.util.Scanner;

public class Desafio1001 {

    private static Scanner reader = new Scanner(System.in);

    public void metodoDesafio1001(){
        //DESAFIO 1001 - Extremamente Básico
        //System.out.println("Digite dois números inteiros: ");
        String a = reader.nextLine();
        String b = reader.nextLine();
        int numA = Integer.parseInt(a);
        int numB = Integer.parseInt(b);
        System.out.println("X = " + (numA + numB));
    }


}
