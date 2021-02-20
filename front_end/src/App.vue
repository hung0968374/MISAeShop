<template>
  <div id="app1" v-bind:class="{handleDialog: showDialog }">
      <Menu />
      <Header />
      <Content v-on:openShopForm = "openShopInfoForm" />
      <dialogShopInfoForm v-if="showDialog"/>
  </div>
</template>

<script>
import Menu from './components/menu';
import Header from './components/header';
import Content from './components/content';
import dialogShopInfoForm from './components/dialogShopInfoForm';
export default {
  name: 'App',
  components: {
    Menu,
    Header,
    Content,
    dialogShopInfoForm
  },
  data() {
    return {
      showDialog: true,
    }
  },
  methods: {
    openShopInfoForm: function(){
      this.showDialog = !this.showDialog;
    }
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
    background-color: #2c060654;
  }
</style>
