<?php

    define('HOST', 'localhost');
    define('USUARIO', 'root');
    define('SENHA','');
    define('DB', 'sistemaweb');

    /*
    $HOST='localhost';
    $USUARIO='root';
    $SENHA='';
    $DB='sistemaweb';
    */

    $conexao = mysqli_connect(HOST,USUARIO,SENHA,DB);
    //if (!$conexao) {
    //    die('Não pode conectar:' . mysql_error());
    //}

    //mysqli_close($conexao);

?>