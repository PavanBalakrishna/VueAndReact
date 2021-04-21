<template>
<div v-if="loadData">
  <h1>Corona Virus Summary</h1>
  <h3>Data updated time : {{summaryData.Date}} UTC</h3>
<highcharts :options="chartOptions" :constructor-type="'chart'"></highcharts>
<h3>Type of chart</h3>
        <label for="Infected">Infected</label>
        <input type="radio" value="Infected" checked v-model="chartDataType" @change="checkChartData()" />
        <br>
        <label for="Death">Death</label>
        <input type="radio" value="Death" v-model="chartDataType" @change="checkChartData()" />
        <br>
        <label for="Recovered">Recovered</label>
        <input type="radio" value="Recovered" v-model="chartDataType" @change="checkChartData()" />
        
  <table>
        <thead>
          <tr>
              <th>
                  Country
              </th>
              <th>
                  Infected
              </th>
              <th>
                  Reovered
              </th>
              <th>
                  Deaths
              </th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="(country, index) in summaryData.Countries " :key="index"
          :class="country.TotalConfirmed > 0 ?'':'hide'">
            <td><router-link :to="'/CountryByDate/'+country.Country">{{country.Country }}</router-link> </td>
            <td>{{country.TotalConfirmed}}</td>
            <td>{{country.TotalRecovered}}</td>
            <td>{{country.TotalDeaths}}</td>
          </tr>
        </tbody>
      </table>
      
</div>
</template>

<script>
export default {
    name:'MainDashBoard',
   
    data:function(){
      return {
        loadData:false,
        summaryData:{},
         chartDataType:'Infected',
         chartOptions: {
              
                  //   series: [{
                  //   data: [0,0,0]
                  // }]
                },
        fields:['TotalConfirmed','TotalRecovered','TotalDeaths']
      }
    },
    methods:{
      checkChartData:function(){
            var countData =[];
            var topCountryNames=[];
            var color='';
            var chartTypeText='';

        if(this.chartDataType == 'Infected'){

          this.summaryData.Countries.sort((countryA, countryB) => (countryA.TotalConfirmed < countryB.TotalConfirmed) ? 1 : -1)
         let mainCountData=this.summaryData.Countries;
          topCountryNames=mainCountData.slice(0,9).map(a => a.Country);
          countData=mainCountData.slice(0,9).map(a => a.TotalConfirmed);
          chartTypeText='Infected Count';     
          color='Red';      
        }else if (this.chartDataType == 'Death'){
          this.summaryData.Countries.sort((countryA, countryB) => (countryA.TotalDeaths < countryB.TotalDeaths) ? 1 : -1)
          let mainCountData=this.summaryData.Countries;
          topCountryNames=mainCountData.slice(0,9).map(a => a.Country);
          countData=mainCountData.slice(0,9).map(a => a.TotalDeaths);
          chartTypeText='Death Count';
          color='Grey';
        }else if (this.chartDataType == 'Recovered'){
          this.summaryData.Countries.sort((countryA, countryB) => (countryA.TotalRecovered < countryB.TotalRecovered) ? 1 : -1)
          let mainCountData=this.summaryData.Countries;
          topCountryNames=mainCountData.slice(0,9).map(a => a.Country);
          countData = mainCountData.slice(0,9).map(a => a.TotalRecovered);
          chartTypeText='Recovered Count';  
          color='Green';
        }

        
            this.chartOptions.yAxis.title.text=chartTypeText;
            this.chartOptions.series[0].data=countData
            this.chartOptions.series[0].color=color;
            this.chartOptions.xAxis.categories=topCountryNames;
      }
    },
    mounted:function(){
        fetch('https://api.covid19api.com/summary',{
          method:'get'
        }).then((response)=>{
          
          return response.json();
        })
        .then((covidSummary)=>{
          covidSummary.Countries.sort((countryA, countryB) => (countryA.TotalConfirmed < countryB.TotalConfirmed) ? 1 : -1)
          this.summaryData=covidSummary;

          
                this.chartOptions={
                    title: {
                      text: 'Top 10 Country counts'
                    },
                     chart: {
                        type: 'column'
                    },
                    xAxis: {
                          title: {
                              text: ''
                          },
                           categories: this.summaryData.Countries.slice(0,9).map(a => a.Country)
                    },
                    yAxis: {
                          title: {
                              text: 'Infected Count'
                          },
                          min:0
                    },
                    series: [{
                    data:  this.summaryData.Countries .slice(0,9).map(a => a.TotalConfirmed),
                    color:'Red'
                  }]
                }
        })

        this.loadData=true;
      },
      filters:{
        //filter only active countries
        activeCountriesFilter:function(coronaCountry){
           return coronaCountry.toUpperCase();
        }
      }
}
</script>

<style>
  .hide{
    display:none;
  }
</style>