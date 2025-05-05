import React from "react";
import Button from '@material-ui/core/Button';
import Card from '@material-ui/core/Card';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import TextField from "@material-ui/core/TextField";
import AddOutlinedIcon from '@material-ui/icons/AddOutlined';
import "./AddProducts.css";

function AddProducts() {
    return (
        <div className="AddProductsContainer">
            <Card className="AddProductsCard">
                <CardContent className="AddProductsContent">
                    <TextField
                        className="produto"
                        label="Adicionar produto"
                        placeholder="Digite o nome do produto que deseja adicionar"
                        variant="outlined"
                    />
                </CardContent>

                <CardActions className="AddProductsActions">
                    <Button className="botao-adicionar-produto" variant="contained" color="primary">
                        <AddOutlinedIcon fontSize="large"/>
                    </Button>
                </CardActions>
            </Card>
            <h1>Lista com todos os produtos</h1>
        </div>
    );
}

export default AddProducts;