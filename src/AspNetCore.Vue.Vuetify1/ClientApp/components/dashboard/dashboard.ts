import { Component, Vue, Prop } from "vue-property-decorator";
import SideBar from "./sidebar/sidebar.vue";
import TopNavBar from "./topnavbar/topnavbar.vue";

// TODO icons next followed by sub components

@Component({
  components: {
    //"sidebar-component": SideBar,
    //"topnavbar-component": TopNavBar,
  },
})
export default class DashBoardComponent extends Vue {
  @Prop() source!: string;

  data() {
    return {
      drawer: true,
    }
  }
}
