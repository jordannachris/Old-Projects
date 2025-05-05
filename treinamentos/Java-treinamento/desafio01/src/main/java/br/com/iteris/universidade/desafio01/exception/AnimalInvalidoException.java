package br.com.iteris.universidade.desafio01.exception;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.ResponseStatus;

@ResponseStatus(code = HttpStatus.BAD_REQUEST)
public class AnimalInvalidoException extends RuntimeException {

    public AnimalInvalidoException(String message) {
        super(message);
    }

}
