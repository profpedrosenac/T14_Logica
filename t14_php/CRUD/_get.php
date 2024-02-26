<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php

    if($_GET)
    {
        echo $_GET['ID'];
        echo "<br>";
        echo $_GET['Nome'];
    }
    ?>

    <select name="txtUsuario" id="txtUsuario">
        <?php
            include_once('conexao.php');
            $sql = $conn->query('select id_usuario, nome_usuario from usuario');

            try {
                foreach ($sql as $linha) {
                    echo "<option value='$linha[0]'>$linha[1]</option>";
                }
            } catch (PDOException $erro) {
                echo $erro->getMessage();
            }
        ?>
    </select>
</body>
</html>