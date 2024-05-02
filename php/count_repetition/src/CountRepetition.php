<?php

namespace App;

class CountRepetition
{
  public static function countRepetition(Array $source): int 
  {
    $map = array();
  
    foreach($source as $number) {
      if (isset($map[$number])) {
        $map[$number] = $map[$number] + 1;
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
