import { Component, Vue } from "vue-property-decorator";
import $ from "jquery";
import "metismenu"

@Component
export default class SideBarComponent extends Vue {
  isShown = false;

  private mounted() {
    $("#sidebar-menu1").metisMenu();
  }

  // TODO
  // button to toggle the class "show" to the sidebar-nav element in mobile view
  private ExpandMenuMobile() {
    this.isShown = !this.isShown;
    //this.currentcount++;
  }

}


