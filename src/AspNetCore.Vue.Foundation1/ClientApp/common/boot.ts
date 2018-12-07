import { Component, Vue } from "vue-property-decorator";
import VueRouter from "vue-router";
Vue.use(VueRouter);

// Load in foundation js
import "foundation-sites";
// Load in the default theme for Foundation UI
import "../css/foundation/app.scss";

// TODO test the below without the font files css

// This will bring in the svg files for fontawesome
import setup_icons from "./svgicons";
setup_icons();

// Destnation routes for different urls
import { routes } from "./routes";

import $ from "jquery";
// Setup a foundation directive for the foundation ui js
// can be used via v-foundation in vue controls
Vue.directive("foundation", {
    bind(el: any) {
        $(el).foundation();
    },
    unbind(el) {
        $(el).foundation("destroy");
    },
});

// Root component
@Component({
    render: (h) => h(require("../components/dashboard/dashboard.vue").default),
    router: new VueRouter({ mode: "history", routes }),
})
export default class BootComponent extends Vue {
}

// see https://vuejs.org/v2/api/#vm-mount for root component
new BootComponent().$mount("#app-root");
