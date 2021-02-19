<template>
  <div class="dialog">
    <div class="title">Danh sach khach hang</div>
    <div class="flex1">
      <div class="dia_img">
        <div class="user_img"></div>
        <div class="dia_noti">
          (Vui lòng chọn ảnh có định dạng .jqg, .jpeg, .png, .gif)
        </div>
      </div>
      <div class="flex_userInFo">
        <div class="dia_user_info">
          <div id="genaralInfo"><strong>A. THÔNG TIN CHUNG</strong></div>
          <div class="dia_code_name">
            <div class="dia_EmployCode">
              <div class="em_code">
                Mã nhân viên(<span id="subContent" style="color: red">*</span>)
                <div>
                  <input
                    autofocus
                    @keydown="$v.employeeInfo.EmployeeCode.$touch()"
                    v-model.trim="$v.employeeInfo.EmployeeCode.$model"
                    type="text"
                    id="txtEmployCode"
                    style="width: 300px; height: 30px"
                    :class="{
                      isNotValid: $v.employeeInfo.EmployeeCode.$error,
                    }"
                  />
                </div>
                <span
                  v-if="$v.employeeInfo.EmployeeCode.$error"
                  class="invalidMessage"
                  >Trường này không được để trống</span
                >
              </div>
            </div>
            <div class="em_fullName">
              Họ và tên(<span id="subContent" style="color: red">*</span>)
              <div>
                <input
                  @keydown="$v.employeeInfo.FullName.$touch()"
                  v-model.trim="$v.employeeInfo.FullName.$model"
                  type="text"
                  id="employFullName"
                  style="width: 300px; height: 30px"
                  :class="{
                    isNotValid: $v.employeeInfo.FullName.$error,
                  }"
                />
                <span
                  v-if="$v.employeeInfo.FullName.$error"
                  class="invalidMessage"
                  >Trường này không được để trống</span
                >
              </div>
            </div>
          </div>
          <div>
            <div class="dia_dob_gen">
              <div class="dia_em_dob">
                <div class="em_dob">
                  Ngày sinh
                  <div>
                    <input
                      type="date"
                      id="dia_dob"
                      style="width: 304px; height: 30px"
                      v-model="employeeInfo.DateOfBirth"
                    />
                  </div>
                </div>
              </div>
              <div class="dia_gender">
                Giới tính
                <div>
                  <select
                    id="dia_gender"
                    style="width: 307px; height: 34px"
                    v-model="employeeInfo.Gender"
                  >
                    <option value="0">Nam</option>
                    <option value="1">Nu</option>
                  </select>
                </div>
              </div>
            </div>
          </div>
          <div class="dia_inden_dateGiven">
            <div class="dia_iden">
              Số CMTND/Căn Cước(<span id="subContent" style="color: red">*</span
              >)
              <div>
                <input
                  @keydown="$v.employeeInfo.IdentityCard.$touch()"
                  v-model.trim="$v.employeeInfo.IdentityCard.$model"
                  type="text"
                  id="dia_iden_num"
                  style="width: 300px; height: 30px"
                  :class="{
                    isNotValid: $v.employeeInfo.IdentityCard.$error,
                  }"
                />
                <span
                  v-if="$v.employeeInfo.IdentityCard.$error"
                  class="invalidMessage"
                  >Trường này không được để trống</span
                >
              </div>
            </div>
            <div class="em_dateGiven">
              Ngày cấp
              <div class="em_iden_date">
                <input
                  type="date"
                  id="iden_given_date"
                  style="width: 304px; height: 30px"
                  v-model="employeeInfo.GivenDate"
                />
              </div>
            </div>
          </div>
          <div class="iden_givenPlace">
            Nơi cấp
            <div>
              <input
                v-model="employeeInfo.GivenPlace"
                type="text"
                id=" iden_givenAddress"
                style="width: 300px; height: 30px"
              />
            </div>
          </div>
          <div class="dia_email_phoneNum">
            <div id="dia_email">
              Email(<span id="subContent" style="color: red">*</span>)
              <div>
                <input
                  v-model.trim="$v.employeeInfo.Email.$model"
                  type="email"
                  id="employ_email"
                  @keydown="$v.employeeInfo.Email.$touch()"
                  name="email"
                  pattern="[a-zA-Z0-9!#$%&amp;'*+\/=?^_`{|}~.-]+@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)*"
                  style="width: 300px; height: 30px"
                  :class="{
                    isNotValid: $v.employeeInfo.Email.$error,
                  }"
                />
                <span
                  v-if="$v.employeeInfo.Email.$error"
                  class="invalidMessage"
                  >Trường này không được để trống</span
                >
              </div>
            </div>
            <div id="dia_phoneNum">
              Số điện thoại(<span id="subContent" style="color: red">*</span>)
              <div>
                <input
                  v-model.trim="$v.employeeInfo.PhoneNumber.$model"
                  type="text"
                  @keydown="$v.employeeInfo.PhoneNumber.$touch()"
                  id="employ_phoneNum"
                  style="width: 300px; height: 30px"
                  :class="{
                    isNotValid: $v.employeeInfo.PhoneNumber.$error,
                  }"
                />
              </div>
              <span
                v-if="$v.employeeInfo.PhoneNumber.required"
                class="invalidMessage"
                >Trường này không được để trống
               </span>
               
                <span
                v-if="!$v.employeeInfo.PhoneNumber.numeric"
                class="invalidMessage"
                >Phải là 1 số hợp lệ
               </span>
            </div>
          </div>
        </div>

        <div class="Work_info">
          <div id="Work_content"><strong>B: THÔNG TIN CÔNG VIỆC </strong></div>
          <div class="dia_pos_cate">
            <div id="dia_pos">
              Vị trí
              <div>
                <select
                  id="employee_pos"
                  name="select"
                  style="width: 307px; height: 34px"
                  v-model="employeeInfo.Position"
                >
                  <option value="0">Giám đốc</option>
                  <option value="1">Thu ngân</option>
                  <option value="2">Nhân viên marketing</option>
                </select>
              </div>
            </div>
            <div id="dia_cate">
              Phòng ban
              <div>
                <select
                  id="employee_cate"
                  style="width: 307px; height: 34px"
                  v-model="employeeInfo.Category"
                >
                  <option value="0">Phòng nhân sự</option>
                  <option value="1">Phòng marketing</option>
                  <option value="2">Phòng công nghệ</option>
                </select>
              </div>
            </div>
          </div>
          <div>
            <div class="dia_tax_salary">
              <div class="employ_tax">
                Mã số thuế cá nhân
                <div>
                  <input
                    type="text"
                    id="employee_tax"
                    style="width: 300px; height: 30px"
                    v-model="employeeInfo.PersonalTax"
                  />
                </div>
              </div>
              <div class="employ_base_sala">
                Mức lương cơ bản
                <div>
                  <input
                    type="text"
                    id="employee_baseSalary"
                    style="width: 300px; height: 30px"
                    v-model="employeeInfo.BaseSalary"
                  />
                </div>
              </div>
            </div>
          </div>
          <div class="dia_dateJoin_status">
            <div class="dia_dateJoin">
              Ngày gia nhập công ty
              <div>
                <input
                  type="date"
                  id="employ_date_join"
                  style="width: 304px; height: 30px"
                  v-model="employeeInfo.DateJoinFirm"
                />
              </div>
            </div>
            <div class="dia_status">
              Tình trạng công việc
              <div>
                <select
                  id="employee_status"
                  style="width: 307px; height: 34px"
                  v-model="employeeInfo.WorkStatus"
                >
                  <option value="0">Đang thử việc</option>
                  <option value="1">Đã nghỉ hưu</option>
                  <option value="2">Đa nghỉ việc</option>
                </select>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="footer">
      <div class="dia_cancel_bttn">
        <div class="dia_cancel_bttn_content" v-on:click="handleDialog">Hủy</div>
      </div>
      <div class="dia_del_bttn">
        <div
          class="dia_del_bttn_content"
          :class="{ hideDelBttn: affectedByDiaStt }"
          @click="delEmployeeInfo"
        >
          Xóa
        </div>
      </div>
      <div class="dia_save_bttn">
        <div class="dia_save_bttn_content" @click="create_new_emp">Lưu</div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
