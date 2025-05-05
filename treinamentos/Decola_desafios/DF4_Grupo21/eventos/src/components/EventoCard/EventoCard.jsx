import React, { useState } from 'react';
import Card from "@material-ui/core/Card";
import Button from '@material-ui/core/Button';
import CardContent from "@material-ui/core/CardContent";
import Typography from "@material-ui/core/Typography";
import { putCancelarEvento } from "../../services/eventosApiService";
import { putConcluirEvento } from '../../services/eventosApiService';
import { putIniciarEvento } from '../../services/eventosApiService';
import "./EventoCard.css";
import Snackbar from '@material-ui/core/Snackbar';
import Alert from '../../components/AlertCadastro';


const EventoCard = ({ propEvento, propAtualizaEvento }) => {

    const [open, setOpen] = useState(false);
    const [mensagem, setMensagem] = useState('');
    const idEvento = propEvento.idEvento;
    const [tipoAlert, setTipoAlert] = useState('success');

    function arrumandoData(dataFeia) {
        let date = new Date(dataFeia);

        let dia = date.getDate();
        let mes = date.getMonth() + 1;
        let ano = date.getFullYear();

        if (dia < 10) {
            dia = '0' + dia;
        }
        if (mes < 10) {
            mes = '0' + mes;
        }
        return dia + "/" + mes + "/" + ano;
    }

    function arrumandoStatus(statusFeio){
        // console.log(`Status = ${statusFeio}`);
        if(statusFeio === 1){
            return "1 - Aberto para inscrições"
        }else if(statusFeio === 2){
            return "2 - Em andamento"
        }else if(statusFeio === 3){
            return "3 - Concluído"
        }else if(statusFeio === 4){
            return "4 - Cancelado"
        }
    }

    function arrumandoCategoria(categoriaFeia){
        
        if(categoriaFeia === 1){
            return "1 - Backend"
        }else if(categoriaFeia === 2){
            return "2 - Frontend"
        }else if(categoriaFeia === 3){
            return "3 - Mobile"
        }else if(categoriaFeia === 4){
            return "4 - Cloud & DevOps"
        }else if(categoriaFeia === 5){
            return "5 - Modern Workplaces"
        }else if(categoriaFeia === 6){
            return "6 - UI/UX"
        }else if(categoriaFeia === 7){
            return "7 - Data & Analytics"
        }else if(categoriaFeia === 8){
            return "8 - Agilidade & Qualidade "
        }
    }


    function handleIniciarEvento(event) {
        event.preventDefault();

        if (propEvento.eventoStatus === 1) {
            putIniciarEvento(idEvento)
                .then((response) => {
                    console.log(response);
                    if (response.status === 200) {
                        setMensagem('Evento iniciado com sucesso!')
                        propAtualizaEvento(event);
                    }
                }).catch(error => {
                    console.log(error);
                    if (typeof error.response === 'string') {
                        setMensagem(error.response.data);
                    } else {
                        setTipoAlert('error')
                        setMensagem('Só é possível iniciar o evento no dia de sua ocorrência!')
                    }
                })
        }
        setOpen(true);
    }

    function handleConcluirEvento(event) {
        event.preventDefault();

        if (propEvento.eventoStatus === 2) {
            putConcluirEvento(idEvento)
                .then((response) => {
                    console.log(response);
                    if (response.status === 200) {
                        setMensagem('Evento concluido com sucesso!')
                        propAtualizaEvento(event);
                    }
                }).catch(error => {
                    if (typeof error.response.data === 'string') {
                        setMensagem(error.response.data);
                    }
                })
        }
        setOpen(true);
    }

    function handleCancelarEvento(event) {
        event.preventDefault();

        if (propEvento.eventoStatus !== 4) {
            putCancelarEvento(idEvento)
                .then((response) => {
                    console.log(response);
                    if (response.status === 200) {
                        setMensagem('Evento cancelado com sucesso!')
                        propAtualizaEvento(event);
                    }
                }).catch(error => {
                    if (typeof error.response.data === 'string') {
                        setMensagem(error.response.data);
                    } else {
                        setTipoAlert('error')
                        setMensagem('Só é possível cancelar o evento ANTES de sua data de ocorrência!')
                    }
                })
        }
        setOpen(true);
    }

    const handleCloseAlert = (event, reason) => {
        if (reason === 'clickaway') {
            return;
        }
        setOpen(false);
    };

    return (
        <>
            <Card className="eventoCard">
                <CardContent className="eventoCard-content">
                    <div className="eventoCard-informacoes">
                        <Typography className="eventoCard-informacoes-linhas" gutterBottom variant="h6" component="h2">
                            <section className="eventoCard-informacoes-linhas-dado">Título:</section>&nbsp;{propEvento.nome}
                        </Typography>

                        <Typography className="eventoCard-informacoes-linhas" gutterBottom variant="h6" component="h2">
                            <section className="eventoCard-informacoes-linhas-dado">Id Evento:</section>&nbsp;{propEvento.idEvento}
                        </Typography>

                        <Typography className="eventoCard-informacoes-linhas" gutterBottom variant="h6" component="h2">
                            <section className="eventoCard-informacoes-linhas-dado">Limite de Vagas:</section>&nbsp;{propEvento.limiteVagas}
                        </Typography>

                        <Typography className="eventoCard-informacoes-linhas" gutterBottom variant="h6" component="h2">
                            <section className="eventoCard-informacoes-linhas-dado">Data do evento:</section>&nbsp;{arrumandoData(propEvento.dataHoraInicio)}
                        </Typography>

                        <Typography className="eventoCard-informacoes-linhas" gutterBottom variant="h6" component="h2">
                            <section className="eventoCard-informacoes-linhas-dado">Status:</section>&nbsp;{arrumandoStatus(propEvento.eventoStatus)}
                        </Typography>

                        <Typography className="eventoCard-informacoes-linhas" gutterBottom variant="h6" component="h2">
                            <section className="eventoCard-informacoes-linhas-dado">Categoria:</section>&nbsp;{arrumandoCategoria(propEvento.categoria)}
                        </Typography>
                    </div>

                    <div className="eventoCard-botoes">
                        <Button variant="contained" color="primary" onClick={handleIniciarEvento} disabled={propEvento.eventoStatus === 1 ? false : true}>Iniciar</Button>
                        <Button variant="contained" color="primary" onClick={handleConcluirEvento} disabled={propEvento.eventoStatus === 2 ? false : true}>Concluir</Button>
                        <Button variant="contained" color="primary" onClick={handleCancelarEvento} disabled={propEvento.eventoStatus !== 4 ? false : true}>Cancelar</Button>
                    </div>
                </CardContent>
            </Card>

            <Snackbar open={open} autoHideDuration={3000} onClose={handleCloseAlert}>
                <Alert onClose={handleCloseAlert} severity={tipoAlert}>
                    {mensagem}
                </Alert>
            </Snackbar>

        </>
    );
}

export default EventoCard;
