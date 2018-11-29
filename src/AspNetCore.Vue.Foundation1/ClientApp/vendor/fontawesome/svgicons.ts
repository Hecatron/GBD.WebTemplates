import Vue from 'vue';
import { library } from '@fortawesome/fontawesome-svg-core';

// See https://fontawesome.com/icons?d=gallery for all icons
import { faSpinner, faCog, faFolder, faFolderOpen, faFile } from '@fortawesome/free-solid-svg-icons';

//import '@fortawesome/fontawesome-free/css/fontawesome.min.css';

// register the font-awesome-icon component
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';
export default function setup_icons() {
    library.add(faSpinner, faCog, faFolder, faFolderOpen, faFile);
    Vue.component('font-awesome-icon', FontAwesomeIcon);
}
