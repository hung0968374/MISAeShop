<template>
    <div class="footer">
        <div class="topNavIcon">
            <div class="toTopNav_icon"></div>
        </div>
        <div class="toPrevNav_icon"></div>
        Trang
        <div class="currentPage">1</div>
        tren 1
        <div class="toNextNav_icon"></div>
        <div class="toLastNav_icon"></div>
        <div class="reload_icon"></div>
        <select class="pageSlect">
            <option value="">50</option>
        </select>
        <div class="displayResult">Hien thi 1-13 ket qua</div>
    </div>
</template>
<script>
export default {
    name: 'pageFooter',
   
}
</script>
<style scoped>
    .footer {
        position: absolute;
        margin: 0 10px 0 10px;
        background: rgb(213, 238, 213);
        padding: 10px;
        display: flex;
        top: 628px;
        width: 1275px;
    }
    .topNavIcon {
        width: 40px;
        border: 1px solid black;
    }
    .toTopNav_icon {
        background: url('../assets/common-icon.png') no-repeat -681px -156px;
	width: 8px;
	height: 8px;
    }
</style>