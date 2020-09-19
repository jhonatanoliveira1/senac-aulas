<?php

class Filmes
{
    public $publica = 'Livre';
    protected $protegida = '+18';
    private $privada = '+16';

    function imprimeFilmes()
    {
        echo $this->publica;
        echo $this->protegida;
        echo $this->privada;
    }
}

$obj = new Filmes();
echo $obj->publica; 
echo $obj->protegida; 
echo $obj->privada; 
$obj->imprimeFilmes();

?>