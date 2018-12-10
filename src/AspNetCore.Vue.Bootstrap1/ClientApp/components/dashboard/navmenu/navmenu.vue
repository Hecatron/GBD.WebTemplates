<template>
  <div class="app-dashboard-navbar">
    <nav class="sidebar-nav">
      <ul id="sidebar-menu1" class="metismenu">

        <li class="active">

          <a href="#" class="has-arrow" aria-expanded="false">
            Basic Examples
          </a>

          <ul aria-expanded="false">
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
          <a href="#" class="has-arrow">
              Sub Menu Example
          </a>

          <ul aria-expanded="false">
            <li>
              <a href="#" class="has-arrow">
                Sub Menu1 1
              </a>

              <ul aria-expanded="false">
                <li><a href="#">Thing 1</a></li>
                <li><a href="#">Thing 2</a></li>
                <li><a href="#">Thing 3</a></li>
              </ul>
            </li>
          </ul>
        </li>

      </ul>

    </nav>
  </div>
</template>

<script src="./navmenu.ts"></script>
<style lang="scss" src="./navmenu.scss"></style>
