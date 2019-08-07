import { Component, Vue, Prop, Emit } from "vue-property-decorator";
import SideBar from "./sidebar/sidebar.vue";
import TopNavBar from "./topnavbar/topnavbar.vue";
import SideBarComponent from "./sidebar/sidebar"

// TODO
// metismenu / scss
// size when menu switches over

@Component({
  components: {
    "sidebar-component": SideBar,
    "topnavbar-component": TopNavBar,
  },
})
export default class DashBoardComponent extends Vue {
  // Needed for vue refs to work under typescript
  $refs!: {
    sidebar1: SideBarComponent;
  }

  toggle_sidebar() {
    this.$refs.sidebar1.toggle_sidebar()
  }
}
