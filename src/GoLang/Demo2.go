package main

import "fmt"

func main() {

	p := 65
	a := 34

	result := p + a
	fmt.Println(result)

	result1 := p % a
	fmt.Println(result1)

	result2 := p != a
	fmt.Println(result2)

	var f, g, h = 2, 4, 8
	fmt.Println(f < g && f > h)
	fmt.Println(f < g || f > h)
}
