package br.com.iteris.universidade.desafio01.service;

import br.com.iteris.universidade.desafio01.domain.dto.AnimalCreateRequest;
import br.com.iteris.universidade.desafio01.domain.dto.AnimalUpdateRequest;
import br.com.iteris.universidade.desafio01.domain.entity.Animal;
import br.com.iteris.universidade.desafio01.exception.AnimalInvalidoException;
import br.com.iteris.universidade.desafio01.exception.AnimalNaoEncontradoException;
import br.com.iteris.universidade.desafio01.exception.TeaPotException;
import org.springframework.stereotype.Service;


import java.time.LocalDate;
import java.time.Year;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;

@Service
public class AnimaisService {
    private static List<Animal> listaDeAnimais; // fake, só para aprendizado
    private static int proximoId = 1;


    public AnimaisService() {
        if (listaDeAnimais == null) {
            listaDeAnimais = new ArrayList<>();
        }
    }


    public Animal criarAnimal (AnimalCreateRequest animalCreateRequest) {

        // REGRAS
        //REGRAS DE ESPÉCIE
        if (
                (animalCreateRequest.getEspecie() == null) ||
                (!animalCreateRequest.getEspecie().equals("Cachorro") && !animalCreateRequest.getEspecie().equals("cachorro"))  &&
                (!animalCreateRequest.getEspecie().equals("Gato") && !animalCreateRequest.getEspecie().equals("gato"))  &&
                (!animalCreateRequest.getEspecie().equals("Coelho") && !animalCreateRequest.getEspecie().equals("coelho"))  &&
                (!animalCreateRequest.getEspecie().equals("Capivara") && !animalCreateRequest.getEspecie().equals("capivara"))
        )
        {
            throw new AnimalInvalidoException("A Espécie do animal precisa ser uma das seguintes opções: Cachorro, Gato, Coelho ou Capivara");
        }

        //REGRAS DE DATA DE NASCIMENTO
        if(animalCreateRequest.getDataNascimento() != null) {

            if (animalCreateRequest.getDataNascimento().isAfter(LocalDate.now())) {
                throw new TeaPotException("A data de nascimento não pode ser depois de hoje");
            }
        }


        //tudo certo, só cadastrar
        var novoAnimal = new Animal(
                                    proximoId++,
                                    animalCreateRequest.getNome(),
                                    animalCreateRequest.getIdade(),
                                    animalCreateRequest.getEspecie(),
                                    animalCreateRequest.getDataNascimento(),
                                    animalCreateRequest.getNivelFofura(),
                                    animalCreateRequest.getNivelCarinho(),
                                    animalCreateRequest.getEmail()
                                    );

        listaDeAnimais.add(novoAnimal);

        return novoAnimal;
    }


    public List<Animal> listar() {
        return listaDeAnimais;
    }

    public Animal buscarPorId(Integer idAnimal) {
        var animalEncontrado = listaDeAnimais.stream()
                .filter(animal -> animal.getIdAnimal() == idAnimal)
                .findFirst();

        if (animalEncontrado.isEmpty()) {
            throw new AnimalNaoEncontradoException();
        }

        return animalEncontrado.get();
    }


    public Animal buscarPorNome(String nome) {
        var animalEncontrado = listaDeAnimais.stream()
                .filter(animal -> animal.getNome().equals(nome))
                .findFirst();

        if (animalEncontrado.isEmpty()) {
            throw new AnimalNaoEncontradoException();
        }

        return animalEncontrado.get();
    }


    public Animal atualizarAnimal(Integer idAnimal, AnimalUpdateRequest animalUpdateRequest) {
        var animalEncontrado = listaDeAnimais.stream()
                .filter(animal -> animal.getIdAnimal() == idAnimal)
                .findFirst();

        if (animalEncontrado.isEmpty()) {
            throw new AnimalNaoEncontradoException();
        }

        var animal = animalEncontrado.get();

        //animal.setIdade(animalUpdateRequest.getIdade());
        //animal.setNivelFofura(animalUpdateRequest.getNivelFofura());
        //animal.setNivelCarinho(animalUpdateRequest.getNivelCarinho());
        animal.setEmail(animalUpdateRequest.getEmail());

        return animalEncontrado.get();
    }



    public Animal deletarAnimal(Integer idAnimal) {
        var animalEncontrado = listaDeAnimais.stream()
                .filter(animal -> animal.getIdAnimal() == idAnimal)
                .findFirst();

        if (animalEncontrado.isEmpty()) {
            throw new AnimalNaoEncontradoException();
        }

        var animal = animalEncontrado.get();
        listaDeAnimais.remove(animal);

        return animal;
    }

}
