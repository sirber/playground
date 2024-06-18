<?php declare(strict_types=1);

#[\Attribute]
class Auth
{
	public function __construct(private string $role)
	{ }

	public function getRole(): string
    {
        return $this->role;
    }
}

class Controller
{
	public function index()
	{
		echo "index\n";
	}

	#[Auth("user")]
	public function list() 
	{
		echo "list\n";
	}
}

function executeMethodWithAuth(object $controller, string $methodName, string $userRole)
{
    $reflection = new ReflectionObject($controller);

    if (!$reflection->hasMethod($methodName)) {
        throw new Exception("Method $methodName does not exist in " . get_class($controller));
    }

    $reflectionMethod = $reflection->getMethod($methodName);
    $attributes = $reflectionMethod->getAttributes(Auth::class);

    if (!empty($attributes)) {
        $authAttribute = $attributes[0]->newInstance();
        $requiredRole = $authAttribute->getRole();

        if ($userRole !== $requiredRole) {
            die("Unauthorized: Requires role $requiredRole");
        }
    }

    // If authorized or no Auth attribute, invoke the method
    $reflectionMethod->invoke($controller);
}

// Example usage
$controller = new Controller();
$currentUserRole = "admin";

// Execute methods with authentication check
executeMethodWithAuth($controller, 'index', $currentUserRole); // Should always pass as there's no Auth attribute
echo PHP_EOL;

executeMethodWithAuth($controller, 'list', $currentUserRole); // Will check for the Auth attribute
echo PHP_EOL;