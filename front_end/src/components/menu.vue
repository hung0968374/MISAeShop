<template>
     <div class="menu">
        <div class="logo">
        </div>
        <div class="menu__content">
            <div class="menu__item">
                <div class="menu__icon1"></div>
                <div class="menu__content1">Tổng quan</div>
            </div>
            <div class="menu__item">
                <div class="menu__icon2"></div>
                <div class="menu__content1">Báo cáo</div>
            </div>
            <div class="menu__item">
                <div class="menu__icon3"></div>
                <div class="menu__content1">Đơn hàng</div>
            </div>
            <div class="menu__item">
                <div class="menu__icon4"></div>
                <div class="menu__content1">Mua hàng</div>
            </div>
            <div class="menu__item">
                <div class="menu__icon5"></div>
                <div class="menu__content1">Khuyến mại</div>
            </div>
            <div class="menu__item5">
                <div class="menu__icon6"></div>
                <div class="menu__content1">Quản lý cửa hàng</div>
            </div>
            <div class="menu__item">
                <div class="menu__icon5"></div>
                <div class="menu__content1">Hàng hóa</div>
            </div>
        </div>
    </div>
</template>
<script>
export default {
    name: 'Menu'
}
</script>

<style scoped>
    .menu{
        width: 10.5%;
        height: 100vh;
        margin: 0px;
        background-color: #026b97;
        color: white;
    }
    .menu .logo{
        width: 100%;
        height: 60px;   
        background-image: url('../assets/Logo_Full_White.png') ;
        background-size: contain;
        background-repeat: no-repeat;
        background-color: #00577b;
        cursor: pointer;
    }
    .menu .menu__content .menu__item {
        display: flex;
        padding: 15px;
    }
    .menu .menu__content .menu__item5 {
        display: flex;
        background-color: #00577b;
         padding: 15px;
    }   
    .menu .menu__content .menu__item .menu__icon1 {
        background: url('../assets/iconMenu.png') no-repeat -5px -5px;
        width: 20px;
        height: 16px;
    }
    .menu .menu__content .menu__item .menu__icon2 {
        background: url('../assets/iconMenu.png') no-repeat -3px -194px;
        width: 20px;
        height: 20px;
    }
    .menu .menu__content .menu__item .menu__icon3 {
        background: url('../assets/iconMenu.png') no-repeat -5px -458px;
        width: 20px;
        height: 20px;
    }
    .menu .menu__content .menu__item .menu__icon4 {
        background: url('../assets/iconMenu.png') no-repeat -1px -377px;
        width: 24px;
        height: 19px;
    }
    .menu .menu__content .menu__item .menu__icon5 {
        background: url('../assets/iconMenu.png') no-repeat -5px -334px;
        width: 20px;
        height: 16px;
    }
    .menu .menu__content .menu__item5 .menu__icon6 {
        background: url('../assets/iconMenu.png') no-repeat -3px -160px;
        width: 18px;
        height: 15px;
    }
    .menu .menu__content .menu__item .menu__content1{
        padding-left: 10px;
    }   
    .menu .menu__content .menu__item5 .menu__content1{
        padding-left: 10px;
    }
</style>