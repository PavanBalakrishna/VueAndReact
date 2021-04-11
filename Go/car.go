package main;

import "fmt";



type car struct{

		gas_pedal uint16;
		steering_wheel int16;
		top_speed float64;
}


func main(){

	var mynumber int16=45;
	b_car := car{gas_pedal:444, steering_wheel:555, top_speed:666};
	a_car := car{123,456,789};
	fmt.Println(a_car.gas_pedal);
	fmt.Println(b_car.gas_pedal);
	fmt.Println(mynumber);

}