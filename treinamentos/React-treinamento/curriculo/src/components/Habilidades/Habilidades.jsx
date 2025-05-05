import React from "react";
import './Habilidades.css';

function Habilidades() {
    return (
        <div className="habilidades">
            <h3>Habilidades</h3>

            <div className="habilidades-section">
                <section className="hard-skills">
                    <h4>JavaScript</h4>
                    <div className="progress-bar" id="javascript"></div>
                    <h4>HTML</h4>
                    <div className="progress-bar" id="html"></div>
                    <h4>CSS</h4>
                    <div className="progress-bar" id="css"></div>
                </section>

                <section className="soft-skills">
                    <h4>Organização</h4>
                    <div className="progress-bar" id="organizacao"></div>
                    <h4>Criatividade</h4>
                    <div className="progress-bar" id="criatividade"></div>
                    <h4>Trabalho em Equipe</h4>
                    <div className="progress-bar" id="trabalhoemequipe"></div>
                </section>
            </div>
        </div>
    );
}

export default Habilidades;