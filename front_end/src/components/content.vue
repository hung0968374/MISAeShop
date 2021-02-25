<template>
    <div class="content_part">
        <userChoice v-on:shopFormDiaSttOpened ="openShopForm"
                    v-on:openDeleteDialog = "openDeleteDialog"
                    v-on:reloadData = "reloadData"
                    v-on:addNewShopBtn = "addNewShopBtn"/>
        <shopProp />
        <div class="inputField">
            <div class="shopCode_input">
                <div class="squareIcon">*</div>
                <input type="text" class="code_input" @keyup.enter="sortByCode" v-model="shopCode">
            </div>
             <div class="shopName_input">
                <div class="squareIcon">*</div>
                <input type="text" class="name_input"  @keyup.enter="sortByName" v-model="shopName">
            </div>
             <div class="shopAddress_input">
                <div class="squareIcon">*</div>
                <input type="text" class="address_input" @keyup.enter="sortByAddress" v-model="shopAddress">
            </div>
             <div class="shopPhoneNum_input">
                <div class="squareIcon">*</div>
                <input type="text" class="phone_input"  @keyup.enter="sortByPhone" v-model="shopPhone">
            </div>
             <div class="shopStatus_input">
                <select class="stt_selection" @change="sttOnChange" v-model="shopStt">
                    <option value="0">Đang hoạt động</option>
                    <option value="1">Đã đóng cửa</option>
                </select>
            </div>
        </div>
        <div class="shoptbl">
            <table class="shopTable">
                <thead>
                    <tr>
                        
                    </tr>
                </thead>
                <tbody>
                    <tr :key = "listData.eShopId" v-for="listData in listSlicedData" class="hoverShopInfo"
                    @mouseup.right="$emit('deleteThisShop',
                     {eShopCode : listData.eShopCode,
                     eShopName:listData.eShopName})"
                     @dblclick="$emit('changeShopInfo', listData.eShopCode)">
                        <td class="shopCode_column">{{listData.eShopCode}}</td>
                        <td class="shopName_column">{{listData.eShopName}}</td>
                        <td class="shopAddress_column">{{listData.eShopAddress}}</td>
                        <td class="shopPhoneNum_column">{{listData.eShopPhoneNumber}}</td>
                        <td class="shopStt_column">{{listData.eShopStatus}}</td>
                    </tr>
                </tbody>
            </table>
        </div>
        <pageFooter v-on:Pagination = "Pagination" />
    </div>
</template>
<script>
import userChoice from './userChoice';
import shopProp from './shopProp';
import pageFooter from './pageFooter';
// import axios from 'axios';
export default {
    name:'Content',
    components: {
      userChoice,
      shopProp,
      pageFooter
    },
    props: ["listDatas"],
    
    methods: {
        Pagination(page){
            // this.listDatas = this.listDatas.slice(20*(page-1), 20*page);
            this.currentPage = page;
        },
        openShopForm(){
            this.$emit('openShopForm');
        },
        openDeleteDialog: function(){
            this.$emit('openDeleteDialog');
        },
       
        sttOnChange(){
            console.log(this.shopStt);
            if (this.shopStt == 0){
                this.shopSttContent = "Đang hoạt động";
            }
            else{
                this.shopSttContent = "Đã đóng cửa";
            }
            this.$emit('sortByStt',this.shopSttContent);
        },
        addNewShopBtn(){
            this.$emit('addNewShopBtn');
        },
        reloadData(){
            this.$emit('reloadData');
        },
        sortByName(){
            this.$emit("sortByName", this.shopName);
        },
        sortByCode(){
            this.$emit("sortByShopCode", this.shopCode);
        },
        sortByPhone(){
            this.$emit("sortByPhone", this.shopPhone);
        },
        sortByAddress(){
            this.$emit("sortByAddress", this.shopAddress);
        },
            // console.log(shopCode);
            // const response =  axios.delete('http://localhost:57752/api/v1/EShops/delete/' + shopCode);
            // console.log(response);
            // const response = await axios.delete('http://localhost:57752/api/v1/EShops/delete/' + shopCode, {
            //     data: {foo: 'bar'}
            // });
            // console.log(response);
    },
    data() {
        return {
            shopStt: 0,
            shopSttContent: "",
            shopCode:"",
            shopName: "",
            shopAddress:"",
            shopPhone:"",
            currentPage: 1,
        }
    },
    filters: {

    },
    computed: {
        listSlicedData(){
            return  this.listDatas.slice(13*(this.currentPage-1), 13*this.currentPage);
        }
    }
}

</script>

<style scoped>
    .hoverShopInfo:hover {
        background: #c3ecff;
    }
   .content_part {
        position: absolute;
        top: 60px;
        left: 10.5%;
        bottom: 0px;
        right: 0px;
        background-color:  #efeeee;
        width: 89.5%;
   }
   tbody tr:nth-child(even){
       background-color: white;
   }
   td {
       cursor: pointer;
   }
   .shopTable {
       width: 100%;
       margin-left: 10px;
       margin-right: 10px;
       border: 1px solid red;
       border-collapse: collapse;
       font-size: 16px;
   }
   .shoptbl {
       height: calc(95% - 170px);
       width: 100%;
       OverFlow-y: scroll;
       OverFlow-x: hidden;
   }
   .shopTable td {
       border: 1px solid darkgray;
   }
   .inputField {
       display: flex;
       width: 98.8%;
       margin-left: 11px;
       margin-right: 10px;
       height: 30px;
   }
   .shopCode_input {
       display: flex;
       width: 10%;
   }
   .shopName_input {
       display: flex;
       width: 15%;
   }
   .shopAddress_input {
       display: flex;
       width: 51%;
   }
   .shopPhoneNum_input {
       display: flex;
       width: 12%;
   }
    .shopStatus_input {
       display: flex;
       width: 12%;
   }
   .squareIcon {
       width: 40px;
       background: darkgray;
       display: flex;
       align-items: center;
       justify-content: center;
   }
   .code_input {
       width: calc(100% - 40px);
   }
    .name_input {
       width: calc(100% - 40px);
   }
    .address_input {
       width: calc(100% - 40px);
   }
    .phone_input {
       width: calc(100% - 40px);
   }
    .stt_selection {
        width: 100%;
    }
    .shopCode_column {
        width: 9.99%;
    }
    .shopName_column {
        width: 15%;
    }
    .shopAddress_column {
        width: 50.5%;
    }
    .shopPhoneNum_column {
        width: 12%;
    }
    .shopStt_column {
        width: 12%;
    }
    td {
        padding: 5px;
    }
</style>