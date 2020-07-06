<?php
include('conecta.php');

$usuario=$_POST["login"];
$senha=$_POST["senha"];

$query="SELECT * FROM usuarios WHERE NOME_USER='$usuario' AND SENHA_USER=md5('$senha')";

$result=mysqli_query($conexao,$query);

$row=mysqli_num_rows($result);

if($row == 1){

    header('location: admin.php');
    exit();
}else{
    echo"<script>alert('Usuário não Existente');location.href=\"index.html\";</script>";
    exit();
}
?>

