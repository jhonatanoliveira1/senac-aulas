<?php

abstract class ClassConexao{ //Abstract pode ser extendida mas não pode ser estanciada 	

	//Conexao com o banco de dados
protected function conectaDB()
	{
		try{<!--  -->
			$con=new PDO("mysql:host=localhost;dbname=liftyou","root","");
			return $con;
	 	} catch (PDOException $Erro){
	 		return $Erro->getMessage();
	}
}
}       v         