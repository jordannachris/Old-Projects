package br.com.iteris.universidade.desafio02.service;


import br.com.iteris.universidade.desafio02.domain.dto.PrioridadeUpdateRequest;
import br.com.iteris.universidade.desafio02.domain.dto.TarefaCreateRequest;
import br.com.iteris.universidade.desafio02.domain.dto.ConcluidoUpdateRequest;
import br.com.iteris.universidade.desafio02.domain.dto.TarefaFilterRequest;
import br.com.iteris.universidade.desafio02.domain.entity.Tarefa;
import br.com.iteris.universidade.desafio02.exception.TarefaNaoEncontradaException;
import br.com.iteris.universidade.desafio02.repository.TarefasRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.PageRequest;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class TarefasService {

    private final TarefasRepository repository;

    @Autowired
    public TarefasService(TarefasRepository repository) {
        this.repository = repository;
    }

    public Tarefa criarTarefa(TarefaCreateRequest tarefaCreateRequest) {
        // Regra

        // Regra de prioridade
        if (tarefaCreateRequest.getPrioridade() == null) {
            tarefaCreateRequest.setPrioridade(5);
        }

        //tudo certo, só cadastrar
        var novaTarefa = new Tarefa();
        novaTarefa.setTitulo(tarefaCreateRequest.getTitulo());
        novaTarefa.setDescricao(tarefaCreateRequest.getDescricao());
        novaTarefa.setPrioridade(tarefaCreateRequest.getPrioridade());
        novaTarefa.setConcluido(false);

        return repository.save(novaTarefa);

    }

    public Page<Tarefa> listar(TarefaFilterRequest filter) {
        return repository.listarComFiltroNativo(filter.getConcluido(), PageRequest.of(
                filter.getPagina(),
                filter.getTamanho()
        ));
    }


    public Tarefa buscarPorId(Integer idTarefa) {
        var tarefaEncontrada = repository.findById(idTarefa);

        if (tarefaEncontrada.isEmpty()) {
            throw new TarefaNaoEncontradaException();
        }

        return tarefaEncontrada.get();
    }




    //ATUALIZAR CAMPO "CONCLUIDO"
    public Tarefa atualizarTarefa(Integer idTarefa, ConcluidoUpdateRequest concluidoUpdateRequest) {
        var tarefaEncontrada = repository.findById(idTarefa);

        if (tarefaEncontrada.isEmpty()) {
            throw new TarefaNaoEncontradaException();
        }

        var tarefa = tarefaEncontrada.get();
        tarefa.setConcluido(concluidoUpdateRequest.getConcluido());

        return repository.save(tarefa);
    }


    //ATUALIZAR CAMPO "PRIORIDADE"
    public Tarefa atualizarTarefa(Integer idTarefa, PrioridadeUpdateRequest prioridadeUpdateRequest) {
        var tarefaEncontrada = repository.findById(idTarefa);

        if (tarefaEncontrada.isEmpty()) {
            throw new TarefaNaoEncontradaException();
        }

        var tarefa = tarefaEncontrada.get();
        tarefa.setPrioridade(prioridadeUpdateRequest.getPrioridade());

        return repository.save(tarefa);
    }



    public Tarefa deletarTarefa(Integer idTarefa) {
        var tarefaEncontrada = repository.findById(idTarefa);

        if (tarefaEncontrada.isEmpty()) {
            throw new TarefaNaoEncontradaException();
        }

        var tarefa = tarefaEncontrada.get();
        repository.delete(tarefa);

        return tarefa;
    }

}
