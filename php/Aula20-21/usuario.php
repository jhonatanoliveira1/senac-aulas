<?php

//inlcuindo a classe
include_once "class/usuario.class.php";

//criando um objeto dessa classe um produto
$usuario = new Usuarios;

//Atribuindo valores nessa objeto
$usuario->Nome = "Rodrigo Zamara";
$usuario->Endereco = "Rua Campo Sales";
$usuario->Numero = 14;

//Apresentando na Tela
echo "Bem vindo " .$usuario->Nome. ". Voce Mora na ". $usuario->Endereco." No. ".$usuario->Numero;

?>