package br.com.iteris.universidade.modelos;

public class Usuario {
    private String nome;
    private String email;


    public String getNome() {
        return nome;
    }
    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }
    public void setEmail (String email) {
        this.email = email;
    }


    public String obterLogin() {
        String[] login = this.email.split("@");
        return login[0];
        //return "O login da usuária " + this.nome + " é " + login[0];
    }


}
