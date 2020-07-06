
<?php	

function mensagem()
{
    echo "Olá\n";
    echo "Seja Bem Vindo(a)!";
}
mensagem();


////////////////////////////////////////////////

function mensagem($nome)
{
    echo "Olá\n";
    echo $nome;
}

////////////////////////////////////

    //definição da função
    function mensagem($nome , $sobrenome)
    {
        echo "Olá\n";
        echo $nome.$sobrenome;
    }
     
    //chamando a função
    mensagem("Rodrigo "," Zamara");

//////////////////////////////////// 
    //definição da função
    function dia()
    {
        $hoje = getdate();
        switch($hoje["wday"])
        {
            case 0:
            return "Domingo";
            break;
            case 1:
            return "Segunda-Feira";
            break;
            case 2:
            return "Terça-Feira";
            break;
            case 3:
            return "Quarta-Feira";
            break;
            case 4:
            return "Quinta-Feira";
            break;
            case 5:
            return "Sexta-Feira";
            break;
            case 6:
            return "Sábado";
            break;
        }
    }
    //chamada à fução
    $dia = dia();
    echo $dia;


//////////////////////////////////////

    //definição da função
    function somar($numA, $numB)
    {
        return $numA + $numB;
    }
 
    $resultado = somar(1,2);
    echo $resultado;

///////////////////////////////////////

    function parouimpar($num)
    {
        $resto = $num % 2;
        if($resto == 0)
            return "PAR";
        else
            return "IMPAR";
    }
    //fora da função não é possível acessar a variável $resto 

////////////////////////////////////////
    function depositar($valor)
    {
        static $total_depositos;
        $total_depositos++;
        $saldo += $valor;
        echo "Foram feitos ".$total_depositos." depósitos.";
    }
 
    function sacar($valor)
    {
        static $total_saques;
        $total_saques++;
        $saldo -= $valor;
        echo "Foram feitos ".$total_saques." saques.";
    }

/////////////////////////////////////

    function somar($numA, $numB)
    {
        return $numA + $numB
    }
 
    function somar(&$numA, $numB)
    {
        $numA += $numB;
    }

/////////////////////////////////////

function soma()
    {
        $numeros = func_get_args();
        $qtd_nums = func_num_args();
        $soma = 0;
        for($i = 0; $i < $qtd_nums;$i++)
        {
            $soma += $numeros[$i];
        }
        return $soma;
    }
    //testando a função
    echo somar(1, 2, 3, 4, 5);

/////////////////////////////////////

$link = mysqli_connect('127.0.0.1:3307', 'root', '',);

if (!$link) {
    die('Não foi possível conectar: ' . mysql_error());
}
echo 'Conexão bem sucedida';
	
mysql_close($link);
/*	
?>
