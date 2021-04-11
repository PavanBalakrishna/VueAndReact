package main

import ("fmt"
		"math"
		"math/rand")
		
		
	func add(x float64, y float64) float64{
	
		return x+y;
	
	}
	
	
	func Multiple(x string, y string)(string, string){
		return x,y;
	
	}

	func main(){

		fmt.Println("Welcome to go");
		fmt.Println(math.Sqrt(10 + 6));
		fmt.Println("Random number ", rand.Intn(12));
		
		
		fmt.Println(add(6.453,3.111));
		
		nameone, nametwo := "Pavan", "Kuku";
		
		
		fmt.Println(Multiple(nameone,nametwo));

	}