package br.com.iteris.universidade.desafio02.domain.entity;

 import lombok.AllArgsConstructor;
 import lombok.Data;
 import lombok.NoArgsConstructor;

 import javax.persistence.Entity;
 import javax.persistence.GeneratedValue;
 import javax.persistence.GenerationType;
 import javax.persistence.Id;

@Data
@Entity()
@NoArgsConstructor
@AllArgsConstructor
public class Tarefa {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idTarefa;

    private String titulo;
    private String descricao;
    private Integer prioridade;
    private Boolean concluido;

}
