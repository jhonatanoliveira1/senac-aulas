<?php
include('verificar.php');


$codigo=$_GET['codigo'];
$nome=$_GET['nome'];                                          
$celular=$_GET['celular'];                      
$endereco=$_GET['endereco'];
$numero=$_GET['numero'];                     
$complemento=$_GET['complemento'];
$bairro=$_GET['bairro'];                     
$cidade=$_GET['cidade'];                     
$estado=$_GET['estado'];      

?>

<form nome="Form1" method="post" action="altera_cliente.php">

    <input type="hidden" name="codigo" id="codigo" value="<?php echo $codigo;?>">
    <label for="textfield">Nome:</label>
        <input type="text" name="nome" id="nome" value="<?php echo $nome;?>"><br>
    <label for="textfield">Celular:</label>
        <input type="text" name="celular" id="celular" value="<?php echo $celular;?>"><br>
    <label for="textfield">Endereço</label>
        <input type="text" name="endereco" id="endereco" value="<?php echo $endereco;?>"><br>
    <label for="textfield">Numero</label>
        <input type="text" name="numero" id="numero" value="<?php echo $numero;?>"><br>
    <label for="textfield">Complemento</label>
        <input type="text" name="complemento" id="complemento" value="<?php echo $complemento;?>"><br>
    <label for="textfield">Bairro</label>
        <input type="text" name="bairro" id="bairro" value="<?php echo $bairro;?>"><br>
    <label for="textfield">Cidade</label>
        <input type="text" name="cidade" id="cidade" value="<?php echo $cidade;?>"><br>
    <label for="textfield">Estado</label>
        <input type="text" name="estado" id="estado" value="<?php echo $estado;?>"><br>
    <input type="submit" id="alterar" value="Alterar">

</form>
