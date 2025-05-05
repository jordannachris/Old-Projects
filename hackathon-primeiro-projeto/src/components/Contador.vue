<template>
    <div class="contador">
        <div class="display-contador">
            <h4>Contador da Jordanna: </h4>
            <p> {{ numero }} </p>
        </div>

        <div class="botoes">
            <button v-on:click="subtrairUm">-</button>
            <button v-on:click="somarUm" >+</button>
        </div>


    </div>
</template>

<script>
export default {
    name: 'Contador',

    data(){
        return{
            numero: 0
        }
    },

    methods: {
        somarUm() {
            this.numero = this.numero + 1;
        },
        subtrairUm() {
            this.numero = this.numero - 1;
        }
    }

}
</script>

<style scoped>

    h4{
        margin: 0;
    }

    p {
        margin-left: 4px;
    }
    
    .display-contador,
    .botoes{
        display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center;
    }
</style>