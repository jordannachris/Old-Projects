package br.com.iteris.universidade.desafio01.domain.entity;
import lombok.AllArgsConstructor;
import lombok.Data;

import java.time.LocalDate;
import java.util.Date;

@Data
@AllArgsConstructor
public class Animal {

    private Integer idAnimal;
    private String nome;
    private Integer idade;
    private String especie;
    private LocalDate dataNascimento;
    private Integer nivelFofura;
    private Integer nivelCarinho;
    private String email;

}
