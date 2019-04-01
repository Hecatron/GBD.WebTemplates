import { Component, Vue, Prop, Emit } from "vue-property-decorator";
import SideBar from "./sidebar/sidebar.vue";
import TopNavBar from "./topnavbar/topnavbar.vue";

// TODO pages with links
// TODO metismenu / scss

@Component({
  components: {
    "sidebar-component": SideBar,
    "topnavbar-component": TopNavBar,
  },
})
export default class DashBoardComponent extends Vue {
  @Prop() source!: string;

  data() {
    return {
      drawer: true,
    }
  }

  // Needed for vue refs to work under typescript
  $refs!: {
    sidebar1: any;
  }
}
