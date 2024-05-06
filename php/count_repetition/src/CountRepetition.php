<?php

namespace App;

class CountRepetition
{
  public static function countRepetition(array $source): int
  {
    $map = array();

    foreach ($source as $number) {
      if (isset($map[$number])) {
        $map[$number] = $map[$number] + 1;
      } else {
        $map[$number] = 0;
      }
    }

    return array_sum($map);
  }
}
