import { Component, Vue } from "vue-property-decorator";

@Component
export default class CounterComponent extends Vue {
    private currentcount: number = 0;

    private incrementCounter() {
        this.currentcount++;
    }
}
