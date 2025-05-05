import React, { useState } from "react";
import EventoCard from "../../components/EventoCard";
import { getEventosByCategoria } from "../../services/eventosApiService";
import { makeStyles } from '@material-ui/core/styles';
import InputLabel from '@material-ui/core/InputLabel';
import FormControl from '@material-ui/core/FormControl';
import Select from '@material-ui/core/Select';
import Button from '@material-ui/core/Button';
import "./EventosPorCategoriaPage.css";

const useStyles = makeStyles({
    root: {
        flexGrow: 1,
    },
});

function EventosPorCategoriaPage() {

    const classes = useStyles();

    const [listaEventosPorCategoria, setListaEventosPorCategoria] = useState([]);

    const [categoria, setCategoria] = useState('');

    const escolherCategoria = (event) => {
        setCategoria(event.target.value);
    };

    function filtrarCategoria(event) {
        event.preventDefault();
        getEventosByCategoria(categoria)
            .then((data) => {
                setListaEventosPorCategoria(data);
            });
    }

    return (
        <div className="container-EventosPorCategoriaPage">
            <div className="container-categoria">
                <h2>Listar Eventos por Categoria</h2>
                <div className="selecionar-categoria">
                    <FormControl id="select-categoria" variant="outlined" className={classes.formControl}>
                        <InputLabel htmlFor="outlined-age-native-simple">Categoria</InputLabel>
                        <Select
                            native
                            onChange={escolherCategoria}
                            label="fitrarCategoria"
                        >
                            <option aria-label="None" value="" />
                            <option value={1}>{`Backend`}</option>
                            <option value={2}>{`Frontend`}</option>
                            <option value={3}>{`Mobile`}</option>
                            <option value={4}>{`Cloud & DevOps`}</option>
                            <option value={5}>{`Modern Workplaces`}</option>
                            <option value={6}>{`UI/UX`}</option>
                            <option value={7}>{`Data & Analytics`}</option>
                            <option value={8}>{`Agilidade & Qualidade`}</option>
                        </Select>
                    </FormControl>
                    &nbsp;
                    <Button id="botao-categoria" variant="contained" color="primary" onClick={filtrarCategoria}>
                        Filtrar por categoria
                    </Button>
                </div>
                {/* <p>Categoria selecionada: {categoria}</p> */}
            </div>

            <div className="listaEventosPorCategoria">
                {listaEventosPorCategoria.map((item, i) => {
                    return (
                        <div key={i} className="eventosPorCategoria__eventoCard">
                            <EventoCard propEvento={item} propAtualizaEvento={filtrarCategoria}/>
                        </div>
                    );
                })}
            </div>
        </div>
    );

}

export default EventosPorCategoriaPage;