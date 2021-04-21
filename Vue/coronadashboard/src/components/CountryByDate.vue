<template>
<div v-if="showData">
  <router-link to='/' >Home</router-link>
<div v-if="loadData" >
  
  <h1>{{countryName}}</h1>
<highcharts :options="chartOptions" :constructor-type="'chart'"></highcharts>
<h3>Show Line Chart</h3>
<input type="checkbox" value="line chart" v-model="showLineChart" @change="checkChart()" />
        
<br/>
<h3>Type of chart</h3>
        <label for="Infected">Infected</label>
        <input type="radio" value="Infected" checked v-model="chartDataType" @change="checkChartData()" />
        <br>
        <label for="Death">Death</label>
        <input type="radio" value="Death" v-model="chartDataType" @change="checkChartData()" />
        <br>
        <label for="Recovered">Recovered</label>
        <input type="radio" value="Recovered" v-model="chartDataType" @change="checkChartData()" />
        

 <b-table striped hover :items="countryData" :fields="fields"></b-table>
</div>
<div v-else >
  <h1>Please wait 3 seconds or there is an error getting data go home</h1>
</div>

<div v-if="erroMessage">Error getting data go home</div>
</div>
</template>

<script>


export default {
    name:'CountryByDate',

    

    data:function(){
      return {
          countryData:{},
          countryName:'',
          loadData:false,
          showLineChart:false,
          erroMessage:false,
          showData:false,
          chartDataType:'Infected',
          chartOptions: {
              
                  //   series: [{
                  //   data: [0,0,0]
                  // }]
                },
          fields: ['Date', 'Confirmed', 'Deaths','Recovered','DailyConfirmed','DailyDeaths','DailyRecovered'],

      }
    },
    mounted:function(){
        var searchCountry=this.$route.params.coronaCountry;
        fetch('https://api.covid19api.com/countries',{

        }).then((response)=>{
          
          return response.json();
        })
        .then((countryList)=>{
           
          var selectedCountry = countryList.filter(c=>c.Country.toLowerCase()==searchCountry.toLowerCase());

          if(selectedCountry != null){
                fetch('https://api.covid19api.com/country/'+selectedCountry[0].Slug+'?from=2020-03-01T00:00:00Z',{
                  method:'get'
                }).then((response)=>{
                  
                  return response.json();
                })
                
                .then((countryAPIData)=>{
                  countryAPIData.sort((dateA, dateB) => (dateA.Date < dateB.Date) ? 1 : -1)
                  
                for(var m=0;m<countryAPIData.length;m++){
                   if(countryAPIData[m+1] != null){
                      countryAPIData[m].DailyConfirmed =countryAPIData[m].Confirmed-countryAPIData[m+1].Confirmed;
                      countryAPIData[m].DailyDeaths =countryAPIData[m].Deaths-countryAPIData[m+1].Deaths;
                      countryAPIData[m].DailyRecovered =countryAPIData[m].Recovered-countryAPIData[m+1].Recovered;
                    }
                }

                this.countryData=countryAPIData;


                
                this.countryName=countryAPIData[0].Country;

                var chrtData =[];

             

                for(var i=0;i<this.countryData.length - 1;i++){
                    
                      var dailycount=this.countryData[i].DailyConfirmed;// - this.countryData[i+1].Confirmed 
                      chrtData.push(
                          dailycount
                        )
                      
                }

                chrtData.reverse();
                this.chartOptions={
                   title: {
                      text: 'Day counts'
                    },
                    chart: {
                        type: (!this.showLineChart?'column':'line')
                    },
                    xAxis: {
                          title: {
                              text: 'Day Number'
                          }
                    },
                    yAxis: {
                          title: {
                              text: 'Number of Infected'
                          },
                          min:0
                    },
                    series: [{
                    data: chrtData,
                    color:'Red'
                  }]
                }
                this.loadData=true;
                
                })
               this.showData=true;
          }

           

        })

        

        
      },
      methods:{
          DailyCount:function(index){
            if(this.countryData[index+1] != null){
              return this.countryData[index].Confirmed - this.countryData[index+1].Confirmed 
            }else{
              return 0;
            }
          },
          checkChart:function(){
            this.chartOptions.chart.type=(!this.showLineChart?'column':'line')
          },
          checkChartData:function(){
            var chrtData =[];
            var color='';
            var chartTypeText='';
            if(this.chartDataType == 'Infected'){
                for(var i=0;i<this.countryData.length - 1;i++){
                    
                      let dailycount=this.countryData[i].DailyConfirmed;
                      chrtData.push(
                          dailycount
                        )
                      
                }     
                chartTypeText='Infected Count';     
                color='Red';      
            }else if (this.chartDataType == 'Death'){
                 for(var j=0;j<this.countryData.length - 1;j++){
                    
                      let dailycount=this.countryData[j].DailyDeaths;
                      chrtData.push(
                          dailycount
                        )
                      
                }     
                chartTypeText='Death Count';
                color='Grey';
            }
            else if (this.chartDataType == 'Recovered'){
                 for(var k=0;k<this.countryData.length - 1;k++){
                    
                      let dailycount=this.countryData[k].DailyRecovered;
                      chrtData.push(
                          dailycount
                        )
                    
                }   
                chartTypeText='Recovered Count';  
                color='Green';
            }
            chrtData.reverse();

            this.chartOptions.yAxis.title.text=chartTypeText;
            this.chartOptions.series[0].data=chrtData;
            this.chartOptions.series[0].color=color;
          },
      }
}
</script>

<style>
  .hide{
    display:none;
  }
</style>  