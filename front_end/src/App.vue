<template>
  <div id="app1" v-bind:class="{handleDialog: showShopPropDialog, handleDelDia: showDeletingDialog }">
      <Menu />
      <Header />
      <Content :listDatas = "this.data"
                v-on:openShopForm = "openShopInfoForm" 
                v-on:deleteThisShop = "deleteShop"
               v-on:openDeleteDialog = "openDeleteDialog"
                />
      <dialogShopInfoForm v-if="showShopPropDialog"
      v-on:closeShopInfoDia = "closeShopInfoDia"/>
      <deletingDia v-if="showDeletingDialog" v-on:closeDelDia = "closeDelDia" />
  </div>
</template>

<script>
import Menu from './components/menu';
import Header from './components/header';
import Content from './components/content';
import dialogShopInfoForm from './components/dialogShopInfoForm';
import deletingDia from './components/deletingDia';
import axios from 'axios';
export default {
  name: 'App',
  components: {
    Menu,
    Header,
    Content,
    dialogShopInfoForm,
    deletingDia
  },
  data() {
    return {
      showShopPropDialog: false,
      showDeletingDialog: false,
      data:[]
    }
  },
  methods: {
    openShopInfoForm: function(){
      this.showShopPropDialog = !this.showShopPropDialog;
    },
    openDeleteDialog:function(){
      this.showDeletingDialog = !this.showDeletingDialog;
    },
    closeShopInfoDia:function(){
       this.showShopPropDialog = !this.showShopPropDialog;
    },
    closeDelDia:function(){
      this.showDeletingDialog = !this.showDeletingDialog;
    },
    async deleteShop(payLoad){
      console.log(payLoad.eShopId+payLoad.eShopName);
      const response = await axios.delete('http://localhost:57752/api/v1/EShops/' + payLoad.eShopId)
      console.log(response);
    }
  },
  async created (){
      const response = await axios.get('http://localhost:57752/api/v1/EShops')
      this.data = response.data;
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
  .handleDelDia {
    background-color: #2c060654;
  }
</style>
