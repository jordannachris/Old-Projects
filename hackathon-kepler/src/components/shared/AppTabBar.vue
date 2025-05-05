<template>
  <div class="app-tab-bar">
    <v-bottom-navigation app v-model="value" class="pt-2">
      <router-link to="/">
        <v-btn value="home" color="transparent">
          <span>Início</span>
          <v-icon color="#989899">mdi-home</v-icon>
        </v-btn>
      </router-link>

      <router-link to="/sobre">
        <v-btn value="sobre" color="transparent">
          <span>Sobre</span>
          <v-icon color="#989899">mdi-information</v-icon>
        </v-btn>
      </router-link>

      <router-link to="/localidade">
        <v-btn value="onde-encontrar" color="transparent" >
          <span>Localidade</span>
          <v-icon color="#989899">mdi-cart</v-icon>
        </v-btn>
      </router-link>

    </v-bottom-navigation>
  </div>
</template>
  
<script>
export default {
  name: "AppTabBar",
  data: () => ({ value: "recent" }),
};
</script>

<style scoped>
.app-tab-bar a {
  text-decoration: none;
}

</style>