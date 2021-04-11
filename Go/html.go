package main

import (
	"fmt"
	"net/http"
	"html/template"
	"io/ioutil"
	"encoding/xml"
	"strings"
)


type NewsAggPage struct{
	Title string
	News map[int]NewsMap
}


type Sitemapindex struct{
	Locations []string `xml:"sitemap>loc"`
}

// type Location struct{
// 	Loc string `xml:"loc"`
// }


// func (l Location) String() string{
// 	return fmt.Sprintf(l.Loc)
// }


type News struct{
	Titles []string `xml:"url>news>title"`
	Keywords []string `xml:"url>news>keywords"`
	Locations []string `xml:"url>loc"`
}

type NewsMap struct{
	Title string
	KeyWords string
	Location string 
}



func ReadURLBytes(url string) []byte{
	res, _ := http.Get(strings.Trim(url,"\t \n"));

	resultbytes , _ := ioutil.ReadAll(res.Body);

	res.Body.Close();
	return resultbytes;
}

func RecurringFunc(iloca string){
	
}


func news_agg_handler(w http.ResponseWriter, r *http.Request){



	var resultBytes = ReadURLBytes("https://www.washingtonpost.com/news-sitemaps/index.xml");
	var newsMaps = make(map[int]NewsMap)
	var s Sitemapindex
	xml.Unmarshal(resultBytes, &s)
	
	for _, iloca := range s.Locations{

		 iresultBytes :=  ReadURLBytes(iloca);
	
		var n News
		xml.Unmarshal(iresultBytes, &n)

		for index, _ := range n.Keywords{
			newsMaps[index] = NewsMap{Title: n.Titles[index], KeyWords: n.Keywords[index],Location : n.Locations[index]};
		}
	}


	var newspage = NewsAggPage{ Title:"My News Title", News:newsMaps};

	t, err := template.ParseFiles("NewsAggPage.html");
	fmt.Println(err)
	fmt.Println(t.Execute(w, newspage))
}

func index_handler(w http.ResponseWriter, r *http.Request){
	fmt.Fprintf(w, `<h1>Header</h1>
					<p>Paragraph</p>`)
}

func main(){
	http.HandleFunc("/", index_handler)
	http.HandleFunc("/agg/", news_agg_handler)
	http.ListenAndServe(":8099",nil)
}