import { required ,numeric } from "vuelidate/lib/validators";

export default {
  name: "Dialog",
  data() {
    return {
      employeeInfo: {
        BaseSalary: "",
        Category: "",
        DateJoinFirm: "",
        DateOfBirth: "",
        Email: "",
        EmployeeCode: "",
        FullName: "",
        Gender: "",
        GivenDate: "",
        GivenPlace: "",
        IdentityCard: "",
        PersonalTax: "",
        PhoneNumber: "",
        Position: "",
        WorkStatus: "",
      },
    };
  },
  props: ["cusInfo", "affectedByDiaStt", "selectedEm", "showEditEmInfoDia"],
  methods: {
    handleDialog: function () {
      this.$emit("dialogStatusChanged");
    },
    async create_new_emp() {
      if (!this.showEditEmInfoDia) {
        console.log(this.employeeInfo);
        const response = await axios.post(
          "http://localhost:52319/api/Employees",
          this.employeeInfo
        );
        // console.log(response.data.MISACode);
        if (response.data.MISACode == 200) {
          this.$emit("dialogStatusChanged");
          alert("Da them nhan vien");
        } else {
          alert("Ban phai nhap lai cac truong thong tin co dau sao");
        }
      } else if (this.showEditEmInfoDia) {
        const emInfo = this.employeeInfo;
        delete emInfo.EmployeeId;
        console.log(emInfo);
        const response = await axios.post(
          "http://localhost:52319/api/Employees",
          emInfo
        );
        console.log(response);
        if (response.data.MISACode == 200) {
          this.$emit("dialogStatusChanged");
          alert("Ban da sua nhan vien");
        } else {
          alert("Ban phai nhap lai cac truong thong tin co dau sao");
        }
      }
    },
    async delEmployeeInfo() {
      console.log(this.employeeInfo.EmployeeId);
      const delId = this.employeeInfo.EmployeeId;
      const response = await axios.delete(
        "http://localhost:52319/api/Employees/" + delId
      );
      alert("Ban da xoa nhan vien nay");
      this.$emit("dialogStatusChanged");
      console.log(response);
    },
  },
  async mounted() {
    if (this.showEditEmInfoDia) {
      const res = await axios.get(
        "http://localhost:52319/api/Employees/" + this.selectedEm
      );
      console.log(res);
      this.employeeInfo = res.data;
    }
  },
  validations: {
    employeeInfo: {
      EmployeeCode: {
        required,
      },
      FullName: {
        required,
      },
      IdentityCard: {
        required,
      },
      Email: {
        required,
      },
      PhoneNumber: {
        required,
        numeric
      },
    },
  },
};
</script>

