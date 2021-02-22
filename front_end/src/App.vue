<template>
  <div id="app1" v-bind:class="{handleDialog: showShopPropDialog, handleDelDia: showDeletingDialog }">
      <Menu />
      <Header />
      <Content :listDatas = "this.data"
                
                v-on:openShopForm = "openShopInfoForm" 
                v-on:deleteThisShop = "deleteShop"
               v-on:openDeleteDialog = "openDeleteDialog"
               v-on:sortByStt = "sortByShopStt"
               v-on:sortByShopCode = "sortByShopCode"
               v-on:sortByName = "sortShopByName"
               v-on:sortByPhone = "sortShopByPhone"
               v-on:reloadData = "reloadData"
                />
      <dialogShopInfoForm v-if="showShopPropDialog"
      v-on:closeShopInfoDia = "closeShopInfoDia"/>
      <deletingDia v-if="showDeletingDialog" v-on:closeDelDia = "closeDelDia" 
      :deleteEShopName = "deleteEShopName"
      :deleteEShopCode = "deleteEshopCode" />
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
      data:[],
      deleteEShopName:"",
      deleteEshopCode:"",
    }
  },
  methods: {
    async deleteShop(payLoad){
      console.log(payLoad.eShopCode+" " + payLoad.eShopName);
      this.deleteEShopName = payLoad.eShopName;
      this.deleteEshopCode = payLoad.eShopCode;
      this.showDeletingDialog = true;
    },
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
    async sortByShopStt(url){
      console.log(url);
      const res = await axios.get('http://localhost:57752/api/v1/EShops/filterByShopStatus?filterString=' + url);
      console.log(res.data);
      this.data = res.data;
    },
    async sortByShopCode(url){
      console.log(url);
      const res = await axios.get('http://localhost:57752/api/v1/EShops/filterByCode?sortByShopCode=' + url);
      console.log(res.data);
      this.data = res.data;
    },
    async sortShopByName(url){
      console.log(url);
      const res = await axios.get('http://localhost:57752/api/v1/EShops/filterByName?sortByShopName=' + url);
      console.log(res.data);
      this.data = res.data;
    },
    async sortShopByPhone(url){
      console.log(url);
      const res = await axios.get('http://localhost:57752/api/v1/EShops/filterByPhoneNumber?filterString=' + url);
      console.log(res.data);
      this.data = res.data;
    },
    async reloadData(){
      const response = await axios.get('http://localhost:57752/api/v1/EShops')
      this.data = response.data;
    },
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
