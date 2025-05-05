import React, { useState } from 'react';
import Card from '@material-ui/core/Card';
import CardContent from '@material-ui/core/CardContent';
import TextField from '@material-ui/core/TextField';
import ButtonEventos from '../../components/button/ButtonEventos';
import { getParticipantes } from '../../services/eventosApiService';
import { getParticipantesById } from '../../services/eventosApiService';
import './Participantes.css';
import ParticipantesCard from '../../components/ParticipantesCard/ParticipantesCard';
import Snackbar from '@material-ui/core/Snackbar';
import Alert from '../../components/AlertCadastro';

const Participantes = () => {

    const [lista, setLista] = useState([]);
    const [id, setId] = useState();
    const [open, setOpen] = useState(false);
    const [mensagem, setMensagem] = useState('');
    const [tipoAlert, setTipoAlert] = useState('success');

    function handleSubmitTodos(event) {
        event.preventDefault();
        if (event.target.checkValidity()) {
            getParticipantes()
                .then((data) => {
                    setLista(data);
                });
        }
    }

    function handleSubmitFiltro(event) {
        event.preventDefault();
        if (event.target.checkValidity()) {
            getParticipantesById(id)
                .then((data) => {
                    setLista(data);
                    if(data.length === 0){
                        setOpen(true);
                        setMensagem('Não há participantes inscritos neste evento')
                        setTipoAlert('error');
                    }
                });
        }
    }
    
    const handleCloseAlert = (event, reason) => {
        if (reason === 'clickaway') {
            return;
        }
        setOpen(false);
    };

    return (
        <div className="participantes-container">

            <Card className="filtro-card">
                <CardContent>
                    <form noValidate autoComplete="off" className="listar-participantes-form" >
                        <h2>Listar Participantes</h2>

                        <TextField id="id" label="Id do Evento" variant="outlined" value={id} onChange={(event) => {
                            setId(event.target.value)
                        }} />
                        <div className="botoes-participacao">
                            <ButtonEventos type="submit" titulo="Filtrar" onClick={handleSubmitFiltro} />
                            <ButtonEventos type="submit" titulo="Listar todos" onClick={handleSubmitTodos} />
                        </div>
                    </form>
                </CardContent>
            </Card>

            <div>
                {lista.map((item, i) => {
                    return (

                        <div className="filtro-cards" key={i}>
                            <ParticipantesCard item={item} funcao={handleSubmitFiltro}/>
                        </div>
                    );
                })}

            </div>

            <Snackbar open={open} autoHideDuration={2000} onClose={handleCloseAlert}>
                <Alert onClose={handleCloseAlert} severity={tipoAlert}>
                    {mensagem}
                </Alert>
            </Snackbar>

        </div>
    )
}



export default Participantes;
