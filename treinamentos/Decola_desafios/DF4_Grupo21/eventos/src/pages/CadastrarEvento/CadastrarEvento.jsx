import React, { useState } from "react";
import Card from "@material-ui/core/Card";
import CardContent from "@material-ui/core/CardContent";
import TextField from "@material-ui/core/TextField";
import {
  KeyboardDatePicker,
  MuiPickersUtilsProvider,
} from "@material-ui/pickers";
import DateFnsUtils from "@date-io/date-fns";
import Select from "@material-ui/core/Select";
import InputLabel from "@material-ui/core/InputLabel";
import MenuItem from "@material-ui/core/MenuItem";
import FormControl from "@material-ui/core/FormControl";
import "./CadastrarEvento.css";
import { postEvento } from "../../services/eventosApiService";
import { useHistory } from "react-router-dom";
import Snackbar from '@material-ui/core/Snackbar';
import Alert from '../../components/AlertCadastro';
import ButtonEventos from '../../components/button/ButtonEventos';

const CadastrarEvento = () => {

    let history = useHistory();
    const [open, setOpen] = useState(false);
    const [mensagem, setMensagem] = useState('');
    const [tipoAlert, setTipoAlert] = useState('success');

    const [novoEvento, setNovoEvento] = useState({
        Nome: '',
        Descricao: '',
        Local: '',
        Categoria: ''
    })

    function handleSubmit(event) {
        event.preventDefault();
        if (event.target.checkValidity()) {
            postEvento(novoEvento)
                .then((response) => {
                    if(response.data.sucesso === true){
                        setMensagem('Evento cadastrado com sucesso!')
                        setTipoAlert('success');
                    }
                    
                    setTimeout(() => {
                        history.push("/");
                    }, 1500);
                }).catch(error => {
                    if(typeof error.response.data === 'string'){
                        setTipoAlert('error');
                        setMensagem(error.response.data);
                    } else {
                        setTipoAlert('error');
                        setMensagem('Não foi possível realizar o cadastro')
                    }
                })
                setOpen(true);
        }
        else {
            setTipoAlert('error');
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
        <div className="cadastrar-container">

            <Card className="cadastrar-card">
                <CardContent>
                    <form noValidate autoComplete="off" className="cadastrar-form" onSubmit={handleSubmit}>
                        <h2>Cadastrar Evento</h2>

                        <TextField id="nome" label="Nome" variant="outlined" className="campos-cadastro" value={novoEvento.Nome} onChange={(event) => {
                            setNovoEvento({ ...novoEvento, Nome: event.target.value })
                        }} />

                        <TextField id="descricao" label="Descrição" variant="outlined" className="campos-cadastro" multiline rows={4} value={novoEvento.Descricao} onChange={(event) => {
                            setNovoEvento({ ...novoEvento, Descricao: event.target.value })
                        }} />

                        <TextField id="local" label="Local" variant="outlined" className="campos-cadastro" value={novoEvento.Local} onChange={(event) => {
                            setNovoEvento({ ...novoEvento, Local: event.target.value })
                        }} />

                        <TextField id="vagas" label="Limite de Vagas" variant="outlined" className="campos-cadastro" value={novoEvento.LimiteVagas} onChange={(event) => {
                            setNovoEvento({ ...novoEvento, LimiteVagas: +event.target.value })
                        }} />

                        <FormControl>
                            <InputLabel id="demo-simple-select-label">Categoria</InputLabel>
                            <Select
                                labelId="categorias-label"
                                id="categorias-select"
                                placeholder="Categoria"
                                className="campos-cadastro" 
                                value={novoEvento.Categoria}
                                onChange={(event) => {
                                    setNovoEvento({ ...novoEvento, Categoria: event.target.value })
                                }}
                            >
                                <MenuItem value={1}>Backend</MenuItem>
                                <MenuItem value={2}>Frontend</MenuItem>
                                <MenuItem value={3} >Mobile</MenuItem>
                                <MenuItem value={4}>Cloud & DevOps</MenuItem>
                                <MenuItem value={5}>Modern Workplaces</MenuItem>
                                <MenuItem value={6}>Ui/UX</MenuItem>
                                <MenuItem value={7}>Data & Analytics</MenuItem>
                                <MenuItem value={8}>Agilidade e Qualidade</MenuItem>

                            </Select>
                        </FormControl>

                        <div className="cadastrar-datas">
                            <MuiPickersUtilsProvider utils={DateFnsUtils} >
                                <KeyboardDatePicker
                                    disableToolbar
                                    variant="inline"
                                    format="dd/MM/yyyy"
                                    margin="normal"
                                    id="dataInicio"
                                    label="Data de Início"
                                    value={novoEvento.DataHoraInicio}
                                    onChange={(event) => {
                                        setNovoEvento({ ...novoEvento, DataHoraInicio: event.toISOString().toString() })
                                    }}
                                />
                                <KeyboardDatePicker
                                    disableToolbar
                                    variant="inline"
                                    format="dd/MM/yyyy"
                                    margin="normal"
                                    id="dataFim"
                                    label="Data Fim"
                                    value={novoEvento.DataHoraFim}
                                    onChange={(event) => {
                                        setNovoEvento({ ...novoEvento, DataHoraFim: event.toISOString().toString() })
                                    }}
                                />
                            </MuiPickersUtilsProvider>
                        </div>

                        <ButtonEventos type="submit" titulo="Cadastrar" />
                    </form>
                </CardContent>
            </Card>

            <Snackbar open={open} autoHideDuration={2000} onClose={handleCloseAlert}>
                <Alert onClose={handleCloseAlert} severity={tipoAlert}>
                    {mensagem}
                </Alert>
            </Snackbar>


        </div>
    )
}

export default CadastrarEvento
