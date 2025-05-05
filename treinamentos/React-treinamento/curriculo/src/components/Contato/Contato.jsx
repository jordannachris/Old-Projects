import React from "react";
import './Contato.css';
import { GrMail } from 'react-icons/gr';
import { MdSmartphone } from 'react-icons/md';
import { MdLocationOn } from 'react-icons/md';

function Contato() {
    return (
        <div className="contato">
            <h3>Contato</h3>
            <ul className="informacoes-contato">
                <li>jordanna.costa@iteris.com.br&nbsp;<GrMail size={19}/></li>

                <li>(62) 00000-0000&nbsp;<MdSmartphone size={19}/></li>

                <li>Rua 38, S/N, Jd Bela Vista. Goiânia/GO&nbsp;<MdLocationOn size={19}/></li>
            </ul>
        </div>
    );
}

export default Contato;