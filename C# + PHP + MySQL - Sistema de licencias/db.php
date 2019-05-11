<?php
	session_start();
	if (!isset($_SESSION['dentro']) || !$_SESSION['dentro'])
		header("Location: index.php");

	// MySql
	mysql_connect("localhost", "root", "") or die ("No se puede conectar");
	mysql_select_db("tutoriales") or die ("No se puede conectar");

	// POST
	if (isset($_POST['btninsertar'])) {
		$serial = $_POST['serial'];
		$activado = $_POST['activado'];
		mysql_query("INSERT INTO licencia VALUES('$serial', '$activado')") or die ("No se ha podido insertar");

	}
	if (isset($_POST['btnactualizar'])) {
		$serial = $_POST['serial2'];
		$activado = $_POST['activado2'];
		mysql_query("UPDATE licencia SET activado='$activado' WHERE `serial`='$serial'") or die ("No se ha podido insertar");
	}
?>
<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Base de datos</title>
</head>
<body>
	<form method="post">
		<input type="text" name="serial" id="serial">
		<input type="text" name="activado" id="activado">
		<input type="submit" name="btninsertar" id="btninsertar" value="Insertar">
	</form>
	<form method="post">
		<input type="text" name="serial2" id="serial2">
		<input type="text" name="activado2" id="activado2">
		<input type="submit" name="btnactualizar" id="btnactualizar" value="Actualizar">
	</form>
	<table><tbody>
		<?php
			$query = mysql_query("SELECT * FROM licencia");
			while ($fila = mysql_fetch_array($query)) {
		?>
		<tr>
			<td><?php echo $fila[0]; ?></td>
			<td><?php echo $fila[1]; ?></td>
		</tr>
		<?php } ?>
	</tbody></table>
</body>
</html>