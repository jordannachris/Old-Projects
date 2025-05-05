<template>
  <v-container>
      <div class="home">
        <h1 class="display-2 text-center mb-15 home--titulo" >
            Ovos de Páscoa
        </h1>
        <v-img 
            class="home-imagem mb-4"
            src="https://1.bp.blogspot.com/-R76sXgykRlw/Vvabq_f-nrI/AAAAAAAA8tM/2a0Wavo9gFQogRlQhtJAQ5lCRAS6dyCqw/s1600/historia%2Bdos%2Bovos%2Bde%2Bp%25C3%25A1scoa%2B%25281%2529.png">
        </v-img>
      </div>
  </v-container>
</template>

<script>

export default {
  name: 'Home',
  components: {
  }
}
</script>

<style scoped>
  .home-imagem {
      border-radius: 5px;
    }

  .home--titulo {
    padding-top: 70px;
    font-family: 'Montserrat', sans-serif;
  }
</style>
