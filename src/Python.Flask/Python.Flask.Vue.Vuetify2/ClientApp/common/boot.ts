import { Component, Vue } from "vue-property-decorator";
import VueRouter from "vue-router";

import { ComponentOptions } from 'vue'


//console.dir(Vuetify);
//console.dir(Vuetify);

import vuetify from '../plugins/vuetify';
Vue.config.productionTip = false;
let test1 = vuetify as ComponentOptions<Vue>;


Vue.use(VueRouter);
//Vue.use(Vuetify);
//
// TODO
// This will bring in the svg files for fontawesome
//import setup_icons from "./svgicon";
//setup_icons();


// Destination routes for different urls
import { routes } from './routes';


//import App from '../components/pages/home.vue'
//import App from '../components/pages/home.vue'


// Root component
@Component({
    render: (h: any) => h(require('../components/dashboard/dashboard.vue').default),
    router: new VueRouter({ mode: 'history', routes }),
})
export default class BootComponent extends Vue {
  test123: any = test1;
}




//// Root component
//@Component({
//    render: (h: any) => h(require("../components/pages/home.vue").default),
//    router: new VueRouter({ mode: "history", routes }),
//})
//export default class BootComponent extends Vue {
//}






// see https://vuejs.org/v2/api/#vm-mount for root component
//new BootComponent().$mount("#app-root");


//import Vue from 'vue'
//import App from '../components/pages/home.vue'




//new Vue({
//  test1,
//  render: h => h(App)
//}).$mount('#app');

// TODO switch from node-sass to sass

//@Component({
//})
//export default class BootComponent extends Vue {

//  message: any = test1;
//};
