<template>

    <div class="grid-container fluid app-dashboard-top-nav-bar">

        <div class="grid-x grid-margin-x grid-margin-y">

            <div class="cell small-2">
                <button class="menu-icon" v-on:click="toggle_sidebar_click"></button>
                <a class="app-dashboard-logo">Foundation</a>
            </div>

            <div class="cell auto">
                <div class="show-for-medium app-dashboard-search-bar-container">
                    <input class="app-dashboard-search" type="search" placeholder="Search">
                    <i class="app-dashboard-search-icon fa fa-search"></i>
                </div>
            </div>

            <div class="cell shrink app-dashboard-top-bar-actions">
                <button href="#" class="button hollow">Logout</button>
                <a href="#" height="30" width="30" alt=""><i class="fa fa-info-circle"></i></a>
            </div>

        </div>

    </div>

</template>

<script src="./topnavbar.ts"></script>
<style lang="scss" src="./topnavbar.scss"></style>
