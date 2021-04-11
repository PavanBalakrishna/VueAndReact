<template>
  <div id="app">
    
    <Header :correctAnswerCount="correctAnswerCount"
    :totalAnswerCount="totalAnswerCount" />
    <b-container class="bv-example-row">
      <b-row sm="6" offset="3">
          <QuestionBox v-if="questions.length > 0 && index < questions.length"
                            :currentQuestion="questions[index]"
                            :nextFunction="next"
                            :updateCounter="updateCounter" />
      </b-row>
</b-container>
  
  </div>
</template>

<script>
import Header from './components/Header.vue'
import QuestionBox from './components/QuestionBox.vue'

export default {
  name: 'App',
  components: {
    Header,
    QuestionBox
  },
  data(){
    return {
      questions:[],
      index:0,
      correctAnswerCount:0,
      totalAnswerCount:0
    }
  },
  methods:{
    next(){
      this.index++;
    },
    updateCounter(isCorrectAnswer){
        if(isCorrectAnswer){
          this.correctAnswerCount++;
        }
        this.totalAnswerCount++;
    }
  },
  mounted:function(){
    fetch('https://opentdb.com/api.php?amount=50&difficulty=easy&type=multiple',{
      method:'get'
    }).then((response)=>{
      
      return response.json();
    })
    .then((animalData)=>{
      this.questions=animalData.results;
    })
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
