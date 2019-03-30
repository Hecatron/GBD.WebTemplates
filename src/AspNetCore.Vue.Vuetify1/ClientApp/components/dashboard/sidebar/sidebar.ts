import { Component, Vue } from "vue-property-decorator";
import NavBar from "../sidebarmenu/sidebarmenu.vue";
// import { TopNavBarEvents } from 'common/eventbus';

@Component({
  components: {
    "navbar-component": NavBar,
  },
})
export default class SideBarComponent extends Vue {

  private mounted() {
    // Handle click event from top navbar
    // TopNavBarEvents.$on('toggle-sidebar', function () {
    //   $('#app-dashboard-sidebar').foundation('toggle');
    // });
    // Open the sidebar automatically on load if the page is not on mobile
    // if (Foundation.MediaQuery.atLeast('medium')) {
    //   $('#app-dashboard-sidebar').foundation('open');
    // }
  }
}
