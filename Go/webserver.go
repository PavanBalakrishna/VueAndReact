package main

import ("fmt"
	    "net/http")
			
	
	func default_Handler(w http.ResponseWriter, r *http.Request){
	
		fmt.Fprintf(w, "Hello from go webserver");
	}
	
	func main(){
	
		http.HandleFunc("/",default_Handler);
		http.ListenAndServe(":8099",nil);
	
	}