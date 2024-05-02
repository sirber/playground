package main

import (
	"testing"

	"github.com/stretchr/testify/assert"
)

func TestCountRepetition(t *testing.T) {
	t.Run("test1", func(t *testing.T) {
		// Arrange
		test := []int{1, 2, 2, 3, 3, 3}

		// Act
		result := countRepetition(test)

		// Assert
		assert.Equal(t, 3, result)
	})

	t.Run("test2", func(t *testing.T) {
		// Arrange

		// Act

		// Assert
	})

	t.Run("test3", func(t *testing.T) {
		// Arrange

		// Act

		// Assert
	})
}
