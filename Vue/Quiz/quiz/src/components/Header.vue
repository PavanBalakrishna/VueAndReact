<template>
    <div>
        <b-nav>
            <b-nav-item disabled ><b>Fancy Quiz App</b></b-nav-item>
            <b-nav-item  disabled >Couter:{{correctAnswerCount}}/{{totalAnswerCount}}</b-nav-item>
        </b-nav>
    </div>
</template>


<script>
export default {
    props:{
        correctAnswerCount:Number,
        totalAnswerCount:Number
    }
}
</script>