import { Component, Vue } from 'vue-property-decorator';
import { TopNavBarEvents } from 'common/eventbus';

@Component
export default class TopNavBarComponent extends Vue {

    toggle_sidebar_click(event: Event) {
        // Throw an event up to the parent control
        TopNavBarEvents.$emit('toggle-sidebar');
    }
}
