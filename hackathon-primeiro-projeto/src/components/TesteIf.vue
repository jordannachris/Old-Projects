<template>
    <div class="teste-if">
        <h1 v-if="podeVer">Teste If 1</h1>
        <h1 v-else>Teste If 2</h1>
    </div>   
</template>

<script>
export default {
    name: 'TesteIf',
    data() {
        return{
            podeVer: true
        }
    }
}
</script>

<style scoped>

</style>