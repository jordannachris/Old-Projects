import React from "react";
import Button from '@material-ui/core/Button';
import Card from '@material-ui/core/Card';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import TextField from "@material-ui/core/TextField";
import SearchOutlinedIcon from '@material-ui/icons/SearchOutlined';
import "./FilterProducts.css";

function FilterProducts() {
    return (
        <div className="FilterProductsContainer">
            <Card className="FilterProductsCard">
                <CardContent className="FilterProductsContent">
                    <TextField
                        className="produto"
                        label="Pesquisar produto"
                        placeholder="Digite o nome do produto que deseja pesquisar"
                        variant="outlined"
                    />
                </CardContent>

                <CardActions className="FilterProductsActions">
                    <Button className="botao-filtrar-produto" variant="contained" color="primary">
                        <SearchOutlinedIcon fontSize="large"/>
                    </Button>
                </CardActions>
            </Card>
            <h1>Lista de produtos filtrada por nome</h1>
        </div>
    );
}

export default FilterProducts;