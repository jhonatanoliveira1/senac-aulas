<?php
include('verificar.php');
include('conecta.php');

$codigo=$_GET['codigo'];

$query="DELETE FROM cad_cliente WHERE id_cliente=$codigo";

mysqli_query($conexao, $query) or die ("Falha ao conectar no banco de dados");

echo"<script>alert('Alteração das informações do Cliente Concluidas');location.href=\"listacliente.html\";</script>";

?>