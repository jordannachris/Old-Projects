package br.com.iteris.universidade.desafio02.domain.dto;

import lombok.Data;
import javax.validation.constraints.NotNull;

@Data
public class TarefaFilterRequest {

    //private Integer prioridade;
    private Boolean concluido;

    @NotNull(message = "Tamanho da página deve ser definido")
    private Integer tamanho;

    @NotNull(message = "Página deve ser definido")
    private Integer pagina;
}
