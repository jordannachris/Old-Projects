<template>
    <div class="teste-for">
        <h2>Teste For</h2>
        <ul>
            <li v-for="animal of animais" v-bind:key="animal.id">
                <img v-bind:src="animal.url" v-bind:alt="animal.nome">
            </li>
        </ul>
    </div>
</template>

<script>
export default {
    name: 'TesteFor',
    data() {
        return{
            animais: [
                {
                    id: 1,
                    nome: 'Gatinho',
                    url: 'https://www.petz.com.br/blog/wp-content/uploads/2020/04/meu-primeiro-gato.jpg'
                },
                {
                    id: 2,
                    nome: 'Cachorrinho',
                    url: 'https://image.cachorrogato.com.br/thumb/1200/630/1/imagens/original/imagem858.jpg'
                },
                {
                    id: 3,
                    nome: 'Papagaio',
                    url: 'https://s3.amazonaws.com/media.wikiaves.com.br/images/221/122761_f41b46dfaa37205e41c1a190ceb2ebf8.jpg'
                }
            ]
        }
    }
}
</script>

<style scoped>

</style>