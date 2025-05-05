package br.com.iteris.universidade.desafio01.exception;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.ResponseStatus;


@ResponseStatus(code = HttpStatus.NOT_FOUND)
public class AnimalNaoEncontradoException extends RuntimeException {

    public AnimalNaoEncontradoException() {
        super("Não foi encontrado Animal para a entrada");
    }

}
