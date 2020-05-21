<?php
session_start();
include('conecta.php');

if(empty($_POST['login']) || empty($_POST['senha'])) {
    header('location:index.html');
    exit();
}

$usuario=mysqli_real_escape_string($conexao, $_POST['login']);
$senha=mysqli_real_escape_string($conexao,md5($_POST['senha']));

$query="SELECT * FROM usuarios WHERE NOME_USER='$usuario' AND SENHA_USER='$senha'";

$result=mysqli_query($conexao,$query);

$row=mysqli_num_rows($result);

if($row == 1){
    $_SESSION['usuario']= $usuario;
    $_SESSION['senha'] = $senha;

    header('location: admin.php');
    exit();
}else{
    echo"<script>alert('Usuário ou senha não confere');location.href=\"index.html\";</script>";
    exit();
}
?>

