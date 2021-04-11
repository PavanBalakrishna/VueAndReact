new Vue({
    el:'#root',
    data:{
        message:'',
        email:'',
        newMember:'',
        jfam:[
            'Pavan',
            'Vinay',
            'Varsha',
            'Chethan',
            'Kushal'
        ]
    },
    methods:{
        addMember:function(){
            this.jfam.push(this.newMember);
            this.newMember="";
        }
    },
    filters:{
        capitalize:function(value){
            return value.toUpperCase();
        }
    }
})