<?php declare(strict_types=1);
use PHPUnit\Framework\TestCase;
use App\CountRepetition;

final class CountRepetitionTest extends TestCase
{
  public function test1(): void 
  {
    // Arrange
    $test = [1, 2, 2, 3, 3, 3];

    // Act
    $result = CountRepetition::countRepetition($test);

    // Assert
    $this->assertSame($result, 3);
  }
  
  public function test2(): void 
  {
    // Arrange
    $test = [1, 1, 2, 2, 3, 3];

    // Act
    $result = CountRepetition::countRepetition($test);

    // Assert
    $this->assertSame($result, 3);
  }
  
  public function test3(): void 
  {
    // Arrange
    $test = [1, 2, 1, 2, 1, 2];

    // Act
    $result = CountRepetition::countRepetition($test);

    // Assert
    $this->assertSame($result, 4);
  }
}