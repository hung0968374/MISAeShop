<template>
  <div id="app1" v-bind:class="{handleDialog: showDialog }">
      <Menu />
      <Header />
      <Content />
  </div>
</template>

<script>
import Menu from './components/menu';
import Header from './components/header';
import Content from './components/content';

export default {
  name: 'App',
  components: {
    Menu,
    Header,
    Content
  },
  data() {
    return {
    }
  },
  methods: {
    
  },
  async created (){
   
  }
}
</script>

<style>
  * {
    margin: 0px;
  }
  #app1 {
    margin: 0px;
    height: 98vh;
  }
  .handleDialog {
    background-color: #69696954;
  }
</style>
