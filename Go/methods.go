package main

import "fmt"

const usesixteenbitmax float64 = 65535;
const kmh_multiple float64 = 1.60934

//Struct
type car struct{
	gas_pedal uint16;
	brake_pedal uint16;
	steering_wheel int16;
	top_speed_kph float64;
}

//Metod
func (c car) kmperhour() float64{
	return  float64(c.gas_pedal) * c.top_speed_kph/usesixteenbitmax;
}

//Pointer receiver
func (c *car) new_top_speed(newSpeed float64){
	c.top_speed_kph=newSpeed;
}


func main(){
	var acar = car{
		gas_pedal:123,
		brake_pedal:456,
		steering_wheel:789,
		top_speed_kph:1000,
	}
	fmt.Println(acar.top_speed_kph);
	acar.new_top_speed(600);
	fmt.Println(acar.top_speed_kph);

	//fmt.Println(acar.kmperhour());
}