<?php 
include("conecta.php"); 

$usuario=$_POST['username'];
$senha=$_POST['usersenha'];

//echo $usuario."<br>".$senha;

$query="INSERT INTO usuarios values ('','$usuario',md5('$senha'))";

mysqli_query ($conexao,$query) or die ("Erro de banco de dados");

echo "<script>alert('Usuário Cadastrado com Sucesso');location.href=\"index.html\";</script>";

mysqli_close($conexao);

?>