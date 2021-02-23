<template>
  <div class="footer">
    <div class="toTopNav">
      <div class="toTopNav_icon"></div>
    </div>
    <div class="toPrevNav">
      <div class="toPrevNav_icon"></div>
    </div>
    Trang
    <div class="currentPage">1</div>
    trên 1
    <div class="toNexNav">
      <div class="toNextNav_icon"></div>
    </div>
    <div class="toLastNav">
      <div class="toLastNav_icon"></div>
    </div>
    <div class="reload">
      <div class="reload_icon"></div>
    </div>
    <select class="pageSlect">
      <option value="">50</option>
    </select>
    <div class="displayResult">Hiển thị 1-13 trên 13 kết quả</div>
  </div>
</template>
<script>
export default {
  name: "pageFooter",
};
</script>
<style scoped>
.footer {
  position: absolute;
  margin: 0 10px 0 10px;
  border-top: 1px solid darkgray;
  padding: 10px;
  display: flex;
  top: 628px;
  width: 1275px;
}
.toTopNav {
  padding: 5px;
  border: 1px solid black;
  margin-left: 2px;
}
.toPrevNav {
  padding: 5px;
  border: 1px solid black;
  margin-left: 2px;
  margin-right: 10px;

}
.toNexNav {
  padding: 5px;
  border: 1px solid black;
  margin-left: 2px;
}
.toLastNav {
  padding: 5px;
  border: 1px solid black;
  margin-left: 2px;
}
.toTopNav_icon {
  background: url("../assets/common-icon.png") no-repeat -656px -131px;
  width: 8px;
  height: 8px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.toPrevNav_icon {
  background: url("../assets/common-icon.png") no-repeat -708px -131px;
  width: 5px;
  height: 8px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.toNextNav_icon {
  background: url("../assets/common-icon.png") no-repeat  -758px -131px;
  width: 8px;
  height: 8px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.toLastNav_icon {
  background: url("../assets/common-icon.png") no-repeat -806px -131px;
  width: 8px;
  height: 8px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.currentPage {
  padding: 0px 10px 0px 10px;
  border: 1px solid black;
  margin-left: 10px;
  margin-right: 10px;
}
.reload {
    padding: 0px 5px 0px 5px;
    border: 1px solid black;
    margin-left: 2px;
    margin-right: 2px;
}
.reload_icon {
     background: url("../assets/common-icon.png") no-repeat -855px -128px;
  width: 10px;
  height: 14px;
  display: flex;
  align-items: center;
  justify-content: center;
  margin-top: 2px;
}
.displayResult {
    margin-right: 30px;
    margin-left: auto;
}
</style>