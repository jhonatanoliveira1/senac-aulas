<?php
require_once 'Class_Cliente.php';
 
$Cliente = new Cliente();
 
echo $Cliente->nome;
echo "<br>";
echo $Cliente->cpf;
echo "<br>";
echo $Cliente->endereco;
?>