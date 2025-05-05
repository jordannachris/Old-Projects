package br.com.iteris.universidade.desafio02.domain.dto;


import lombok.Data;
import org.hibernate.validator.constraints.Range;
import org.springframework.lang.Nullable;

import javax.validation.constraints.NotEmpty;


@Data
public class TarefaCreateRequest {

    @NotEmpty(message = "O titulo da tarefa deve ser definido")
    private String titulo;

    private String descricao;

    //private Boolean concluido; ------> Não precisa colocar o "Booolean Concluido" aqui no CREATE REQUEST
    //                           ------> CREATE REQUEST é usado para coisas que o usuário precisa digitar/infomar
    //                           ------> O usuário não vai precisar informar que a tarefa foi Concluída

    @Nullable @Range(min = 1, max = 5, message = "A prioridade deve ser um número entre 1 e 5")
    private Integer prioridade;
}
