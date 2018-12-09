import { Component, Vue } from "vue-property-decorator";
import SideBar from "./sidebar/sidebar.vue";
import TopNavBar from "./topnavbar/topnavbar.vue";

@Component({
  components: {
    "sidebar-component": SideBar,
    "topnavbar-component": TopNavBar,
  },
})
export default class DashBoardComponent extends Vue {
  data() {
    return {
      clipped: false,
      drawer: true,
      fixed: false,
      items: [
        { icon: "bubble_chart", title: "Inspire" }
      ],
      miniVariant: false,
      right: true,
      rightDrawer: false,
      title: "Vuetify.js"
    }
  }
}
