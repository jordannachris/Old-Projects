import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Todo } from 'src/models/todo.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public listaTarefas: Todo[] = [];
  public titulo: String = 'Minhas Tarefas';
  public form: FormGroup;


  constructor(private formulario: FormBuilder) {
    this.form = this.formulario.group({
      descricao: ['',
        Validators.compose([
          Validators.minLength(3),
          Validators.maxLength(60),
          Validators.required
        ])]
    });
    // this.listaTarefas.push(new Todo(1, 'Passear com o cachorro', false));
    // this.listaTarefas.push(new Todo(2, 'Ir ao supermercado', false));
    // this.listaTarefas.push(new Todo(3, 'Cortar o cabelo', true));

    // this.carregarDadosTarefa();
  }

  adicionarTarefa() {
    const descricao = this.form.controls['descricao'].value;
    const id = this.listaTarefas.length + 1;
    this.listaTarefas.push(new Todo(id, descricao, false));
    this.salvarDadosTarefa();
    this.limparTexto();
  }

  limparTexto() {
    this.form.reset();
  }

  removerTarefa(tarefa: Todo) {
    const index = this.listaTarefas.indexOf(tarefa);
    //quando não é encontrado nada, o index recebe -1
    if (index !== -1) {
      this.listaTarefas.splice(index, 1); //remove 1 item a partir daquele que tem o mesmo index (ou seja, remove apenas o item com o mesmo index)
    }
    this.salvarDadosTarefa();
  }

  marcarComoConcluida(tarefa: Todo) {
    tarefa.concluida = true;
    this.salvarDadosTarefa();
  }

  marcarComoPendente(tarefa: Todo) {
    tarefa.concluida = false;
    this.salvarDadosTarefa();
  }

  salvarDadosTarefa() {
    const dados = JSON.stringify(this.listaTarefas);
    localStorage.setItem('listaTarefas', dados);
  }

  // carregarDadosTarefa(){
  //   const dados = localStorage.getItem('listaTarefas');
  //   this.listaTarefas = JSON.parse(dados);
  // }

}
