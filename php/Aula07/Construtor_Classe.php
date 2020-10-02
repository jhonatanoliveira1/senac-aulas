<?php
class Cliente{
    public $nome;
    public $cpf;
    public $endereco;
    //construtor da classe
    function Cliente(){
        $this->preparaCliente();
    }
 
    function preparaCliente(){
        $this->nome = "Joao Marinho";
        $this->cpf = "99999999999";
        $this->endereco = "Rua Sergipe, 454 apto 14";
    }
 
} ?>