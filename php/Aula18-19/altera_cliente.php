<?php
include('verificar.php');
include('conecta.php');

$codigo=$_POST['codigo'];
$nome=$_POST['nome'];                                          
$celular=$_POST['celular'];                      
$endereco=$_POST['endereco'];
$numero=$_POST['numero'];                     
$complemento=$_POST['complemento'];
$bairro=$_POST['bairro'];                     
$cidade=$_POST['cidade'];                     
$estado=$_POST['estado'];    

// echo $codigo."</br>".$nome."</br>".$celular."</br>".$endereco."</br>".$numero."</br>".$complemento."</br>".$bairro."</br>".$cidade."</br>".$estado;

$query="UPDATE cad_cliente SET  Nome='$nome',
                                Celular='$celular', 
                                Logradouro='$endereco', 
                                Numero=$numero, 
                                Complemento ='$complemento', 
                                Bairro='$bairro',
                                Cidade='$cidade', 
                                Estado='$estado'
                           WHERE id_cliente=$codigo";


mysqli_query($conexao,$query) or die ("Erro ao alterar no banco de dados");

echo"<script>alert('Alteração das informações do Cliente Concluidas');location.href=\"admin.php\";</script>";

?>