<template>
  <div class="app-dashboard-navbar">
    <ul class="multilevel-accordion-menu vertical menu" data-accordion-menu>

      <li>
        <a href="#">Basic Examples</a>
        <ul class="menu vertical">

          <li>
            <router-link tag="li" to="/counter">
              <a class="subitem">Counter Example</a>
            </router-link>
          </li>

          <li>
            <router-link tag="li" to="/test1">
              <a class="subitem">Static Page</a>
            </router-link>
          </li>

          <li>
            <router-link tag="li" to="/fetchdata">
              <a class="subitem">Fetch Data Example</a>
            </router-link>
          </li>

        </ul>
      </li>

      <li>
        <a href="#">Sub Menu Example</a>
        <ul class="menu vertical sublevel-1">
          <li>
            <a href="#">Sub Menu1 1</a>
            <ul class="menu vertical sublevel-2">
              <li><a class="subitem" href="#">Thing 1</a></li>
              <li><a class="subitem" href="#">Thing 2</a></li>
              <li><a class="subitem" href="#">Thing 3</a></li>
            </ul>
          </li>
        </ul>
      </li>

    </ul>
  </div>
</template>

<style lang="scss" src="./navmenu.scss"></style>
