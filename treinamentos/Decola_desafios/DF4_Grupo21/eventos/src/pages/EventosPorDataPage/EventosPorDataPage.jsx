import React, { useState } from "react";
import EventoCard from "../../components/EventoCard";
import { getEventosByData } from "../../services/eventosApiService";
import Button from '@material-ui/core/Button';
import { KeyboardDatePicker, MuiPickersUtilsProvider } from "@material-ui/pickers";
import DateFnsUtils from "@date-io/date-fns";
import "./EventosPorDataPage.css";


function EventosPorDataPage() {


    const [listaEventosPorData, setListaEventosPorData] = useState([]);

    const [dataEvento, setDataEvento] = useState('');

    const escolherDataEvento = (event) => {
        setDataEvento({ ...dataEvento, dataFormatoString: event.toISOString().toString() });
    };

    function dataFormatadaParaFiltroAPI(dataParaFormatar) {
        let dataFormatada = new Date(dataParaFormatar);

        let dia = dataFormatada.getDate().toString();
        let mes = (dataFormatada.getMonth() + 1).toString();
        let ano = dataFormatada.getFullYear();

        if (dia < 10) {
            dia = '0' + dia;
        }
        if (mes < 10) {
            mes = '0' + mes;
        }
        return ano + "-" + mes + "-" + dia;
    }

    function filtrarDataEvento(event) {
        event.preventDefault();
        let dataDoEventoFormatada = dataFormatadaParaFiltroAPI(dataEvento.dataFormatoString);

        console.log(dataDoEventoFormatada);

        getEventosByData(dataDoEventoFormatada)
            .then((data) => {
                setListaEventosPorData(data);
            });
    }

    return (
        <div className="container-EventosPorDataPage">
            <div className="container-data">
                <h2>Listar Eventos por Data</h2>
                <div className="selecionar-data">
                   
                        <MuiPickersUtilsProvider id="datePicker-dataEvento" utils={DateFnsUtils}>
                            <KeyboardDatePicker
                                disableToolbar
                                variant="inline"
                                format="dd/MM/yyyy"
                                margin="normal"
                                id="dataEvento"
                                label="Data do Evento"
                                value={dataEvento.dataFormatoString}
                                onChange={escolherDataEvento}
                            />
                        </MuiPickersUtilsProvider>
                    &nbsp;
                    <Button id="botao-data" variant="contained" color="primary" onClick={filtrarDataEvento}>
                        Filtrar por data
                    </Button>
                </div>
                {/* <p>Data selecionada: {dataEvento.dataFormatoString}</p> */}
            </div>

            <div className="listaEventosPorData">
                {listaEventosPorData.map((item, i) => {
                    return (
                        <div key={i} className="eventosPorData__eventoCard">
                            <EventoCard propEvento={item} propAtualizaEvento={filtrarDataEvento}/>
                        </div>
                    );
                })}
            </div>
        </div>
    );

}

export default EventosPorDataPage;