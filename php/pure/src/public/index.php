<?php

require_once __DIR__ . '/../private/bootstrap.php';

$request = $_SERVER["REQUEST_URI"];
switch ($request) {
  case '/':
    phpinfo();
    break;

  case '/users':
    echo "users";
    break;

  default:
    header("HTTP/1.0 404 Not Found");
    echo "not found!";
    break;
}
