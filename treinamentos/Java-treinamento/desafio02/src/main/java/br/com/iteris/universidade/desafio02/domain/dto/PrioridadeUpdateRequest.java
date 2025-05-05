package br.com.iteris.universidade.desafio02.domain.dto;

import lombok.Data;
import org.hibernate.validator.constraints.Range;
import org.springframework.lang.Nullable;


@Data
public class PrioridadeUpdateRequest {

    @Nullable
    @Range(min = 1, max = 5, message = "A prioridade deve ser um número entre 1 e 5")
    private Integer prioridade;

}
