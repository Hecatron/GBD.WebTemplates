import { Component, Vue } from "vue-property-decorator";
import $ from "jquery";
import "metismenu"

@Component
export default class SideBarComponent extends Vue {
  private mounted() {
    $("#sidebar-menu").metisMenu();
  }
}
