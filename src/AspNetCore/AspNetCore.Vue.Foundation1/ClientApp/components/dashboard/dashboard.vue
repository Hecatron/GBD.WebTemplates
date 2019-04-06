<template>
    <div v-foundation class="app-dashboard">
        <topnavbar-component/>
        <div class="app-dashboard-body off-canvas-wrapper">
            <sidebar-component/>
            <div class="app-dashboard-body-content off-canvas-content" data-off-canvas-content>
                <router-view></router-view>
            </div>
        </div>
    </div>
</template>

<script src="./dashboard.ts"></script>
<style lang="scss" src="./dashboard.scss"></style>