<style scoped>
/* validate */
.invalidMessage {
  color: red;
}
input{
    border: solid 0.5px;
    border-radius: 2px;
}
.validMessage {
  color: blue;
}
.isNotValid {
  border-color: red;
}
.isValid {
  border-color: aqua;
}
#dia_email {
  width: 309px;
}
.dia_iden {
  width: 309px;
}
/* validate */

.dialog {
  height: 700px;
  width: 900px;
  background: white;
  z-index: 3;
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  overflow-y: scroll;
  border-radius: 25px;
}
.hideDelBttn {
  display: none !important;
}
.title {
  font-size: 30px;
  font-weight: bold;
  margin: 43px 219px;
}
.flex1 {
  display: inline-flex;
}
.flex1 .dia_img {
  flex: 1;
}
.flex1 .flex_userInFo {
  flex: 3;
}
.flex1 .flex_userInFo .dia_code_name {
  display: inline-flex;
  margin-top: 20px;
}
.flex1 .flex_userInFo .dia_dob_gen {
  display: inline-flex;
  margin-top: 20px;
}
.flex1 .flex_userInFo .dia_inden_dateGiven {
  display: inline-flex;
  margin-top: 20px;
}
.flex1 .flex_userInFo .dia_email_phoneNum {
  display: inline-flex;
  margin-top: 20px;
}
.em_fullName {
  margin-left: 10px;
}
.dia_gender {
  margin-left: 10px;
}
.em_dateGiven {
  margin-left: 10px;
}
#dia_phoneNum {
  margin-left: 10px;
}
#dia_cate {
  margin-left: 10px;
}
.employ_base_sala {
  margin-left: 10px;
}
.dia_status {
  margin-left: 10px;
}
.iden_givenPlace {
  margin-top: 20px;
}
.Work_info {
  margin-top: 20px;
}
.Work_info .dia_pos_cate {
  display: inline-flex;
  margin-top: 20px;
}
.Work_info .dia_tax_salary {
  display: inline-flex;
  margin-top: 20px;
}
.Work_info .dia_dateJoin_status {
  display: inline-flex;
  margin-top: 20px;
}
.user_img {
  margin-top: 10px;
  width: 80%;
  margin-left: auto;
  margin-right: auto;
  border-radius: 50%;
  height: 170px;
  border: 1px solid darkgray;
  background-image: url("../assets/img/default-avatar.jpg");
  justify-content: center;
  justify-items: center;
  background-size: contain;
}
.dia_noti {
  width: 80%;
  margin-left: auto;
  margin-right: auto;
  justify-items: center;
}
.footer {
  margin-top: 25px;
  display: inline-flex;
  width: 100%;
  height: 46px;
  background-color: #a9a9a933;
  align-items: center;
  font-size: 17px;
}
.dia_save_bttn {
  width: 60px;
  height: 60%;
  margin-top: auto;
  margin-bottom: auto;
  background-color: #0dd18f;
  justify-content: center;
  align-content: center;
  align-items: center;
}
.dia_cancel_bttn {
  margin-left: 60%;
  margin-right: 10%;
}
.dia_del_bttn {
  margin-right: 10%;
}
.dia_save_bttn_content {
  padding-top: 4px;
  padding-left: 14px;
}
</style>