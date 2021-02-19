<template>
    <div class="division4">
            <div class="text__left">Hien thi 1-10/10000 khach hang</div>
            <div class="funct">
                <div class="icon1"></div>
                <div class="icon2"></div>
                <div class="pages">
                    <div v-for="(page, index) in pages" :key="index" class="page"
                    @click = openPage(page,index) v-bind:class="{beingClicked: clickStt[index] }" >
                        {{clickStt[index]}}
                    </div>
                </div>
                <div class="icon3"></div>
                <div class="icon4"></div>
            </div>
            <div class="text__right">10 khach hang/trang
            </div>
    </div>
</template>
<script>
export default {
    name: 'Footer',
    methods: {
        openPage(a, index){
            this.$emit('openPageNum', a);
            console.log(index);
            this.clickStt[index] = true;
            for (var i=0; i<4; i++){
                if (i != index){
                    this.clickStt[i] = false;
                    this.trackKey = index;
                }
            }
            console.log(this.clickStt);
        }
    },
    data() {
        return {
            pages:["1","2","3","4"],
            clickStt: [false, false, false, false],
            trackKey: parseInt,
        }
    },
}
</script>
<style scoped>
    .beingClicked {
        background-color: blueviolet  !important;   
    } 
    .division4{
        margin-top: 0;
        width: 100%;
        margin-top: 30px;
        display: inline-flex;
        border-top: 1px solid darkgray;
    }
    .text__left{
        padding-top: 5px;
        padding-left: 50px;
        font-size: 12px;
    }
    .text__right {
        padding-top: 5px;
        padding-left: 50px;
        font-size: 12px;
    }
    .funct{
        margin-left: 300px;
        margin-right: 300px;
        display: inline-flex;
    }
    .funct .icon1 {
        width: 30px;
        height: 30px;
        background-image: url('../assets/icon/btn-firstpage.svg');
        background-size: contain;
    }
    .funct .icon2 {
        width: 30px;
        height: 30px;
        
        background-image: url('../assets/icon/btn-prev-page.svg');
        background-size: contain;
    }
    .funct .icon3 {
        width: 30px;
        height: 30px;
        background-image: url('../assets/icon/btn-next-page.svg');
        background-size: contain;
    }
    .funct .icon4 {
        width: 30px;
        height: 30px;
        background-image: url('../assets/icon/btn-lastpage.svg');
        background-size: contain;
        background-repeat: no-repeat;
    }
    .funct .pages{
        display: inline-flex;
    }
    .funct .pages .page{
        margin-left: 20px;
        width: 20px;
        height: 20px;
        margin-top: 5px;
        border-radius: 50%;
        background-color: darkgray;
        text-align: center;
    }
    .page4{
        margin-right:10px;
    }
    
    .funct .pages .page:hover {
        background: chocolate;
        cursor: pointer;
    }
</style>