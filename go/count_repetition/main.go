package main

import "fmt"

func main() {
	fmt.Println("please run the tests")
}

func countRepetition(source []int) int {
	var (
		repetitions = map[int]int{}
		count       = 0
	)

	for i := 0; i < len(source); i++ {
		number := source[i]

		if value, exists := repetitions[number]; exists {
			repetitions[number] = value + 1
		} else {
			repetitions[number] = 0
		}
	}

	for _, value := range repetitions {
		count = count + value
	}

	return count
}
