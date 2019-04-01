<template>
    <div class="app-dashboard-topnavbar">

        <v-toolbar app fixed clipped-left>
            <v-toolbar-side-icon @click.stop="$emit('sidebar-toggle')"></v-toolbar-side-icon>
            <v-toolbar-title>Application</v-toolbar-title>
        </v-toolbar>

    </div>
</template>

<script src="./topnavbar.ts"></script>
<!--<style src="./topnavbar.scss"></style> -->
