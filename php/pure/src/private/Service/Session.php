<?php

namespace App\Service;

class Session
{
  public static function get(string $key)
  {
    return $_SESSION[$key];
  }

  public static function set(string $key, $value)
  {
    $_SESSION[$key] = $value;
  }
}
