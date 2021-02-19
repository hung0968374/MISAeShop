<template>
    <div class="content_part">
        <userChoice/>
    </div>
</template>
<script>
import userChoice from './userChoice';
export default {
    name:'Content',
    components: {
      userChoice,
    },
    computed:{
       
    },
    methods: {
        
    },
    data() {
        return {
            
        }
    },
    filters: {

    }
}

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
</style>