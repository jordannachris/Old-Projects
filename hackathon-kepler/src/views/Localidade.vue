<template>
  <v-container>
    <div class="localidade">
            <h2 class="display-1 text-center localidade--texto">Localidades</h2>
           <v-img 
            class="localidade-imagem mb-4"
            src="https://1.bp.blogspot.com/-R76sXgykRlw/Vvabq_f-nrI/AAAAAAAA8tM/2a0Wavo9gFQogRlQhtJAQ5lCRAS6dyCqw/s1600/historia%2Bdos%2Bovos%2Bde%2Bp%25C3%25A1scoa%2B%25281%2529.png">
        </v-img>

        <div class="btns">
            <router-link to="/ondeencontrar">
                <v-btn value="AM" color="blue lighten-4">
                    <span>Manaus</span>
                </v-btn>
            </router-link>

            <router-link to="/macapa">
                <v-btn value="AP" color="blue lighten-4">
                    <span>Macapa</span>
                </v-btn>
            </router-link>

            <router-link to="/riobranco">
                <v-btn value="AC" color="blue lighten-4" >
                    <span>Rio Branco</span>
                </v-btn>
            </router-link>
        </div>
    </div>
  </v-container>
</template>

<script>

export default {
  name: 'Localidade',
  components: {
  }
}
</script>

<style scoped>
    .localidade--texto {
        padding-top: 70px;
    }

    .localidade-imagem {
      border-radius: 5px;
    }

    .btns {
        display: flex;
        justify-content: space-between;
    }

    .btns a {
        text-decoration: none;
    }
</style>
