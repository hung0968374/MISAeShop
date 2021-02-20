<template>
  <div class="dialog">
    <div class="title"><strong>Thêm mới cửa hàng</strong>
      <span class="x_icon">X</span>
    </div>
    <div class="shopPropInfo">
      <div class="shopCode">Mã cửa hàng 
        <span class="redStarIcon" style="margin-left: 5px">*</span>
        <input type="text" class="input1" style="width: 500px; height: 35px">
      </div>
      <div class="shopName">Tên cửa hàng 
        <span class="redStarIcon" style="margin-left: 5px">*</span>
        <input type="text"  class="input1" style="width: 500px; height: 35px" >
      </div>
      <div class="shopAddress">Địa chỉ
        <span class="redStarIcon" style="margin-left: 5px">*</span>
        <input type="text" class="input1" style="width: 500px; height: 70px">
      </div>
      <div class="shopPhone_TaxCode">
        <div class="shopPhone">
          Số điện thoại
          <span class="redStarIcon" style="margin-left: 5px">*</span>
          <input type="text" class="input1" style="width: 200px; height: 35px">
        </div>
        <div class="shopTaxCode">
          Mã số thuế
          <span class="redStarIcon" style="margin-left: 5px">*</span>
          <input type="text" style="width: 200px; height: 35px">
        </div>
      </div>
      <div class="shopNationality">Quốc gia
        <select class="input1" style="width: 205px; height: 35px">
          <option value="">Viet Nam</option>
        </select>
      </div>
      <div class="shopProvinceDistrict">
        <div class="shopProvice">
          Tỉnh/Thành phố
          <select class="input1"  style="width: 205px; height: 35px">
            <option value="">Ha Noi</option>
            <option value="">Ha Noi</option>
            <option value="">Ha Noi</option>
            <option value="">Ha Noi</option>
          </select>
        </div>
        <div class="shopDistrict">
          Quận/huyện
          <select style="width: 205px; height: 35px">
            <option value="">Bac tu liem</option>
            <option value="">Ha Noi</option>
            <option value="">Ha Noi</option>
            <option value="">Ha Noi</option>
          </select>
        </div>
      </div>
      <div class="shopVillageRoad">
        <div class="shopVillage" >Phường/xã
          <select class="input1" style="width: 205px; height: 35px">
            <option value="">Liem Mac</option>
            <option value="">Ha Noi</option>
            <option value="">Ha Noi</option>
            <option value="">Ha Noi</option>
          </select>
        </div>
        <div class="shopRoad">Đường phố
          <span class="redStarIcon">*</span>
          <input type="text"  style="width: 200px; height: 35px">
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: 'dialogShopInfoForm',
  props:{

  },

}
</script>
<style scoped>
  .dialog {
    height: 600px;
    width: 700px;
    background: white;
    z-index: 3;
    position: fixed;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    border-radius: 2px;
  }
  .title {
    height: 40px;
    background: blanchedalmond;
    font-size: 18px;
    padding: 15px; 
    display: flex;
    align-items: center
  }
  .x_icon {
      margin-left: 500px;
      color: brown;
  }
  .shopPropInfo {
    padding: 15px;
  }
  .redStarIcon {
    color: red;
  }
  .shopCode {
    display: flex;
    align-items: center;
    margin-top: 30px;
    font-size: 18px;
  }
  .shopName {
    margin-top: 25px;
    display: flex;
    align-items: center;
    font-size: 18px;
  }
  .shopAddress {
    margin-top: 50px;
    margin-bottom: 25px;
    display: flex;
    align-items: center;
    font-size: 18px;
    width: 700px;
  }
  .shopPhone {
    margin-top: 25px;
    display: flex;
    align-items: center;
    font-size: 18px;
  }
  .shopNationality {
    margin-top: 25px;
    display: flex;
    align-items: center;
    font-size: 18px;
  }
  .shopProvice {
    margin-top: 25px;
    display: flex;
    align-items: center;
    font-size: 18px;
  }
  .shopVillage {
    margin-top: 25px;
    display: flex;
    align-items: center;
    font-size: 18px;
  }
  .input1 {
    position: absolute;
    left: 160px;
  }
  input {
    border: 1px solid black;
  }
  .shopPhone_TaxCode {
    display: inline-flex;
  }
  .shopProvinceDistrict {
    display: flex;
  }
  .shopVillageRoad {
    display: flex;
  }
  .shopTaxCode {
    position: relative;
    top: 15px;
    left: 249px;
  }
  select {
    border: 1px solid black;
  }
  .shopDistrict {
    position: relative;
    top: 15px;
    left: 248px;
  }
  .shopRoad {
    position: relative;
    top: 15px;
    left: 282px;
  }
</style>