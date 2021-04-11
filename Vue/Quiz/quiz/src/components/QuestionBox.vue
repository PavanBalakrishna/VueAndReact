<template>
    <div class="question-box-container">
         <b-jumbotron>
            <template v-slot:lead>
                {{currentQuestion.question | URLDecodeText}}
            </template>
            <hr class="my-4">
                <b-list-group>
                    <b-list-group-item  v-for="(answer, index) in shuffledAnswers" :key="index" 
                    @click.prevent="SelectedAnswer(index)"
                    :class="(selectedAnswerIndex==index ? 'selected-answer':(IsWrongAnswer && index==correctIndex ? 'right-answer':''))"
                    :disabled="IsAnswered"
                    >   
                        {{answer | URLDecodeText}}
                    </b-list-group-item>
                </b-list-group>
            <b-button variant="primary" @click="SubmitAnswer" :disabled="selectedAnswerIndex == null || IsAnswered" >Submit</b-button>
            <b-button variant="success"  @click="nextFunction" :disabled="!IsAnswered">Next</b-button>
        </b-jumbotron>
    </div>
</template>


<script>
import _ from 'lodash';
export default {
    //used to pass information form parent element to child
    props:{
        
        currentQuestion:Object,
        nextFunction:Function,
        updateCounter:Function
    },
    //Used for data binding
    data:function(){
        return{
            selectedAnswerIndex:null,
            correctIndex:null,
            shuffledAnswers:[],
            isCorrectAnswer:false,
            IsAnswered:false,
            IsWrongAnswer:false
        }
    },
    //Properties used for computations
    computed: {
        answers(){
            let allAnswers=this.currentQuestion.incorrect_answers;
            allAnswers.push(this.currentQuestion.correct_answer);
            
            return allAnswers;
        }
    },
    methods:{
        SelectedAnswer(answerIndex){
            this.selectedAnswerIndex=answerIndex;
        },
        ShuffleAnswers(){
            let answers=[...this.currentQuestion.incorrect_answers, this.currentQuestion.correct_answer];
            this.shuffledAnswers=_.shuffle(answers);
            this.correctIndex=this.shuffledAnswers.indexOf(this.currentQuestion.correct_answer);
            return answers;
        },
        //Checking if index is true
        SubmitAnswer(){
            //Check if answer is correct
            if(this.selectedAnswerIndex === this.correctIndex){
                this.isCorrectAnswer=true;
                this.nextFunction();
            }else{
                this.IsWrongAnswer=true;
            }

            //Calling parent function to update counter
            this.updateCounter(this.isCorrectAnswer);
            
            //Question is answered
            this.IsAnswered=true;
        },
        
    },
    filters:{
        URLDecodeText(value){
            console.log( Html.fr (value))
            return decodeURIComponent(value);
        }
    }
    //used to watch when data values are changed
    ,watch:{
        // currentQuestion(){
        //     this.selectedAnswerIndex=null;
        //     this.ShuffleAnswers();
        // }
        currentQuestion: {
            immediate: true,
            handler(){
                //Reset variables and shuffle answers
                this.IsAnswered=false;
                this.selectedAnswerIndex=null;
                this.isCorrectAnswer=false;
                this.IsWrongAnswer=false;
                this.ShuffleAnswers();
            }
        }
    }
}
</script>
<style scoped>
    .list-group{
        margin-bottom: 15px;
    }
    .btn{
        margin: 0 0 5 5;
    }
    .list-group-item:hover{
        background:#eee;
        cursor: pointer;
    }
    .selected-answer{
        background:lightskyblue;    
    }
    .correct-answer{
        background: lightgreen;    
    }
    .incorrect-answer{
        background:red;    
    }
    .right-answer{
        background: lightsalmon!important;
    }
</style>