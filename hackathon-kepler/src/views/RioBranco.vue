<template>
  <v-container>
    <div class="text-center rio-branco">
      <v-col cols="">
        <v-card class="card1">
          <v-img :src="dadosAPI[4].imagem" class="grey darken-4"></v-img>
          <v-card-title class="title">
            <span>{{ dadosAPI[4].nome }}</span>
            <span>Valor R$: {{ dadosAPI[4].preco }}</span>
          </v-card-title>

          <v-btn>Comprar</v-btn>
        </v-card>

        <v-card class="card1">
          <v-img :src="dadosAPI[5].imagem" class="grey darken-4"></v-img>
          <v-card-title class="title">
            <span> {{ dadosAPI[5].nome }}</span>
            <span>Valor R$: {{ dadosAPI[5].preco }}</span>
          </v-card-title>

          <v-btn>Comprar</v-btn>
        </v-card>

        <v-card class="card1">
          <v-img :src="dadosAPI[6].imagem" class="grey darken-4"></v-img>
          <v-card-title class="title">
            <span> {{ dadosAPI[6].nome }}</span>
            <span>Valor R$: {{ dadosAPI[6].preco }}</span>
            
          </v-card-title>

          <v-btn>Comprar</v-btn>
        </v-card>
      </v-col>
    </div>
  </v-container>
</template>

<script>
export default {
  name: "RioBranco",
  data() {
    return {
      dadosAPI: [],
    };
  },
  created() {
    fetch("https://it3kjy-default-rtdb.firebaseio.com/ovosPascoa.json")
      .then((resposta) => resposta.json())
      .then((json) => {
        this.dadosAPI = json;
        // console.log(this.dadosAPI);
      });
  },
};
</script>

<style scoped>
.card1 {
  width: 5000px;
  padding-bottom: 8px;
  margin-bottom: 10px;
}

.title {
  display: flex;
  justify-content: center;
}

</style>
