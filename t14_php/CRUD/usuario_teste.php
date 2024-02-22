<?php

include_once('conexao.php');

try
{
    $sql = $conn->query('select * from usuario');

    foreach($sql as $linha)
    {
        echo '<pre>';
            print_r($linha);
        echo '<pre>';
        echo 'Nome: '.$linha['nome_usuario'].'<br>';
        echo 'Nome: '.$linha[1].'<br>';
    }
}
catch(PDOException $erro)
{
    echo $erro->getMessage();
}

?>