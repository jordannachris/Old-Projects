package br.com.iteris.universidade;

import java.util.Scanner;

public class Desafio1160 {
    private static Scanner reader = new Scanner(System.in);

    public void metodoDesafio1160() {

        //System.out.println("Digite o número de repetições: ");
        String valor_lido = reader.nextLine();
        int T = Integer.parseInt(valor_lido);

        for (int i = 0; i < T; i++){

            String entrada = reader.nextLine();
            String[] numeroSeparado = entrada.toLowerCase().split(" ");

            int PA = Integer.parseInt(numeroSeparado[0]);
            int PB = Integer.parseInt(numeroSeparado[1]);
            float G1 = Float.parseFloat(numeroSeparado[2]);
            float G2 = Float.parseFloat(numeroSeparado[3]);

            //System.out.println("PA: " + PA);
            //System.out.println("PB: " + PB);
            //System.out.println("G1: " + G1);
            //System.out.println("G2: " + G2);


            int anos = 0;

            while (PA <= PB){
                anos++;
                float taxaCrescimentoA = PA * (G1 / 100);
                float taxaCrescimentoB = PB * (G2 / 100);
                PA = PA + (int) taxaCrescimentoA;
                PB = PB + (int) taxaCrescimentoB;
            }

            if(anos > 100){
                System.out.println("Mais de 1 seculo.");
            }
            else{
                System.out.println(anos + " anos.");
            }

        }



    }

}
