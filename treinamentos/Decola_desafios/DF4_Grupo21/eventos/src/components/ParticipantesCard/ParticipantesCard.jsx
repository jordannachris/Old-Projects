import React, { useState } from 'react';
import Card from '@material-ui/core/Card';
import './ParticipantesCard.css';
import ButtonEventos from '../button/ButtonEventos';
import { putFlagPresente } from '../../services/eventosApiService';
import Snackbar from '@material-ui/core/Snackbar';
import Alert from '../../components/AlertCadastro';

const ParticipantesCard = ({ item, funcao }) => {

    const [open, setOpen] = useState(false);
    const [mensagem, setMensagem] = useState('');
    const idParticipacao = item.idParticipacao;
    const [tipoAlert, setTipoAlert] = useState('success');

    function handleSubmitPresente(event) {
        event.preventDefault();
        if (event.target.checkValidity()) {
            putFlagPresente(idParticipacao)
                .then((response) => {
                    console.log(response);
                    if (response.status === 200 ) {
                        setMensagem('Participação cadastrada com sucesso!')
                        funcao(event);
                    } 
                    // else if(response.data.flagPresente && response.data.flagPresente === true) {
                    //     setMensagem('Participação já confirmada')
                    //     setTipoAlert('error');
                    // }
                }).catch(error => {
                    if (typeof error.response.data === 'string') {
                        setMensagem(error.response.data);
                        setTipoAlert('error');
                    } else {
                        setMensagem('Não foi possível cadastrar a presença')
                        setTipoAlert('error');
                    }
                })
            setOpen(true);
        }
        else {
            setOpen(true);
            setMensagem('Ocorreu um erro')
        }
    }

    const handleCloseAlert = (event, reason) => {
        if (reason === 'clickaway') {
            return;
        }
        setOpen(false);
    };

    return (
        <>
            <Card className="participantes-card">
                <div className="participantes-texto">
                    <p><span className='dados-titulo'>Id de Participação:</span> {item.idParticipacao}</p>
                    <p><span className='dados-titulo'>Id do Evento:</span> {item.idEvento}</p>
                    <p><span className='dados-titulo'>Login do Participante:</span> {item.loginParticipante}</p>
                    <p><span className='dados-titulo'>Presente?</span> {item.flagPresente === false ? 'Não confirmado' : 'Presente'}</p>
                    <p><span className='dados-titulo'>Nota:</span> {item.nota == null ? 'Sem nota' : item.nota}</p>
                    <p><span className='dados-titulo'>Comentário:</span> {item.comentario == null ? 'Sem comentário' : item.comentario}</p>
                </div>
                <div className="btn-presenca">
                    <ButtonEventos titulo="Marcar Presença" onClick={handleSubmitPresente} disabled={item.flagPresente}/>
                </div>
            </Card>

            <Snackbar open={open} autoHideDuration={2000} onClose={handleCloseAlert}>
                <Alert onClose={handleCloseAlert} severity={tipoAlert}>
                    {mensagem}
                </Alert>
            </Snackbar>

        </>
    )
}

export default ParticipantesCard
