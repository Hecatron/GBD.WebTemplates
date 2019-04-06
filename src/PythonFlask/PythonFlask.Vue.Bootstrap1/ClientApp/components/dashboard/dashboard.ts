import { Component, Vue } from 'vue-property-decorator';
import TopNavBar from './topnavbar/topnavbar.vue';
import SideBar from './sidebar/sidebar.vue';

@Component({
    components: {
        'topnavbar-component': TopNavBar,
        'sidebar-component': SideBar,
    }
})
export default class DashBoardComponent extends Vue {
}
