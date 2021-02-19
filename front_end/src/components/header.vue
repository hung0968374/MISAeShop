<template>
     <div class="header">
        <div class="res__name"><strong>Nha hang bien dong</strong></div>
        <div class="user__info">
            <div class="avatar"></div>
            <div class="user__name">Nguyen Huu Hung</div>
            <div class="icon"></div>
        </div>
    </div>
</template>
<script>
export default {
    name: 'Header'
}
</script>

<style scoped>
    .header {
        position: absolute;
        top: 0px;
        left: 200px;
        width: calc(100% - 200px);
        height: 60px;
        border-left: 1px solid #9e9e9ecf;
        display: inline-flex;
    }
    .res__name {
        margin-top: 10px;
        margin-left: 40px;
        font-size: 30px;
    }
    .user__info {
        margin-top: 15px;
        margin-left: 800px;
    display: inline-flex;
    }
    .user__info .avatar {
        width: 30px;
        height: 30px;
        background-image: url('../assets/icon/avatar-default.png');
        background-size: contain;
        margin-right: 20px;
    }
    .user__info .icon {
        width: 20px;       
        height: 20px;
        background-image: url('../assets/icon/option.png');
        margin-left: 15px;
        margin-top: 5px;
    }
    .user__info .user__name{
        margin-top: 5px;
    }
</style>