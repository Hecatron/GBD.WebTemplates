<template>

    <!--TODO
        1. add fixed-top for the navbar
     -->

    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">

        <a class="navbar-brand" href="#">Navbar</a>


        <div class="collapse navbar-collapse" id="navbarColor01">

            <!--

            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Features</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Pricing</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">About</a>
                </li>
            </ul>

            -->

            <form class="form-inline my-2 my-lg-0">
                <input class="form-control mr-sm-2" type="text" placeholder="Search">
                <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
            </form>


        </div>

        <!--
    <div class="row">

        <div class="col-2">
            <button class="menu-icon" v-on:click="toggle_sidebar_click"></button>
            <a class="app-dashboard-logo">Foundation</a>
        </div>

        <div class="col">
            <div class="show-for-medium app-dashboard-search-bar-container">
                <input class="app-dashboard-search" type="search" placeholder="Search">
                <i class="app-dashboard-search-icon fa fa-search"></i>
            </div>
        </div>

        <div class="col-2">
            <button href="#" class="button hollow">Logout</button>
            <a href="#" height="30" width="30" alt=""><i class="fa fa-info-circle"></i></a>
        </div>

    </div>

    -->

    </nav>

</template>

<script src="./topnavbar.ts"></script>
<!--<style src="./topnavbar.scss"></style> -->
