import { TopNavBarEvents } from "common/eventbus";
import { Component, Vue } from "vue-property-decorator";

@Component
export default class TopNavBarComponent extends Vue {

  private toggle_sidebar_click(event: Event) {
    // Throw an event up to the parent control
    TopNavBarEvents.$emit("toggle-sidebar");
  }
}
