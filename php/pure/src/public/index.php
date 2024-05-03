<?php

require_once __DIR__ . '/../private/bootstrap.php';

$request = $_SERVER["REQUEST_URI"];
switch ($request) {
  case '/users':
    echo "users";
    break;

  default:
    phpinfo();
    break;
}
