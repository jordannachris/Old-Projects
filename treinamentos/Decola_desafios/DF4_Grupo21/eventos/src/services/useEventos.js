import EventosContext from "./EventosContext";
import { useContext } from "react";

const useEventos = () => useContext(EventosContext);

export default useEventos;