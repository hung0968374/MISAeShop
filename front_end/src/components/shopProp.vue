<template>
    <div class="shop_property">
        <div class="shop_code">
            Mã cửa hàng
        </div>
        <div class="shop_name">Tên cửa hàng</div>
        <div class="shop_address">Địa chỉ</div>
        <div class="shop_phoneNumber">Số điện thoại</div>
        <div class="shop_status">Trạng thái</div>
    </div>
</template>
<script>
export default {
    name: 'shopProp'
}
</script>
<style scoped>
   .shop_property {
       display: flex
   }
   .shop_code{
       width: 10%;
       background: #d4cacab9;
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
       margin: 1px;
   }
   .shop_name {
       width: 15%;
       background: #d4cacab9;
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
        margin: 1px;
   }
   .shop_address {
       width: 51%;
       background: #d4cacab9;
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
       margin: 1px;
   }
   .shop_phoneNumber {
       width: 12%;
       background: #d4cacab9;
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
       margin: 1px;
   }
   .shop_status {
       width: 12%;
       background: #d4cacab9;
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
        margin: 1px;
   }
   .shop_property {
       margin-left: 10px;
       margin-right: 10px ;
       height: 40px;
   }
</style>