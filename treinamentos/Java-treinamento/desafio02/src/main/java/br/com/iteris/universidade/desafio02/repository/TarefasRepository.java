package br.com.iteris.universidade.desafio02.repository;

import br.com.iteris.universidade.desafio02.domain.entity.Tarefa;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository
public interface TarefasRepository extends JpaRepository<Tarefa, Integer> {

    //Optional<Tarefa> findByConcluidoContaining(Boolean concluido);

    @Query(
            nativeQuery = true,
            value = "SELECT * FROM tarefa WHERE (prioridade >= 3) AND (concluido = :concluido)",
            countQuery = "SELECT count(*) FROM tarefa WHERE (prioridade >= 3) AND (concluido = :concluido)"
    )
    Page<Tarefa> listarComFiltroNativo(@Param("concluido") Boolean concluido, Pageable pageable);

    @Query("SELECT a FROM Tarefa a WHERE (prioridade >= 3) AND (concluido = :concluido)")
    Page<Tarefa> listarComFiltro(@Param("concluido") Boolean concluido, Pageable pageable);
}