<?php 
include("conecta.php"); 

if(empty($_POST['username']) || empty($_POST['usersenha'])) {
    echo "<script>alert('Usuário e senha não podem estar em branco');location.href=\"cad_user.html\";</script>";
    exit();
}

$usuario=$_POST['username'];
$senha=$_POST['usersenha'];

//echo $usuario."<br>".$senha;

$query="INSERT INTO usuarios values ('','$usuario',md5('$senha'))";

mysqli_query ($conexao,$query) or die ("Erro de banco de dados");

echo "<script>alert('Usuário Cadastrado com Sucesso');location.href=\"index.html\";</script>";

mysqli_close($conexao);

?>