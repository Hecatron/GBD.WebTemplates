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

    </div>
</template>

<script src="./sidebarmenu.ts"></script>
<!--<style lang="scss" src="./sidebarmenu.scss"></style>-->
