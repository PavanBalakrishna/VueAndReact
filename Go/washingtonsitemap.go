package main

import ("fmt"
"net/http"
"io/ioutil"
"encoding/xml"
"strings"
)


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
	KeyWords string
	Location string 
}


func ReadURLBytes(url string) []byte{
	res, _ := http.Get(strings.Trim(url,"\t \n"));

	resultbytes , _ := ioutil.ReadAll(res.Body);

	res.Body.Close();
	return resultbytes;
}



func main(){

	var resultBytes = ReadURLBytes("https://www.washingtonpost.com/news-sitemaps/index.xml");
	var newsMaps = make(map[int]NewsMap)
	var s Sitemapindex
	xml.Unmarshal(resultBytes, &s)
	
	for _, iloca := range s.Locations{

		
			
			var iresultBytes = ReadURLBytes(iloca);
	
			var n News
			xml.Unmarshal(iresultBytes, &n)
	
			for index, _ := range n.Titles{
				newsMaps[index] = NewsMap{n.Titles[index], n.Titles[index]};
			}
		
	
	}

	for k, v := range newsMaps{
		fmt.Println(k ," - ", v)
	}

	
}