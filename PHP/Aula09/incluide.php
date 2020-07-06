<!DOCTYPE html>
<html lang= "pt-br">
    <head>
        <meta charset="UTF-8"/>
        <title>Aula de Include de página externas</title>
    </head>
    <body>
        <?php

        echo "Meu nome é <br>";

        require ("nomecompleto.html");

        echo "<br> Moro em: <br>";

        require ("cidade.html");

        ?>
    </body>

</html>