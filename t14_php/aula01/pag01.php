<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/estilo.css">
</head>
<body>

    <h1>Primeira pagina PHP</h1>
    <hr>

    <?php 

        date_default_timezone_set('America/Sao_Paulo');

        $nome = "Pedro";
        $sobrenome = "Holuboski";
        $idade = 38;

        // var_dump($nome);
        // var_dump($idade);

        echo "<h2>Olá Mundo!</h2>";
        echo "<p>Olá Mundo!</p>";
        echo "<hr>";
        echo date("d/m/Y");
        echo "<br>";
        echo date("H:i:s");
        echo "<hr>";
        echo "Seu nome completo é <b>".$nome." ".$sobrenome."</b> e sua idade é <i>".$idade." anos.</i>";
    ?>
        
    <script src="js/bootstrap.js"></script>
    </body>
</html>