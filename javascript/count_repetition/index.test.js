const { countRepetition } = require('./index')

describe('countRepetition', () => {
  it('should pass test 1', () => {
    // Arrange
    const test = [1, 2, 2, 3, 3, 3]

    // Act
    const result = countRepetition(test)

    // Assert
    expect(result).toBe(3)
  })
  
  it('should pass test 2', () => {
    // Arrange
    const test = [1, 1, 2, 2, 3, 3]

    // Act
    const result = countRepetition(test)

    // Assert
    expect(result).toBe(3)
  })

  it('should pass test 3', () => {
    // Arrange
    const test = [1, 2, 1, 2, 1, 2]

    // Act
    const result = countRepetition(test)

    // Assert
    expect(result).toBe(4)
  })
})