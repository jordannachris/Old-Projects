<template>
  <div class="apptopbar">
     <v-app-bar
      color="light-green darken-3"
      app
      dark
    >
      <v-app-bar-nav-icon @click="drawer = true"></v-app-bar-nav-icon>

      <v-toolbar-title>Campeonato Brasileiro</v-toolbar-title>

      <v-spacer></v-spacer>

      <v-menu
        left
        bottom
      >
        <template v-slot:activator="{ on, attrs }">
          <v-btn
            icon
            v-bind="attrs"
            v-on="on"
          >
            <v-icon>mdi-dots-vertical</v-icon>
          </v-btn>
        </template>

        <v-list>
          <v-list-item
            v-for="n in 5"
            :key="n"
            @click="() => {}"
          >
            <v-list-item-title>Option {{ n }}</v-list-item-title>
          </v-list-item>
        </v-list>
      </v-menu>
    </v-app-bar>
      <v-navigation-drawer v-model="drawer" absolute temporary>
      <v-list
        nav
        dense
      >
        <v-list-item-group
          v-model="group"
          active-class="green"
        >
          <router-link to="/">
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-home</v-icon>
            </v-list-item-icon>
            <v-list-item-title>Home</v-list-item-title>
          </v-list-item>
          </router-link>

          <router-link to="/fale-conosco">
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-account-voice</v-icon>
            </v-list-item-icon>
            <v-list-item-title>Fale Conosco</v-list-item-title>
          </v-list-item>
          </router-link>

           <router-link to="/logos">
          <v-list-item>
            <v-list-item-icon>
              <v-icon>mdi-soccer</v-icon>
            </v-list-item-icon>
            <v-list-item-title>Logos</v-list-item-title>
          </v-list-item>
          </router-link>


        </v-list-item-group>
      </v-list>
  </v-navigation-drawer>
  </div>
</template>

<script>
export default {
    name:'AppTopBar',
    data: () => ({
        drawer: false,
        group: null,
  }),
}
</script>

<style scoped>
.apptopbar a {
    text-decoration: none;
    color:white;
}
</style>
