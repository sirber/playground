<?php

namespace App\Controller;

use App\Repository\UserRepository;

class UserController
{
  private $userRepository;

  public function __construct()
  {
    $this->userRepository = new UserRepository();
  }

  function getUsers()
  {
    return json_encode($this->userRepository->getUsers());
  }
}
