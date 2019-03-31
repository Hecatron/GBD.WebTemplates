<template>
    <div class="app-dashboard-sidebarmenu">

        <v-list dense>
            <v-list-tile @click="">
                <v-list-tile-action>
                    <v-icon>fa-th-large</v-icon>
                </v-list-tile-action>
                <v-list-tile-content>
                    <v-list-tile-title>Dashboard</v-list-tile-title>
                </v-list-tile-content>
            </v-list-tile>
            <v-list-tile @click="">
                <v-list-tile-action>
                    <v-icon>fa-cog</v-icon>
                </v-list-tile-action>
                <v-list-tile-content>
                    <v-list-tile-title>Settings</v-list-tile-title>
                </v-list-tile-content>
            </v-list-tile>
        </v-list>













        <!--
        <b-nav class="menu sidebar-menu">
            <b-nav-item active>Active</b-nav-item>
            <b-nav-item>Link</b-nav-item>
            <b-nav-item>Another Link</b-nav-item>
            <b-nav-item disabled>Disabled</b-nav-item>
        </b-nav>


        <b-nav class="menu">
            <ul id="sidebar-menu" class="sidebar-menu metismenu">

                <li class="active">
                    <a href="#" aria-expanded="true"><span>Basic Examples</span></a>
                    <ul id="menu1" class="collapse metismenu">

                        <li>
                            <router-link tag="li" to="/counter">
                                <a>Counter Example</a>
                            </router-link>
                        </li>

                        <li>
                            <router-link tag="li" to="/test1">
                                <a>Static Page</a>
                            </router-link>
                        </li>

                        <li>
                            <router-link tag="li" to="/fetchdata">
                                <a>Fetch Data Example</a>
                            </router-link>
                        </li>

                    </ul>
                </li>

                <li>
                    <a href="#">Sub Menu Example</a>
                    <ul class="collapse">
                        <li>
                            <a href="#">Sub Menu1 1</a>
                            <ul class="collapse">
                                <li><a href="#">Thing 1</a></li>
                                <li><a href="#">Thing 2</a></li>
                                <li><a href="#">Thing 3</a></li>
                            </ul>
                        </li>
                    </ul>
                </li>

            </ul>
        </b-nav>
        -->


    </div>
</template>

<script src="./sidebarmenu.ts"></script>
<!--<style lang="scss" src="./sidebarmenu.scss"></style>-->
