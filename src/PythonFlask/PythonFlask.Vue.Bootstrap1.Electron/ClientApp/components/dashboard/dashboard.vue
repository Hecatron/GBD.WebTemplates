<template>
    <div class="app-dashboard container-fluid">
        <topnavbar-component/>
        <div class="app-dashboard-body row">
            <sidebar-component/>
            <div class="app-dashboard-body-content col">
                <router-view></router-view>
            </div>
        </div>
    </div>
</template>

<script src="./dashboard.ts"></script>
<!-- <style src="./dashboard.scss"></style> -->
