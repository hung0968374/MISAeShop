<template>
    <div class="content_part">
        <userChoice v-on:shopFormDiaSttOpened ="openShopForm"
                    v-on:openDeleteDialog = "openDeleteDialog"/>
        <shopProp />
        <div class="inputField">
            <div class="shopCode_input">
                <div class="squareIcon">*</div>
                <input type="text" class="code_input">
            </div>
             <div class="shopName_input">
                <div class="squareIcon">*</div>
                <input type="text" class="name_input">
            </div>
             <div class="shopAddress_input">
                <div class="squareIcon">*</div>
                <input type="text" class="address_input">
            </div>
             <div class="shopPhoneNum_input">
                <div class="squareIcon">*</div>
                <input type="text" class="phone_input">
            </div>
             <div class="shopStatus_input">
                <select class="stt_selection">
                    <option value="">Dang hoat dong</option>
                    <option value="">Da dong cua</option>
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
                    @dblclick="$emit('deleteThisShop', {eShopId: listData.eShopId, eShopName: listData.eShopName})">
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
    },
    data() {
        return {
            
        }
    },
    filters: {

    }
}

</script>

<style scoped>
    .hoverShopInfo:hover {
        background: blueviolet;
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