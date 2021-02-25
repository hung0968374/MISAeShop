<template>
  <div id="app1" v-bind:class="{handleDialog: showShopPropDialog, handleDelDia: showDeletingDialog }">
      <Menu />
      <Header />
      <Content :listDatas ="this.data"
                
                v-on:openShopForm = "openShopInfoForm" 
                v-on:deleteThisShop = "deleteShop"
               v-on:openDeleteDialog = "openDeleteDialog"
               v-on:sortByStt = "sortByShopStt"
               v-on:sortByShopCode = "sortByShopCode"
               v-on:sortByName = "sortShopByName"
               v-on:sortByPhone = "sortShopByPhone"
               v-on:reloadData = "reloadData"
               v-on:changeShopInfo = "changeShopInfo"
               v-on:addNewShopBtn = "addNewShopBtn"
               v-on:sortByAddress = "sortByAddress"
                />
      <dialogShopInfoForm v-if="showShopPropDialog"
      v-on:closeShopInfoDia = "closeShopInfoDia"
      :eShopCodeForChangingData = "this.eShopShopCodeForChangingData"
      :openChangeShop = "this.openChangeShop"
      />
      <deletingDia v-if="showDeletingDialog" v-on:closeDelDia = "closeDelDia" 
      :deleteEShopName = "deleteEShopName"
      :deleteEShopCode = "deleteEshopCode" 
      :loadData = "loadData"/>
  </div>
</template>

<script>
import Menu from './components/layout/menu';
import Header from './components/layout/header';
import Content from './views/content';
import dialogShopInfoForm from './components/common/dialogShopInfoForm';
import deletingDia from './components/common/deletingDia';
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
      eShopShopCodeForChangingData: "",
      openChangeShop:false,
    }
  },
  methods: {
      changeShopInfo(shopCode){
        this.openChangeShop = true;
        this.showShopPropDialog = !this.showShopPropDialog;
        // const response = await axios.get('http://localhost:57752/api/v1/EShops/filterByCode?sortByShopCode=' + shopCode);
        // this.eShopAllInfo = response.data;
        this.eShopShopCodeForChangingData = shopCode;
        console.log(this.eShopShopCodeForChangingData);
    },
    async deleteShop(payLoad){
      console.log(payLoad.eShopCode+" " + payLoad.eShopName);
      this.deleteEShopName = payLoad.eShopName;
      this.deleteEshopCode = payLoad.eShopCode;
      this.showDeletingDialog = true;
    },
    addNewShopBtn(){
      this.openShopInfoForm = false;
    },
    openShopInfoForm: function(){
      this.showShopPropDialog = !this.showShopPropDialog;
    },
    openDeleteDialog:function(){
      this.showDeletingDialog = !this.showDeletingDialog;
    },
    closeShopInfoDia:function(){
       this.showShopPropDialog = !this.showShopPropDialog;
       this.openChangeShop = false;
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
    async sortByAddress(url){
      console.log(url);
      const res = await axios.get('http://localhost:57752/api/v1/EShops/filterByAddress?filterString=' + url);
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
    // async Pagination(page){
    //   const response = await axios.get('http://localhost:57752/api/v1/EShops');
    //   this.data = response.data;
    //   this.data = this.data.slice(20*(page-1), 20*page)
    //   console.log(page);
    //   console.log(this.data);
    // }
    async loadData(){
      const response = await axios.get('http://localhost:57752/api/v1/EShops')
      this.data = response.data;
    }
  },
  created (){
      this.loadData();
  }
}
</script>

<style>
  * {
    margin: 0px;
    font-family: sans-serif;
  }
  body {
    OverFlow: hidden;
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
