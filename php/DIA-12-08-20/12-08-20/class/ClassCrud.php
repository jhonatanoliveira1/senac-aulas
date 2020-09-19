<?php

class ClassCrud extends ClassConexao{

    #Atributos
    private $Crud;
    private $Contador;


#declarações

    private function preparedStatements($Query , $Parametros)
    {
        $this->countParametros($Parametros);
        $this->Crud=$this->conectaDB()->prepare($Query);

        if($this->Contador > 0){     
            for($i=1; $i <= $this->Contador; $i++){
                $this->Crud->bindValue($i,$Parametros[$i-1]);
            }
        }

        $this->Crud->execute();
    }

    #Contator de parametros
    private function contParametros($Parametros)
    {
        $this->Contador=count($Parametros);
    }
}