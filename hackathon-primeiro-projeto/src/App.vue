<template>
  <div id="app">
    <NovoComponente/>
    <TesteIf/>
    <TesteFor/>
    <TesteEvento/>
    <SitesFavoritos/>
    <Contador/>
    <MeuContador/>
  </div>
</template>

<script>
import NovoComponente from './components/NovoComponente'
import TesteIf from './components/TesteIf'
import TesteFor from './components/TesteFor'
import TesteEvento from './components/TesteEvento'
import SitesFavoritos from './components/SitesFavoritos'
import Contador from './components/Contador'
import MeuContador from './components/MeuContador'

export default {
  name: 'App',
  components: {
    NovoComponente,
    TesteIf,
    TesteFor,
    TesteEvento,
    SitesFavoritos,
    Contador,
    MeuContador
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
