package main

import ("fmt")



func main(){
	grades := make(map[string]int);

	grades["Pavan"]=85;
	grades["Kruthika"]=96;
	grades["Puneeth"]=82;


	delete(grades,"Pavan");

	for k, v := range(grades){
		fmt.Println(k, ":", v)
	}
}