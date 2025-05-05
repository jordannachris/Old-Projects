import React from "react";
import './Experiencias.css';

function Experiencias() {
    return (
        <div className="experiencias">
            <h3>Experiências</h3>
            <ul>
                <li>
                    <h4>Desenvolvedora Web</h4>
                    <h5>Iteris Consultoria e Software</h5>
                    <p>2023 - Atualmente</p>
                </li>
                <li>
                    <h4>Estagiária de Consultoria</h4>
                    <h5>Iteris Consultoria e Software</h5>
                    <p>2021 - 2022</p>
                </li>
                <li>
                    <h4>Estagiária de TI</h4>
                    <h5>Agência Brasil Central</h5>
                    <p>2020 - 2021</p>
                </li>
                <li>
                    <h4>Monitora</h4>
                    <h5>Universidade Federal de Goiás</h5>
                    <p>2019 - 2019</p>
                </li>
            </ul>
        </div>
    );
}

export default Experiencias;