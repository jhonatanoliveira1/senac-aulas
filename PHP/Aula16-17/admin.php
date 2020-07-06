<?php
include("verificar.php");

echo "<h1>PAINEL DE ADMINISTRACAO</h1><br>";
echo "<h1> Olá ".$_SESSION['usuario']." SEJA BEM VINDO AO PAINEL DE ADMINISTRACAO </h1><br>";
?>

<br>

<a href="listacliente.php">Lista de Clientes</a>
<a href="logout.php">Sair do Sistema</a>