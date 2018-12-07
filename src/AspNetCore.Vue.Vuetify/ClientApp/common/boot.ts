import BootstrapVue from "bootstrap-vue";
import { Component, Vue } from "vue-property-decorator";
import VueRouter from "vue-router";
Vue.use(VueRouter);
Vue.use(BootstrapVue);

// Load in the theme / branding for Bootstrap4
import "../css/branding/branding.css";
import "../css/branding/branding.js";

// Load in bootstrap vue controls
import "bootstrap-vue/dist/bootstrap-vue.css";

// TODO
// import $ from 'jquery';
// $(document).ready(function () {
//     require('../css/bootstrap/material-dashboard.js')
//     require('../css/bootstrap/bootstrap-material-design.min.js')
//     require('../css/bootstrap/material-dashboard.min.css')
// });

// This will bring in the font files for fontawesome
// import '../css/fontawesome.scss';
// This will bring in the svg files for fontawesome
import setup_icons from "./svgicon";
setup_icons();

// Destnation routes for different urls
import { routes } from "./routes";

// Setup a foundation directive for the foundation ui js
// can be used via v-foundation in vue controls
// Vue.directive('foundation', {
//     bind(el: any) {
//         $(el).foundation()
//     },
//     unbind(el) {
//         $(el).foundation('destroy')
//     }
// })

// Root component
@Component({
    render: (h) => h(require("../components/dashboard/dashboard.vue").default),
    router: new VueRouter({ mode: "history", routes }),
})
export default class BootComponent extends Vue {
}

// see https://vuejs.org/v2/api/#vm-mount for root component
new BootComponent().$mount("#app-root");
