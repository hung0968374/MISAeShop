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
                <input type="text" class="address_input" >
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
                    <tr :key = "listData.eShopId" v-for="listData in listDatas" class="hoverShopInfo"
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
        <pageFooter />
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
    computed:{
       
    },
    methods: {
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
        }
    },
    filters: {

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
        left: 200px;
        bottom: 0px;
        right: 0px;
        background-color: #efeeee;
        width: 1322px;
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
       height: 500px;
       OverFlow-y: scroll;
   }
   .shopTable td {
       border: 1px solid green;
   }
   .inputField {
       display: flex;
       width: 1100px;
       margin-left: 10px;
       margin-right: 10px;
       background: chartreuse;
       height: 30px;
   }
   .shopCode_input {
       display: flex;
   }
   .shopName_input {
       display: flex;
   }
   .shopAddress_input {
       display: flex;
   }
   .shopPhoneNum_input {
       display: flex;
   }
    .shopStatus_input {
       display: flex;
   }
   .squareIcon {
       width: 40px;
       background: darkgray;
       display: flex;
       align-items: center;
       justify-content: center;
   }
   .code_input {
       width: 113px;
   }
    .name_input {
       width: 201.4px;
   }
    .address_input {
       width: 483px;
   }
    .phone_input {
       width: 132px;
   }
    .stt_selection {
        width: 181px;
    }
    .shopCode_column {
        width: 150px;
    }
    .shopName_column {
        width: 238px;
    }
    .shopAddress_column {
        width: 520px;
    }
    .shopPhoneNum_column {
        width: 170px;
    }
    td {
        padding: 5px;
    }
</style>