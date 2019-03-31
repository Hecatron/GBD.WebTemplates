<template>
    <div class="app-dashboard">
        <v-app id="inspire" dark>
            <!--<sidebar-component /> -->

            <v-navigation-drawer v-model="drawer"
                                 clipped
                                 fixed
                                 app>
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
            </v-navigation-drawer>


            <v-toolbar app fixed clipped-left>
                <v-toolbar-side-icon @click.stop="drawer = !drawer"></v-toolbar-side-icon>
                <v-toolbar-title>Application</v-toolbar-title>
            </v-toolbar>

            <v-content>
                <v-container fluid fill-height>
                    <v-layout justify-center align-center>
                        <v-flex shrink>
                            <v-tooltip right>
                                <template v-slot:activator="{ on }">
                                    <v-btn :href="source" icon large target="_blank" v-on="on">
                                        <v-icon large>fa-code</v-icon>
                                    </v-btn>
                                </template>
                                <span>Source</span>
                            </v-tooltip>
                            <v-tooltip right>
                                <template v-slot:activator="{ on }">
                                    <v-btn icon large href="https://codepen.io/johnjleider/pen/qxQWda" target="_blank" v-on="on">
                                        <v-icon large>fa-codepen</v-icon>
                                    </v-btn>
                                </template>
                                <span>Codepen</span>
                            </v-tooltip>
                        </v-flex>
                    </v-layout>
                </v-container>
            </v-content>

            <v-footer app fixed>
                <span>&copy; 2017</span>
            </v-footer>
        </v-app>
    </div>
</template>

<script src="./dashboard.ts"></script>
<!-- <style lang="scss" src="./dashboard.scss"></style> -->
