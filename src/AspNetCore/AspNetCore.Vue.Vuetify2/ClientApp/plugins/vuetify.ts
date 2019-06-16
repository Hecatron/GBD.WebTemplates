//import 'vuetify/src/styles/main.sass'

import Vue from 'vue';
import Vuetify from 'vuetify/lib';

Vue.use(Vuetify);

// @ts-ignore
const vuetify = new Vuetify({
  icons: {
    iconfont: 'mdi',
  },
});

export default vuetify;
