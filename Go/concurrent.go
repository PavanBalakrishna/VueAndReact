package main

import (
	"fmt"
	"sync"
)

func main(){

	var wg  sync.WaitGroup

	p1 := Person{Name:"Pavan", Age: 31, Email: "Pavan.Balakrishna@gmail.com"}
	p2 := Person{Name:"Pavan2", Age: 31, Email: "Pavan.Balakrishna@gmail.com"}

	for i:=0; i< 40 ; i++{
		wg.Add(1)
		go p1.PrintName(&wg);
		wg.Add(1)
		go p2.PrintName(&wg);

		
	}

	wg.Wait();
}

func (p Person) PrintName(wg *sync.WaitGroup) {
	fmt.Println(p.Name)

	defer wg.Done();
	
	
}


type Person struct{
	Name string
	Age int16
	Email string
}