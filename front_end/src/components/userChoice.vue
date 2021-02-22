<template>
  <div class="inside_content">
    <div class="user_choice">
      <div class="adding_new" v-on:click = "changingDiaShopFormStt">
        <div class="adding_icon"></div>
        <div class="adding_content" >Thêm mới</div>
      </div>
      <div class="clone">
        <div class="clone_icon"></div>
        <div class="clone_content">Nhân bản</div>
      </div>
      <div class="change">
        <div class="change_icon"></div>
        <div class="change_content">Sửa</div>
      </div>
      <div class="delete" @click="openDeleteDialog">
        <div class="delete_icon"></div>
        <div class="delete_content" >Xóa</div>
      </div>
      <div class="recharge" @click="reloadData">
        <div class="recharge_icon"></div>
        <div class="recharge_content" >Nạp</div>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: "userChoice",
  methods: {
    changingDiaShopFormStt: function(){
      this.$emit('shopFormDiaSttOpened');
    },
    openDeleteDialog: function(){
      alert("Bạn hãy chọn shop muốn xóa rồi ấn chuột phải 1 cái nhé!");
    },
    reloadData: function(){
      this.$emit('reloadData');
    }
  }
};
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
.inside_content {
  margin: 10px 10px 0px 10px;
}
.user_choice {
  display: flex;
  background-color: blueviolet;
}

.adding_new {
  display: flex;
  padding: 10px;
  border-left: 1px solid rgb(8, 8, 94);
  width: 130px;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
}
.clone {
  display: flex;
  padding: 10px;
  border-left: 1px solid rgb(8, 8, 94);
  width: 130px;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
}

.change {
  display: flex;
  padding: 10px;
  border-left: 1px solid rgb(8, 8, 94);
  width: 130px;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
}
.delete {
  display: flex;
  padding: 10px;
  border-left: 1px solid rgb(8, 8, 94);
  width: 130px;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
}
.recharge {
  display: flex;
  padding: 10px;
  border-left: 1px solid rgb(8, 8, 94);
  width: 130px;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
}
.adding_icon {
  background: url("../assets/common-icon.png") no-repeat -4px -130px;
  width: 12px;
  height: 11px;
  margin-top: 3px;
  margin-right: 10px;
}
.clone_icon {
  background: url("../assets/common-icon.png") no-repeat -54px -53px;
  width: 12px;
  height: 11px;
  margin-top: 3px;
  margin-right: 10px;
}
.change_icon {
  background: url("../assets/common-icon.png") no-repeat -79px -205px;
  width: 12px;
  height: 12px;
  margin-top: 3px;
  margin-right: 10px;
}
.delete_icon {
  background: url("../assets/common-icon.png") no-repeat -4px -53px;
  width: 12px;
  height: 14px;
  margin-top: 3px;
  margin-right: 10px;
}
.recharge_icon {
  background: url("../assets/common-icon.png") no-repeat -129px -202px;
  width: 12px;
  height: 16px;
  margin-top: 3px;
  margin-right: 10px;
}
</style>