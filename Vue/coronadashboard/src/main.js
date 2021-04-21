import Vue from 'vue'
import App from './App.vue'
import VueRouter from 'vue-router'
import MainDashBoard from './components/MainDashBoard'
import CountryByDate from './components/CountryByDate'
import HighchartsVue from 'highcharts-vue'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'




const routes = [
  { path: '/', component: MainDashBoard },
  { path: '/CountryByDate/:coronaCountry', component: CountryByDate },
  
]

// 3. Create the router instance and pass the `routes` option
// You can pass in additional options here, but let's
// keep it simple for now.
const router = new VueRouter({
  routes, // short for `routes: routes`,
  mode:'history'
})


// Install BootstrapVue
Vue.use(BootstrapVue)
// Optionally install the BootstrapVue icon components plugin
Vue.use(IconsPlugin)
Vue.use(HighchartsVue)
Vue.use(VueRouter)

Vue.config.productionTip = false

new Vue({
  router,
  render: h => h(App),
}).$mount('#app')
