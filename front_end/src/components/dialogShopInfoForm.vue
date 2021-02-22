<template>
  <div class="dialog">
    <div class="title">
      <strong>Thêm mới cửa hàng</strong>
      <span class="x_icon" @click="closeShopInfoDia">X</span>
    </div>
    <div class="shopPropInfo">
      <div class="shopCode" >
        Mã cửa hàng
        <span class="redStarIcon" style="margin-left: 5px">*</span>
        <input type="text" class="input1" style="width: 500px; height: 35px" autofocus tabindex="1"
        v-model="eShop.eShopCode"/>
      </div>
      <div class="shopName">
        Tên cửa hàng
        <span class="redStarIcon" style="margin-left: 5px">*</span>
        <input type="text" class="input1" style="width: 500px; height: 35px" tabindex="1"
        v-model="eShop.eShopName"/>
      </div>
      <div class="shopAddress">
        Địa chỉ
        <span class="redStarIcon" style="margin-left: 5px">*</span>
        <input type="text" class="input1" style="width: 500px; height: 70px" tabindex="1"
        v-model="eShop.eShopAddress"/>
      </div>
      <div class="shopPhone_TaxCode">
        <div class="shopPhone">
          Số điện thoại
          <input
            type="text"
            class="input1" tabindex="1"
            style="width: 200px; height: 35px "
            v-model="eShop.eShopPhoneNumber"
          />
        </div>
        <div class="shopTaxCode">
          Mã số thuế
          <input type="text" style="width: 200px; height: 35px" tabindex="1"
          v-model="eShop.eShopTaxCode"
          />
        </div>
      </div>
      <div class="shopNationality">
        Quốc gia
        <select class="input1" style="width: 205px; height: 35px" tabindex="1" v-model="eShop.eShopCode">
          <option value="">Viet Nam</option>
        </select>
      </div>
      <div class="shopProvinceDistrict">
        <div class="shopProvince">
          Tỉnh/Thành phố
          <select
            v-model="Province"
            class="input1" tabindex="1"
            style="width: 205px; height: 35px"
          >
            <option
              v-for="(option, index) in arr"
              :value="option.name"
              :key="index"
            >
              {{ option.name }}
            </option>
          </select>
        </div>
        <div class="shopDistrict">
          Quận/huyện
          <select v-model="District" style="width: 205px; height: 35px" tabindex="1">
            <option
              v-for="(option, index) in DistrictArr"
              :value="option.name"
              :key="index"
            >
              {{ option.name }}
            </option>
          </select>
        </div>
      </div>
      <div class="shopVillageRoad">
        <div class="shopVillage">
          Phường/xã
          <select class="input1" style="width: 205px; height: 35px" tabindex="1"
          v-model="eShop.eShopVillage">
            <option value="">Liêm Mạc</option>
          </select>
        </div>
        <div class="shopRoad" >
          Đường phố
          <input type="text" style="width: 200px; height: 35px" tabindex="1"
          v-model="eShop.eShopRoad" />
        </div>
      </div>
    </div>
    <div class="footer">
      <div class="helping">
        <div class="helping_icon" tabindex="1"></div>
        Trợ giúp
      </div>
      <div class="saving">
        <div class="saving_icon" tabindex="1"></div>
        Lưu
      </div>
      <div class="saveAndAdd" @click="addingNewEshop">
        <div class="saveAndAdd_icon" tabindex="1" ></div>
        Lưu và Thêm mới
      </div>
      <div class="cancel" @click="closeShopInfoDia" tabindex="1">
        <div class="cancel_icon"></div>
        Hủy bỏ
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: "dialogShopInfoForm",
  data() {
    return {
      arr: [
        {
          name: "Hà Nội",
          sub: [{ name: "Bắc Từ Liêm" }, { name: "Nam Từ Liêm" }, { name: "Cầu Giấy" }, { name: "Hoàn Kiếm" }
          , { name: "Hà Đông" }, { name: "Tây Hồ" }],
        },
        {
          name: "Hồ Chí Minh",
          sub: [{ name: "Quận Bình Tân" }, { name: "Quận Bình Thạnh" }, { name: "Quận Gò Vấp" }, 
          { name: "Quận Thủ Đức" }, { name: "Huyện Nhà Bè" }, { name: "Huyện Hóc Môn" },
          { name: "Quận 1" }, { name: "Quận 2" },{ name: "Quận 3" }, { name: "Quận 4" }, { name: "Quận 5" }],
        },
        {
          name: "Đà Nẵng",
          sub: [{ name: "Quận Hải Châu" }, { name: "Quận Cẩm Lệ" }, { name: "Quận Thanh Khê" }, 
          { name: "Quận Liên Chiểu" }, { name: "Quận Ngũ Hành Sơn" }, { name: "Quận Sơn Trà" },
          { name: "Huyện Hoàng Vang" }, { name: "Huyện Hoàng Sa" }, ],
        },
      ],
      Province: "Hà Nội",
      District: "Bắc Từ Liêm",
      DistrictArr: [],
      eShop: {
        eShopAddress: "",
        eShopCode: "",
        eShopDistrict: "",
        eShopId: "",
        eShopName: "",
        eShopNationality: "",
        eShopPhoneNumber: "",
        eShopProvince: "",
        eShopRoad: "",
        eShopStatus: "",
        eShopTaxCode: "",
        eShopVillage: "",
      },
      warningMesg : "",
    };
  },
  beforeMount: function () {
    this.updateCity();
  },
  watch: {
    Province: function () {
      this.updateCity();
    },
    city: function () {
    },
  },
  props: {},
  methods: {
    closeShopInfoDia: function () {
      this.$emit("closeShopInfoDia");
    },
    updateCity() {
      for (let i in this.arr) {
        let obj = this.arr[i].name;
        if (obj == this.Province) {
          this.DistrictArr = this.arr[i].sub;
        }
      }
    },
    async addingNewEshop(){
      this.warningMesg="";
      if (!this.eShop.eShopCode ){
        this.warningMesg += "Khong duoc de trong ma cua hang";
        alert(this.warningMesg);
      }
      else if (!this.eShop.eShopName){
        this.warningMesg += "Khong duoc de trong ten cua hang";
        alert(this.warningMesg);
      }
      else if (!this.eShop.eShopAddress){
        this.warningMesg += "Khong duoc de trong dia chi cua hang";
        alert(this.warningMesg);
      }
    }
  },
};
</script>
<style scoped>
.dialog {
  height: 600px;
  width: 680px;
  background: white;
  z-index: 3;
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  overflow-x: scroll;
  border-radius: 5px;
}
.title {
  height: 40px;
  background: blanchedalmond;
  font-size: 18px;
  padding: 15px;
  display: flex;
  align-items: center;
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
.shopProvince {
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
  left: 275px;
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
  left: 290px;
}
.footer {
  display: flex;
  padding: 20px;
  margin-top: 20px;
  border-top: 0.5px solid darkgray;
  font-size: 18px;
}
.helping {
  display: flex;
  align-items: center;
}
.saving {
  display: flex;
  height: 15px;
  padding: 10px;
  align-items: center;
  background: darkblue;
  margin-left: 180px;
  color: white;
}
.saveAndAdd {
  display: flex;
  align-items: center;
  margin-left: 22px;
  height: 15px;
  padding: 10px;
  border: 1px solid darkblue;
  color: darkblue;
  border-radius: 3px;
  margin-right: 30px;
}
.cancel {
  display: flex;
  align-items: center;
}
.helping_icon {
  background: url("../assets/common-icon.png") no-repeat -179px -179px;
  width: 12px;
  height: 12px;
  margin-right: 10px;
}
.saving_icon {
  background: url("../assets/common-icon.png") no-repeat -330px -129px;
  width: 12px;
  height: 12px;
  margin-right: 10px;
}
.saveAndAdd_icon {
  background: url("../assets/common-icon.png") no-repeat -29px -130px;
  width: 12px;
  height: 12px;
  margin-right: 10px;
}
.cancel_icon {
  background: url("../assets/common-icon.png") no-repeat -255px -130px;
  width: 12px;
  height: 12px;
  margin-right: 10px;
}
</style>