import Vue from 'vue'
import VueRouter from 'vue-router';
import vuetify from '../plugins/vuetify';

Vue.config.productionTip = false;
Vue.use(VueRouter);

// Destination routes for different urls
import { routes } from './routes';

new Vue({
  // @ts-ignore
  vuetify,
  render: (h: any) => h(require('../components/dashboard/dashboard.vue').default),
  router: new VueRouter({ mode: 'history', routes })
}).$mount('#app-root');
