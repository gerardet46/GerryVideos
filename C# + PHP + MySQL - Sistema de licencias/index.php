<?php
	session_start();
	if (isset($_POST['codigo']) && $_POST['codigo'] == 'gerry') {
		$_SESSION['dentro'] = true;
		header("Location: db.php");
	}
?>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Login</title>
</head>
<body>
	<form method="post">
		<input type="text" name="codigo" id="codigo">
		<input type="submit" name="entrar" id="entrar" value="Iniciar sesión">
	</form>
</body>
</html>