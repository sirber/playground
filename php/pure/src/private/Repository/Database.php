<?php

namespace App\Repository;

abstract class Database
{
  private $db;

  public function __construct()
  {
    $this->db = new \PDO($_ENV['PDO_DB_STRING'], $_ENV['PDO_DB_USER'], $_ENV['PDO_DB_PASS']);
  }

  public function query(string $query)
  {
    return $this->db->query($query);
  }
}
