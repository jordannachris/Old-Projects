import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../views/Home.vue'
import Manaus from '../views/Manaus.vue'
import Sobre from '../views/Sobre.vue'
import RioBranco from '../views/RioBranco.vue'
import Macapa from '../views/Macapa.vue'
import Localidade from '../views/Localidade.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/manaus',
    name: 'Manaus',
    component: Manaus
  },
  {
    path: '/sobre',
    name: 'Sobre',
    component: Sobre
  },
  {
    path: '/riobranco',
    name: 'RioBranco',
    component: RioBranco
  },
  {
    path: '/macapa',
    name: 'Macapa',
    component: Macapa
  },
  {
    path: '/localidade',
    name: 'Localidade',
    component: Localidade
  }
]

const router = new VueRouter({
  routes
})

export default router
