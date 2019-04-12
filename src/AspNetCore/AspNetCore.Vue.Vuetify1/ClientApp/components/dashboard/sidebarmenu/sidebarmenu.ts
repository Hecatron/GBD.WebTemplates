import { Component, Vue, Prop, Emit } from "vue-property-decorator";
import MetisMenu from "metismenujs";

// TODO test destroyed
// TODO try using a vuetify component for the menu list

@Component
export default class SideBarMenuComponent extends Vue {
  private mm: MetisMenu | undefined;

  private mounted() {
    let element = (document.getElementById("sidebar-menu1") || '');
    this.mm = new MetisMenu(element);
  }

  private destroyed() {
    if (this.mm != null) {
      this.mm.dispose();
    }
  }
}
