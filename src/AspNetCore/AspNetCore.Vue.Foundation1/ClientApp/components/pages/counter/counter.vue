<template>
  <div>
    <h1>Counter</h1>

    <p>This is a simple example of a Vue.js component. <fa-icon icon="cog"></fa-icon></p>

    <p>Current count: <strong>{{ currentcount }}</strong></p>

    <button class="button" @click="incrementCounter">Increment</button>
  </div>
</template>

<script src="./counter.ts"></script>
