<template>
  <v-app class="background">  
    <v-main>
      <router-view></router-view>
    </v-main>
    <AppTabBar/>
  </v-app>
</template>

<script>
import AppTabBar from './components/shared/AppTabBar'

export default {

  name: 'App',

  components: {
    AppTabBar
  },

  data: () => ({
    //
  }),
};
</script>

<style>
  #app {
    background-color: #f6d2c0;
    font-family: Roboto;
    padding-right: 20px;
    padding-left: 20px;
  }
</style>