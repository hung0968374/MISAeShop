<template>
  <div class="header">
    <div class="restaurant__name"><strong>Cửa hàng</strong></div>
        <div class="sub_title">
            <div class="address">
                <select class="option_name">
                <option>DODAVI - 160 Hoàng Hoa Thám</option>
                </select>
            </div>
            <div class="user__info">
                <div class="avatar"></div>
                <select class="user_option">
                <option>qtht misa</option>
                </select>
            </div>
            <div class="icon">
                <div class="support_icon"></div>
                <div class="notification_icon"></div>
                <div class="questionMark_icon"></div>
            </div>
        </div>
  </div>
</template>
<script>
export default {
  name: "Header",
};
</script>

<style scoped>
.header {
  position: absolute;
  top: 0px;
  left: 10.5%;
  width: 89.5%;
  height: 40px;
  border-left: 1px solid #9e9e9ecf;
  display: inline-flex;
  margin-top: 20px;
}
.sub_title {
    margin-right: 15px;
    margin-left: auto;
    display: flex;
}
.icon {
  display: flex;
  align-items: center;
  height: 40px;
}
.restaurant__name {
  margin-left: 40px;
  font-size: 30px;
}
.user__info {
  display: flex;
}
.option_name {
  padding: 10px;
}
.user_option {
  padding: 10px;
  height: 40px;
  border: none;
}
.avatar {
  width: 40px;
  height: 40px;
  background-repeat: no-repeat;
  background-size: contain;
  border-radius: 50%;
  border: 0.01px solid rgba(167, 161, 161, 0.747);
  background-image: url("../assets/EmployeeImage.png");
  margin-top: -2px;
}
.selection {
  padding: 0px;
}
.support_icon {
  width: 60px;
  height: 40px;
  background-image: url("../assets/phoneCall.png");
  background-size: contain;
  background-repeat: no-repeat;
}
.notification_icon {
  width: 40px;
  height: 40px;
  background-image: url("../assets/noti_icon.webp");
  background-size: contain;
  background-repeat: no-repeat;
  border: 0.02px solid rgba(214, 208, 208, 0.555);
}
.questionMark_icon {
  width: 40px;
  height: 40px;
  background-image: url("../assets/ques_icon.jpg");
  background-size: contain;
  background-repeat: no-repeat;
  border: 0.02px solid rgba(214, 208, 208, 0.555);
}
.address {
  margin-right: 10px;
}
</style>