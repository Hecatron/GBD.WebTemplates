import { Component, Vue } from "vue-property-decorator";
import $ from "jquery";
import "metismenu"

@Component
export default class SideBarComponent extends Vue {
  isShown = false;

  private mounted() {
    $("#sidebar-menu1").metisMenu();
  }

}


