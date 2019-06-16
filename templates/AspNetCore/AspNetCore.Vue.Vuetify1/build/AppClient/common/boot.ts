import { Component, Vue } from "vue-property-decorator";
import VueRouter from "vue-router";
import Vuetify from "vuetify";
import "vuetify/dist/vuetify.css"
import "vuetify/dist/vuetify.min.js"
Vue.use(VueRouter);
Vue.use(Vuetify, { iconfont: "fa" });

// TODO
// This will bring in the svg files for fontawesome
//import setup_icons from "./svgicon";
//setup_icons();

// Destination routes for different urls
import { routes } from "./routes";


// Root component
@Component({
    render: (h: any) => h(require("../components/dashboard/dashboard.vue").default),
    router: new VueRouter({ mode: "history", routes }),
})
export default class BootComponent extends Vue {
}

// see https://vuejs.org/v2/api/#vm-mount for root component
new BootComponent().$mount("#app-root");
