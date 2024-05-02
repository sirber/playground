<?php

namespace App;

class CountRepetition
{
  public static function countRepetition(Array $source): int 
  {
    $map = [];
  
    foreach($source as $number) {
      $repetition = $map[$number]; 
      if (isset($repetition)) {
        $map[$number] = $repetition + 1;
      } else {
        $map[$number] = 0;
      }
    }
  
    $count = 0;
    foreach($map as $repetition) {
      $count += $repetition;
    }
  
    return $count;
  }
}
