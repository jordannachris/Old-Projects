package br.com.iteris.universidade.desafio01.domain.dto;

import lombok.Data;
import org.hibernate.validator.constraints.Range;
import org.springframework.lang.Nullable;

import javax.validation.constraints.Email;
import javax.validation.constraints.NotEmpty;
import javax.validation.constraints.NotNull;
import java.util.Date;

@Data
public class AnimalUpdateRequest {

    //@NotNull(message = "A idade do animal deve ser definida")
    //private Integer idade;

    //@NotNull @Range(min = 1, max = 5, message = "O nível de fofura deve ser um número entre 1 e 5")
    //private Integer nivelFofura;

    //@NotNull @Range(min = 1, max = 5, message = "O nível de carinho deve ser um número entre 1 e 5")
    //private Integer nivelCarinho;

    @Email(message = "Você precisa digitar um endereço de e-mail válido")
    private String email;

}
