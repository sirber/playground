<?php

require_once __DIR__ . '/../private/bootstrap.php';

$request = $_SERVER["REQUEST_URI"];
$parts = explode('/', $request);
$endpoint = $parts[1];
$id = isset($parts[2]) ? $parts[2] : null;

switch ('/' . $endpoint) {
  case '/':
    phpinfo();
    break;

  case '/users':
    if ($id) {
      echo "users id: " . $id;
    } else {
      echo "users";
    }

    break;

  default:
    header("HTTP/1.0 404 Not Found");
    echo "not found!";
    break;
}
