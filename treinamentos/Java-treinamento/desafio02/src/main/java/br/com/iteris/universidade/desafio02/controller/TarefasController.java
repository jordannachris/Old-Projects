package br.com.iteris.universidade.desafio02.controller;

import br.com.iteris.universidade.desafio02.domain.dto.ConcluidoUpdateRequest;
import br.com.iteris.universidade.desafio02.domain.dto.PrioridadeUpdateRequest;
import br.com.iteris.universidade.desafio02.domain.dto.TarefaCreateRequest;
import br.com.iteris.universidade.desafio02.domain.dto.TarefaFilterRequest;
import br.com.iteris.universidade.desafio02.domain.entity.Tarefa;
import br.com.iteris.universidade.desafio02.service.TarefasService;
import org.springframework.data.domain.Page;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.validation.Valid;
import java.util.ArrayList;
import java.util.List;

@RestController
public class TarefasController {

    private final TarefasService service;

    public TarefasController(TarefasService service) {

        this.service = service;
    }


    // Lista todos os Albuns
    @GetMapping(value = "api/tarefas")
    public ResponseEntity<Page<Tarefa>> listar(@Valid TarefaFilterRequest filter) {
        var listaDeTarefas = service.listar(filter);
        return ResponseEntity.ok(listaDeTarefas);
    }

    // Consulta o Album por id
    @GetMapping(value = "api/tarefas/{id}")
    public ResponseEntity<Tarefa> buscarPorId(@PathVariable Integer id) {
        var tarefaResponse = service.buscarPorId(id);
        return ResponseEntity.ok(tarefaResponse);
    }



    @PostMapping(value = "api/tarefas")
    public ResponseEntity<Tarefa> criarTarefa(@RequestBody @Valid TarefaCreateRequest tarefa) {
        var tarefaResponse = service.criarTarefa(tarefa);
        return ResponseEntity.ok(tarefaResponse);
    }


    @PutMapping(value = "api/tarefas/{idTarefa}/status")
    public ResponseEntity<Tarefa> atualizarTarefa(
            @PathVariable Integer idTarefa,
            @RequestBody @Valid ConcluidoUpdateRequest concluidoUpdateRequest) {
        var tarefa = service.atualizarTarefa(idTarefa, concluidoUpdateRequest);
        return ResponseEntity.ok(tarefa);
    }

    @PutMapping(value = "api/tarefas/{idTarefa}/prioridade")
    public ResponseEntity<Tarefa> atualizarTarefa(
            @PathVariable Integer idTarefa,
            @RequestBody @Valid PrioridadeUpdateRequest prioridadeUpdateRequest) {
        var tarefa = service.atualizarTarefa(idTarefa, prioridadeUpdateRequest);
        return ResponseEntity.ok(tarefa);
    }


    @DeleteMapping(value = "api/tarefas/{idTarefa}")
    public ResponseEntity<Tarefa> deletarTarefa(@PathVariable Integer idTarefa) {
        var tarefa = service.deletarTarefa(idTarefa);
        return ResponseEntity.ok(tarefa);
    }



}
