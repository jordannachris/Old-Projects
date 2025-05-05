package br.com.iteris.universidade.desafio02.exception;

 import org.springframework.http.HttpStatus;
 import org.springframework.web.bind.annotation.ResponseStatus;


@ResponseStatus(code = HttpStatus.NOT_FOUND)
public class TarefaNaoEncontradaException extends RuntimeException {

    public TarefaNaoEncontradaException() {
        super("Não foi encontrada Tarefa para a entrada");
    }

}
