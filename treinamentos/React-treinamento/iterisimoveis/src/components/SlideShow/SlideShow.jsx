import React, { useEffect, useState } from "react";
import { getImoveis } from "../../services/imovelApiService";
import { NavLink } from "react-router-dom";
import Card from "@material-ui/core/Card";
import CardActionArea from "@material-ui/core/CardActionArea";
import CardMedia from "@material-ui/core/CardMedia";
import IconButton from "@material-ui/core/IconButton";
import ArrowBackIosIcon from "@material-ui/icons/ArrowBackIos";
import ArrowForwardIosIcon from "@material-ui/icons/ArrowForwardIos";
import "./SlideShow.css";
function SlideShow() {
  const [listaImoveis, setListaImoveis] = useState([]);
  const [imovelSelecionado, setImovelSelecionado] = useState();
  const [index, setIndex] = useState(0);
  useEffect(() => {
    getImoveis().then((data) => {
      setListaImoveis(data);
      setImovelSelecionado(data[index]);
    });
    // O array vazio no useEffect indica que somente deve ser executando uma vez
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);
  function mudarSlide(mudanca) {
    let novoindex = index + 1;
    if (novoindex >= listaImoveis.length) {
      novoindex = 0; //passou volta para o primeiro
    } else if (novoindex < 0) {
      novoindex = listaImoveis.length - 1; // antes do primeiro, vai para o último
    }
    setIndex(novoindex);
    // usa o valor calculado
    // o index só vai ser atualizado no próximo ciclo do React
    setImovelSelecionado(listaImoveis[novoindex]);
  }
  if (imovelSelecionado === undefined) {
    return <div>carregando lista de imóveis....</div>;
  } else {
    return (
      <div className="slideShow">
        <IconButton aria-label="anteior" onClick={() => mudarSlide(-1)}>
          <ArrowBackIosIcon />
        </IconButton>
        <Card component={NavLink} to={"/imovel/" + imovelSelecionado.id}>
          <CardActionArea className="slideShowCard">
            <CardMedia
              component="img"
              image={imovelSelecionado.image}
              title={imovelSelecionado.address}
            />
          </CardActionArea>
        </Card>
        <IconButton aria-label="próximo" onClick={() => mudarSlide(1)}>
          <ArrowForwardIosIcon />
        </IconButton>
      </div>
    );
  }
}
export default SlideShow;