package br.com.iteris.universidade;
import br.com.iteris.universidade.modelos.Cliente;
import br.com.iteris.universidade.modelos.Usuario;

import java.util.Scanner;

public class Main {

    private static final Scanner reader = new Scanner(System.in);

        public static void main(String[] args) {

            Usuario usuarioA = new Usuario();
            usuarioA.setNome("Jordanna Christina");
            usuarioA.setEmail("jordanna.costa@iteris.com.br");
            System.out.println(usuarioA.obterLogin());

            /*
            // primeiro cliente
            Cliente clienteA = new Cliente();
            clienteA.setNome("Douglas");
            clienteA.setSobreNome("Fernandes");
            System.out.println(clienteA.faltaQuantosAnosPara(40));
            // Falta(m) 40 Anos(s)
            var clienteB = new Cliente(29); //var - tipo implícito
            clienteB.setNome("<Jordanna>");
            clienteB.setSobreNome("<Costa>");
            System.out.println(clienteB.faltaQuantosAnosPara(40));
            */


            /*
            // primeiro cliente
            Cliente clienteA = new Cliente();
            clienteA.setNome("Douglas");
            clienteA.setSobreNome("Fernandes");
            System.out.println(clienteA.getNomeCompleto());
            // segundo cliente
            var clienteB = new Cliente(); //var - tipo implícito
            clienteB.setNome("Jordanna");
            clienteB.setSobreNome("Costa");
            System.out.println(clienteB.getNomeCompleto());
            */
        /*
        System.out.println("Digite dois números inteiros: ");
        String a = reader.nextLine();
        String b = reader.nextLine();
        int numA = Integer.parseInt(a); //converte string em int
        int numB = Integer.parseInt(b);
        System.out.println("A soma é: " + (numA + numB));

        System.out.println("Digite dois números reais: ");
        String c = reader.nextLine();
        String d = reader.nextLine();
        float numC = Float.parseFloat(c); //converte string em int
        float numD = Float.parseFloat(d);
        System.out.println("A soma é: " + (numC + numD));

        System.out.println("Digite três números reais: ");
        String e = reader.nextLine();
        String f = reader.nextLine();
        String g = reader.nextLine();
        float numE = Float.parseFloat(e); //converte string em int
        float numF = Float.parseFloat(f);
        float numG = Float.parseFloat(g);
        System.out.println("A multiplicação é: " + (numE * numF * numG));
        */
    }
}
