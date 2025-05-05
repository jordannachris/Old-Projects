import React, { useEffect, useState } from "react";
import EventoDisponivelCard from "../../components/EventoDisponivelCard/EventoDisponivelCard";
import { getEventosDisponiveis } from "../../services/eventosApiService";
import "./EventosDisponiveisPage.css";

function EventosDisponiveisPage() {
  const [listaEventos, setListaEventos] = useState([]);

  useEffect(() => {
    getEventosDisponiveis().then((data) => {
      setListaEventos(data);
    });
  }, []);

  return (
    <div className="listaEventosDisponiveis">
      <h2 className="texticulo">Eventos disponíveis para inscrição</h2>
      {listaEventos.map((item, i) => {
        return (
          <div key={i} className="eventosDisponiveis__eventoCard">
            <EventoDisponivelCard propEvento={item} />
          </div>
        );
      })}
    </div>
  );
}

export default EventosDisponiveisPage;
