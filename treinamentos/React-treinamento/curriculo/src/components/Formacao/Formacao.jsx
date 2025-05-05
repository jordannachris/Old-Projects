import React from "react";
import './Formacao.css';

function Formacao() {
    return (
        <div className="formacao">
            <h3>Formação</h3>
            <ul>
                <li>
                    <h4>Bacharelado em Sistemas de Informação</h4>
                    <p>UFG, Universidade Federal de Goiás</p>
                    <p>2018 - 2022</p>
                </li>
                <li>
                    <h4>Graduação em Análise e Desenvolvimento de Sistemas</h4>
                    <p>UNIP, Universidade Paulista</p>
                    <p>2016 - 2018</p>
                </li>
            </ul>
        </div>
    );
}

export default Formacao;