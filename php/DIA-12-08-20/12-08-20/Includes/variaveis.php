<?php
if(isset($_POST['Id'])){
    $Id=filter_input(INPUT_POST,'Id',FILTER_SANITIZE_SPECIAL_CHARS);
}elseif(isset($_GET['Id'])){
    $Id=filter_input(INPUT_GET,'Id',FILTER_SANITIZE_SPECIAL_CHARS);
}else{
    $Id=0;
}

if(isset($_POST['User'])){
    $Nome=filter_input(INPUT_POST,'User',FILTER_SANITIZE_SPECIAL_CHARS);
}elseif(isset($_GET['User'])){
    $Nome=filter_input(INPUT_GET,'User',FILTER_SANITIZE_SPECIAL_CHARS);
}else{
    $Nome="";
}
if(isset($_POST['Senha'])){
    $Senha=filter_input(INPUT_POST,'Senha',FILTER_SANITIZE_EMAIL);
}elseif(isset($_GET['Senha'])){
    $Senha=filter_input(INPUT_GET,'Senha',FILTER_SANITIZE_EMAIL);
}else{
    $Senha="";
}
if(isset($_POST['Email'])){
    $Email=filter_input(INPUT_POST,'Email',FILTER_SANITIZE_SPECIAL_CHARS);
}elseif(isset($_GET['Email'])){
    $Email=filter_input(INPUT_GET,'Email',FILTER_SANITIZE_SPECIAL_CHARS);
}else{
    $Email="";
}