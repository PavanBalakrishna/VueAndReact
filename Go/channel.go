package main

import "fmt"


func goroutine(c chan int, someval int){
	c <- someval *20
}

func main (){
	chanval := make(chan int)

	go goroutine(chanval, 10)
	go goroutine(chanval, 5)

	result1, result2:= <- chanval, <- chanval

	fmt.Println(result1, result2)
}