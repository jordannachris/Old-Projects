<template>
  <v-container>
    <div class="text-center manaus">
      <v-col cols="">
        <v-card class="card1">
          <v-img :src="dadosAPI[0].imagem" class="grey darken-4"></v-img>
          <v-card-title class="title">
            <span>{{ dadosAPI[0].nome }}</span>
            <span>Valor R$: {{ dadosAPI[0].preco }}</span>
          </v-card-title>

          <v-btn>Comprar</v-btn>
        </v-card>

        <v-card class="card1">
          <v-img :src="dadosAPI[1].imagem" class="grey darken-4"></v-img>
          <v-card-title class="title">
            <span> {{ dadosAPI[1].nome }}</span>
            <span>Valor R$: {{ dadosAPI[1].preco }}</span>
          </v-card-title>

          <v-btn>Comprar</v-btn>
        </v-card>

        <v-card class="card1">
          <v-img :src="dadosAPI[2].imagem" class="grey darken-4"></v-img>
          <v-card-title class="title">
            <span> {{ dadosAPI[2].nome }}</span>
            <span>Valor R$: {{ dadosAPI[2].preco }}</span>
            
          </v-card-title>

          <v-btn>Comprar</v-btn>
        </v-card>
      </v-col>
    </div>
  </v-container>
</template>

<script>
export default {
  name: "Manaus",
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
