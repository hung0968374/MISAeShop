<template>
  <div>
    <div class="styleDia"></div>
    <div class="dialog">
      <div class="title">
        <strong>{{ this.eShopDiaTitle }}</strong>
        <span class="x_icon" @click="closeShopInfoDia">x</span>
      </div>
      <div class="shopPropInfo">
        <div class="shopCode" >
          Mã cửa hàng
          <span class="redStarIcon" style="margin-left: 5px">*</span>
          <input
            type="text"
            class="input1"
            style="width: 500px; height: 35px"
            autofocus
            tabindex="1"
            v-model="eShop.eShopCode"
            v-bind:class="{blankShopCode : isBlankShopCode}"
          />
        </div>
        <div class="shopName">
          Tên cửa hàng
          <span class="redStarIcon" style="margin-left: 5px">*</span>
          <input
            type="text"
            class="input1"
            style="width: 500px; height: 35px"
            tabindex="1"
            v-model="eShop.eShopName"
            v-bind:class="{blankShopName : isBlankShopName}"
          />
        </div>
        <div class="shopAddress" >
          Địa chỉ
          <span class="redStarIcon" style="margin-left: 5px">*</span>
          <input
            type="text"
            class="input1"
            style="width: 500px; height: 70px"
            tabindex="1"
            v-model="eShop.eShopAddress"
            v-bind:class="{blankShopAddress : isBlankShopAddress}"
          />
        </div>
        <div class="shopPhone_TaxCode">
          <div class="shopPhone">
            Số điện thoại
            <input
              type="text"
              class="input1"
              tabindex="1"
              style="width: 200px; height: 35px"
              v-model="eShop.eShopPhoneNumber"
            />
          </div>
          <div class="shopTaxCode">
            Mã số thuế
            <input
              type="text"
              style="width: 200px; height: 35px"
              tabindex="1"
              v-model="eShop.eShopTaxCode"
            />
          </div>
        </div>
        <div class="shopNationality">
          Quốc gia
          <select
            class="input1"
            style="width: 205px; height: 35px"
            tabindex="1"
            v-model="eShop.eShopNationality"
          >
            <option value="0">Việt Nam</option>
            <option value="1">Singapore</option>
          </select>
        </div>
        <div class="shopProvinceDistrict">
          <div class="shopProvince">
            Tỉnh/Thành phố
            <select
              v-model="Province"
              class="input1"
              tabindex="1"
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
            <select
              v-model="District"
              style="width: 206px; height: 35px"
              tabindex="1"
            >
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
            <select
              class="input1"
              style="width: 205px; height: 35px"
              tabindex="1"
              v-model="eShop.eShopVillage"
            >
              <option value="">Liêm Mạc</option>
            </select>
          </div>
          <div class="shopRoad">
            Đường phố
            <input
              type="text"
              style="width: 200px; height: 35px"
              tabindex="1"
              v-model="eShop.eShopRoad"
            />
          </div>
        </div>
      </div>
      <div class="footer">
        <div class="helping">
          <div class="helping_icon" tabindex="1"></div>
          Trợ giúp
        </div>
        <div class="saving" @click="saveShopInfo">
          <div class="saving_icon" tabindex="1"></div>
          Lưu
        </div>
        <div class="saveAndAdd" @click="addingNewEshop">
          <div class="saveAndAdd_icon" tabindex="1"></div>
          Lưu và Thêm mới
        </div>
        <div class="cancel" @click="closeShopInfoDia" tabindex="1">
          <div class="cancel_icon"></div>
          Hủy bỏ
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import axios from "axios";
export default {
  name: "dialogShopInfoForm",
  data() {
    return {
      arr: [
        {
          name: "Hà Nội",
          sub: [
            { name: "Bắc Từ Liêm" },
            { name: "Nam Từ Liêm" },
            { name: "Cầu Giấy" },
            { name: "Hoàn Kiếm" },
            { name: "Hà Đông" },
            { name: "Tây Hồ" },
          ],
        },
        {
          name: "Hồ Chí Minh",
          sub: [
            { name: "Quận Bình Tân" },
            { name: "Quận Bình Thạnh" },
            { name: "Quận Gò Vấp" },
            { name: "Quận Thủ Đức" },
            { name: "Huyện Nhà Bè" },
            { name: "Huyện Hóc Môn" },
            { name: "Quận 1" },
            { name: "Quận 2" },
            { name: "Quận 3" },
            { name: "Quận 4" },
            { name: "Quận 5" },
          ],
        },
        {
          name: "Đà Nẵng",
          sub: [
            { name: "Quận Hải Châu" },
            { name: "Quận Cẩm Lệ" },
            { name: "Quận Thanh Khê" },
            { name: "Quận Liên Chiểu" },
            { name: "Quận Ngũ Hành Sơn" },
            { name: "Quận Sơn Trà" },
            { name: "Huyện Hoàng Vang" },
            { name: "Huyện Hoàng Sa" },
          ],
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
      eShopDiaTitle: "",
      eShopClone: {
        eShopAddress: "",
        eShopCode: "",
        eShopDistrict: "",
        eShopName: "",
        eShopNationality: "",
        eShopPhoneNumber: "",
        eShopProvince: "",
        eShopRoad: "",
        eShopStatus: "",
        eShopTaxCode: "",
        eShopVillage: "",
      },
      warningMesg: "",
      qualifiedToPost: true,
      qualifiedToPut: true,
      isBlankShopCode: false,
      isBlankShopName: false,
      isBlankShopAddress: false,
    };
  },
  beforeMount: function () {
    this.updateCity();
  },
  watch: {
    Province: function () {
      this.updateCity();
    },
    city: function () {},
  },
  props: ["eShopCodeForChangingData", "openChangeShop"],
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
    async addingNewEshop() {
      if (this.openChangeShop) {
        alert(
          '"Lưu và thêm mới" chỉ dành cho chuyên mục thêm mới khách hàng, để sửa khách hàng hãy chọn "Lưu" bạn nhé!'
        );
      } else {
        this.warningMesg = "";
        if (!this.eShop.eShopCode) {
          this.warningMesg += "Không được để trống mã cửa hàng";
          this.qualifiedToPost = false;
          this.isBlankShopCode = true;
        }
        else{
          this.isBlankShopCode = false;
        }
        if (!this.eShop.eShopName) {
          this.warningMesg += "Không được để trống tên cửa hàng,";
          this.qualifiedToPost = false;
          this.isBlankShopName = true;
        } 
        else{
          this.isBlankShopName = false;
        }
        if (!this.eShop.eShopAddress) {
          this.warningMesg += "Không được để trống địa chỉ cửa hàng,";
          this.qualifiedToPost = false;
          this.isBlankShopAddress = true;
        } 
        else{
           this.isBlankShopAddress = false;
        }
        if (!this.eShop.eShopPhoneNumber) {
          this.warningMesg += "Không được để trống số điện thoại cửa hàng";
          this.qualifiedToPost = false;
        }
        if (this.warningMesg){
          alert(this.warningMesg);
        }
        if (this.eShop.eShopNationality == 0) {
          this.eShop.eShopNationality = "Việt Nam";
        } else {
          this.eShop.eShopNationality = "Singapore";
        }
        this.eShop.eShopAddress = "";
        this.eShop.eShopAddress += ",";
        this.eShop.eShopProvince = this.Province;
        this.eShop.eShopDistrict = this.District;
        if (this.eShop.eShopRoad != "") {
          this.eShop.eShopAddress += this.eShop.eShopRoad + " ";
        }
        if (this.eShop.eShopVillage != "") {
          this.eShop.eShopAddress += this.eShop.eShopVillage + " ";
        }
        this.eShop.eShopAddress +=
          this.eShop.eShopDistrict + " " + this.eShop.eShopProvince;
        this.eShopClone.eShopAddress = this.eShop.eShopAddress;
        this.eShopClone.eShopCode = this.eShop.eShopCode;
        this.eShopClone.eShopDistrict = this.eShop.eShopDistrict;
        this.eShopClone.eShopName = this.eShop.eShopName;
        this.eShopClone.eShopNationality = this.eShop.eShopNationality;
        this.eShopClone.eShopPhoneNumber = this.eShop.eShopPhoneNumber;
        this.eShopClone.eShopProvince = this.eShop.eShopProvince;
        this.eShopClone.eShopRoad = this.eShop.eShopRoad;
        this.eShopClone.eShopStatus = "Đang hoạt động";
        this.eShopClone.eShopTaxCode = this.eShop.eShopTaxCode;
        this.eShopClone.eShopVillage = this.eShop.eShopStatus;
        if (this.qualifiedToPost) {
          const response = await axios.post(
            "http://localhost:57752/api/v1/EShops",
            this.eShopClone
          );
          console.log(response.data.MISACode);
          if (response.data.MISACode == 200 || response.data.MISACode == 201) {
            alert("Đã thêm thành công thông tin shop mới");
            this.$emit("closeShopInfoDia");
            this.$parent.loadData();
          } else if (response.data.MISACode == 400) {
            alert(
              "Thông tin bị trùng, bạn vui lòng sửa lại các trường thông tin có dấu sao hoặc thay đổi số điện thoại bạn nhé"
            );
          }
        }
      }
    },
    async saveShopInfo() {
      if (this.openChangeShop) {
        this.warningMesg = "";
        if (!this.eShop.eShopCode) {
          this.warningMesg += "Không được để trống mã cửa hàng, ";
          this.qualifiedToPut = false;
          this.isBlankShopCode = true;
        }
        else{
          this.isBlankShopCode = false;
        } 
        if (!this.eShop.eShopName) {
          this.warningMesg += "Không được để trống tên cửa hàng, ";
          this.qualifiedToPut = false;
          this.isBlankShopName = true;
        } 
        else{
          this.isBlankShopName = false;
        }
        if (!this.eShop.eShopAddress) {
          this.warningMesg += "Không được để trống địa chỉ cửa hàng, ";
          this.qualifiedToPut = false;
          this.isBlankShopAddress = true;
        } 
        else{
          this.isBlankShopAddress = false;
        }
        if (!this.eShop.eShopPhoneNumber) {
          this.warningMesg += "Không được để trống số điện thoại, ";
          this.qualifiedToPut = false;
        }
        if (this.warningMesg){
          alert(this.warningMesg);
        }
        if (this.eShop.eShopNationality == 0) {
          this.eShop.eShopNationality = "Việt Nam";
        } else {
          this.eShop.eShopNationality = "Singapore";
        }
        this.eShop.eShopAddress = "";
        this.eShop.eShopProvince = this.Province;
        this.eShop.eShopDistrict = this.District;
        if (this.eShop.eShopRoad != "") {
          this.eShop.eShopAddress += this.eShop.eShopRoad + ", ";
        }
        if (this.eShop.eShopVillage != "") {
          this.eShop.eShopAddress += this.eShop.eShopVillage + ", ";
        }
        this.eShop.eShopAddress +=
          this.eShop.eShopDistrict + " " + this.eShop.eShopProvince;
        this.eShopClone.eShopAddress = this.eShop.eShopAddress;
        this.eShopClone.eShopCode = this.eShop.eShopCode;
        this.eShopClone.eShopDistrict = this.eShop.eShopDistrict;
        this.eShopClone.eShopName = this.eShop.eShopName;
        this.eShopClone.eShopNationality = this.eShop.eShopNationality;
        this.eShopClone.eShopPhoneNumber = this.eShop.eShopPhoneNumber;
        this.eShopClone.eShopProvince = this.eShop.eShopProvince;
        this.eShopClone.eShopRoad = this.eShop.eShopRoad;
        this.eShopClone.eShopStatus = "Đang hoạt động";
        this.eShopClone.eShopTaxCode = this.eShop.eShopTaxCode;
        this.eShopClone.eShopVillage = this.eShop.eShopStatus;
        if (this.qualifiedToPut) {
          console.log(this.eShop.eShopId);
          const res = await axios.put(
            "http://localhost:57752/api/v1/EShops/" + this.eShop.eShopId,
            this.eShopClone
          );
          console.log(res.data);
          if (res.data.MISACode == 400) {
            alert(
              "Thông tin bị trùng, bạn vui lòng sửa lại các trường thông tin có dấu sao hoặc thay đổi số điện thoại bạn nhé"
            );
          } else if (res.data.MISACode == 200 || res.data.MISACode == 201) {
            alert("Bạn đã sửa thành công thông tin shop vừa chọn");
            this.$emit("closeShopInfoDia");
            this.$parent.loadData();
          }
        }
      } else {
        alert(
          '"Sửa" chỉ dành cho chuyên mục sửa khách hàng, để thêm mới, hãy chọn "Lưu và thêm mới" bạn nhé!'
        );
      }
    },
  },
  async mounted() {
    if (this.openChangeShop) {
      const response = await axios.get(
        "http://localhost:57752/api/v1/EShops/filterByCode?sortByShopCode=" +
          this.eShopCodeForChangingData
      );
      this.eShop = response.data[0];
      this.eShopDiaTitle = "Sửa cửa hàng";
      this.Province = this.eShop.eShopProvince;
      this.District = this.eShop.District;
    } else {
      this.eShopDiaTitle = "Thêm mới cửa hàng";
    }
  },
};
</script>
<style scoped>
.styleDia{
  opacity: 0.4;
  background-color: black;
  top: 0;
  bottom: 0;
  right: 0;
  left: 0;
  position: fixed;
}
.dialog {
  height: 552px;
  width: 680px;
  background: white;
  z-index: 3;
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  overflow-x: scroll;
  border-radius: 5px;
  overflow: hidden;
}
.title {
  height: 40px;
  background: rgb(220 220 220 / 73%);
  border-bottom: 0.5px solid darkgray;
  font-size: 20px;
  padding: 15px;
  display: flex;
  align-items: center;
}
.x_icon {
  margin-left: auto;
  margin-right: 10px;
  color: darkgray;
  cursor: pointer;
  font-size: 25px;
}
.shopPropInfo {
  padding: 15px;
  font-size: 16px !important ;
}
.redStarIcon {
  color: red;
}
.shopCode {
  display: flex;
  align-items: center;
  margin-top: 30px;
  font-size: 16px;
}
.shopName {
  margin-top: 25px;
  display: flex;
  align-items: center;
  font-size: 16px;
}
.shopAddress {
  margin-top: 50px;
  margin-bottom: 25px;
  display: flex;
  align-items: center;
  font-size: 16px;
  width: 700px;
}
.shopPhone {
  margin-top: 25px;
  display: flex;
  align-items: center;
  font-size: 16px;
}
.shopNationality {
  margin-top: 25px;
  display: flex;
  align-items: center;
  font-size: 16px;
}
.shopProvince {
  margin-top: 25px;
  display: flex;
  align-items: center;
  font-size: 16px;
}
.shopVillage {
  margin-top: 25px;
  display: flex;
  align-items: center;
  font-size: 16px;
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
  left: 267px;
}
select {
  border: 1px solid black;
}
.shopDistrict {
  position: relative;
  top: 15px;
  left: 241px;
}
.shopRoad {
  position: relative;
  top: 15px;
  left: 279px;
}
.footer {
  display: flex;
  padding: 20px;
  margin-top: 20px;
  border-top: 0.5px solid darkgray;
  font-size: 16px;
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
  cursor: pointer;
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
  cursor: pointer;
}
.cancel {
  display: flex;
  align-items: center;
  cursor: pointer;
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
.blankShopAddress {
  border: 1px solid red;
}
.blankShopName {
  border: 1px solid red;
}
.blankShopCode {
  border: 1px solid red;
}
</style>
