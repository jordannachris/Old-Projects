<template>
    <div class="meu-contador">
        <p><strong>Contador:</strong> {{ contador }} </p>
        <button v-on:click="removerUm" >-</button>
        <button v-on:click="somarUm" >+</button>
    </div>
</template>

<script>
export default {
    name: 'MeuContador',

    data(){
        return {
            contador: 0
        }
    },
    methods: {
        somarUm() {
            this.contador++;
        },
        removerUm() {
            this.contador--;
        }
    }
}
</script>

<style scoped>

</style>