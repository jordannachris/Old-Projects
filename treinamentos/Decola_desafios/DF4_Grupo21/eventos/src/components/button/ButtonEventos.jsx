import './ButtonEventos.css';

function ButtonEventos({titulo, ...props}) {

  return <button className="button" id="button" type="submit" {...props}>{titulo}</button>;
}

export default ButtonEventos;