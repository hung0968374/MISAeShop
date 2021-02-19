<template>
  <div id="app1" v-bind:class="{handleDialog: showDialog }">
      <Menu />
  </div>
</template>

<script>
import Menu from './components/menu';

export default {
  name: 'App',
  components: {
    Menu,
  },
  data() {
    return {
      content : [
      ],
      cusInfo:[
        {
          BaseSalary:"", 
          Category:"", 
          DateJoinFirm:"", 
          DateOfBirth:"", 
          Email:"", 
          EmployeeCode:"", 
          EmployeeId:"", 
          FullName:"", 
          Gender:"", 
          GivenDate:"", 
          GivenPlace:"", 
          IdentityCard:"", 
          PersonalTax:"", 
          PhoneNumber:"", 
          Position:"", 
          WorkStatus:"", 
        },
      ],
      showDialog: false,
      affectedByDiaStt: true,
      showEditEmInfoDia: false,
    }
  },
  methods: {
    
  },
  async created (){
   
  }
}
</script>

<style>
  * {
    margin: 0px;
  }
  #app1 {
    margin: 0px;
    height: 98vh;
  }
  .handleDialog {
    background-color: #69696954;
  }
</style>
