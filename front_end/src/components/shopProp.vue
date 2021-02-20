<template>
    <div class="shop_property">
        <div class="shop_code">
            Mã cửa hàng
        </div>
        <div class="shop_name">Tên cửa hàng</div>
        <div class="shop_address">Địa chỉ</div>
        <div class="shop_phoneNumber">Số diện thoại</div>
        <div class="shop_status">Trạng thái</div>
    </div>
</template>
<script>
export default {
    name: 'shopProp'
}
</script>
<style scoped>
    .content_part {
        position: absolute;
        top: 60px;
        left: 200px;
        bottom: 0px;
        right: 0px;
        background-color: #efeeee;
   }
   .shop_property {
       display: flex
   }
   .shop_code{
       width: 177px;
       background: blue;
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
   }
   .shop_name {
        width: 277px;
       background: rgb(32, 114, 83);
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
   }
   .shop_address {
        width: 587px;
       background: rgb(255, 166, 0);
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
   }
   .shop_phoneNumber {
        width: 200px;
       background: rgb(255, 0, 43);
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
   }
   .shop_status {
         width: 200px;
       background: rgb(0, 153, 255);
       display: flex;
       align-items: center;
       justify-content: center;
       border-radius: 3px;
   }
   .shop_property {
       margin-left: 10px;
       margin-right: 10px ;
       height: 40px;
   }
</style>