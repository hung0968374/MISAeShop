<template>
    <div class="dialog">
        <div class="title">
            <div class="til">
                <p><strong>Xóa dữ liệu</strong></p>
            </div>
            <div class="x_icon" @click="closeDelDia">X</div>
        </div>
        <div class="question">
            <div class="question_icon"></div>
            <div class="content">Bạn có chắc muốn xóa {{this.deleteEShopName}} khỏi danh sách khách hàng?</div>
        </div>
        <div class="footer">
            <div class="deleting" @click="deleteShop">
                <div class="del_icon"></div>
                Xóa
            </div>
            <div class="cancel" @click="closeDelDia">
                <div class="cancel_icon"></div>
                Hủy bỏ
            </div>
        </div>
    </div>
</template>

<script>
import axios from 'axios';
export default {
    name:'deletingDia',
    methods: {
        closeDelDia: function(){
            this.$emit("closeDelDia");
        },
        async deleteShop(){
            console.log(this.deleteEShopCode);
            const response = await axios.delete('http://localhost:57752/api/v1/EShops/delete/' + this.deleteEShopCode, {
                data: {foo: 'bar'}
            });
            console.log(response);
            this.$emit("closeDelDia");
        }
    },
    props:[ "deleteEShopCode","deleteEShopName"],

}
</script>
<style scoped>
    
    .title {
        height: 40px;
        background: blanchedalmond;
        font-size: 18px;
        padding: 15px; 
        display: inline-flex;
        align-items: center;
        border-radius: 5px;
    }
    .til {
        width: 200px;
    }
    .x_icon {
        margin-left: 335px;
        color: brown;
    }
    .question {
        padding: 15px 30px 30px 15px;
        font-size: 18px;
        height: 50px;
        background: rgb(235, 225, 225);
        display: flex;
        align-items: center;
    }
    .question_icon {
        width: 50px;
        background-image: url('../assets/question_icon.jpg');
        height: 50px;
        border-radius: 50%;
        background-size: contain;
        margin-right: 15px;
    }
    .footer {
        height: 38px;
        background-color: darkcyan;
        font-size: 18px;
        padding: 15px ;
        display: flex;
        border-radius: 5px;
    }
    .deleting {
        height: 15px;
        padding:10px 40px 10px 25px;
        background-color: red;
        display: flex;
        align-items: center;
        border-radius: 5px;
        margin-left: 250px;
    }
    .del_icon {
        background: url('../assets/common-icon.png') no-repeat -105px -204px;
	width: 10px;
	height: 12px;
    margin-right: 10px ;
    }
    .cancel {
        height: 15px;
        padding: 10px 40px 10px 25px;
        display: flex;
        align-items: center;
    }
    .cancel_icon {
          background: url('../assets/common-icon.png') no-repeat -255px -130px;
	width: 10px;
	height: 12px;
    margin-right: 10px ;
    }
    .dialog {
        height: 232px;
        width: 578px;  
        background: white;
        z-index: 4;
        position: fixed;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
    }
    .x_icon {
        cursor: pointer;
    }
    .deleting {
        cursor: pointer;
    }
    .cancel {
        cursor: pointer;
    }
</style>