<?php
    include("verificar.php");
    include("conecta.php");

    $query="SELECT * FROM cad_cliente";

    $result=mysqli_query($conexao, $query) or die ("Erro de Banco de Dados");
?>

<!doctype html>
<html>
    <head>
        <meta charset="uft-8">
        <title><br>Lista de Cliente<br></title> 
    </head>

    <body>
        <table border=1>
            <tr>
                <td>Código</td>
                <td>Nome</td>
                <td>Celular</td>
                <td>Endereço</td>
                <td>Numero</td>
                <td>Complemento</td>
                <td>Bairro</td>
                <td>Cidade</td>
                <td>Estado</td>
            </tr>

            <?php while($dado = $result->fetch_array()) { ?>
                <tr>
                    <td><?php echo $dado['id_cliente'];?></td>
                    <td><?php echo $dado['Nome'];?></td>
                    <td><?php echo $dado['Celular'];?></td>
                    <td><?php echo $dado['Logradouro'];?></td>
                    <td><?php echo $dado['Numero'];?></td>
                    <td><?php echo $dado['Complemento'];?></td>
                    <td><?php echo $dado['Bairro'];?></td>
                    <td><?php echo $dado['Cidade'];?></td>
                    <td><?php echo $dado['Estado'];?></td>
                </tr>
                <a href="admin.php">Voltar</a>
            <?php } ?>
        </table>
    </body>

</html>