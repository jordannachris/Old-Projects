package br.com.iteris.universidade.desafio01.exception;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.ResponseStatus;

@ResponseStatus(code = HttpStatus.I_AM_A_TEAPOT)
public class TeaPotException extends RuntimeException {

    public TeaPotException(String message) {
        super(message);
    }
}
