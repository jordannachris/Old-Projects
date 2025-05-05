package br.com.iteris.universidade.desafio01.domain.dto;

import lombok.Data;
import org.hibernate.validator.constraints.Range;
import org.springframework.lang.Nullable;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotEmpty;
import javax.validation.constraints.NotNull;
import java.time.LocalDate;
import java.util.Date;

@Data
public class AnimalCreateRequest {

    @NotEmpty(message = "O nome do animal deve ser definido")
    private String nome;

    @NotNull(message = "A idade do animal deve ser definida")
    private Integer idade;

    @NotEmpty(message = "A espécie do animal deve ser definida")
    private String especie;

    @Nullable
    private LocalDate dataNascimento;

    @NotNull @Range(min = 1, max = 5, message = "O nível de fofura deve ser um número entre 1 e 5")
    private Integer nivelFofura;

    @NotNull @Range(min = 1, max = 5, message = "O nível de carinho deve ser um número entre 1 e 5")
    private Integer nivelCarinho;

    @Email (message = "Você precisa digitar um endereço de e-mail válido")
    private String email;

}
