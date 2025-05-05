import Vue from 'vue'
import VueRouter from 'vue-router'
import Inicio from '../views/Inicio'
import ClubesLista from '../views/ClubesLista'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Inicio',
    component: Inicio
  },
  {
    path: '/classificacao',
    name: 'ClubesLista',
    component: ClubesLista
  },
]

const router = new VueRouter({
  routes
})

export default router
