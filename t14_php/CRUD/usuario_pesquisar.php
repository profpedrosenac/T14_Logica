<?php

$ID="";
$Nome="";
$Login="";
$Senha="";
$Data="";
$Obs="";
$Status="";


if(isset($_POST['btoPesquisar']))
{

    include_once('conexao.php');

    try
    {
        $sql = $conn->query('select * from usuario where id_usuario='.$_POST['txtID']);

        if($sql->rowCount()>0)
        {
            foreach($sql as $linha)
            {
                $ID=$linha[0];
                $Nome=$linha[1];
                $Login=$linha[2];
                $Senha= $linha[3];
                $Data=$linha[4];
                $Data = substr($Data, 0, 10);
                $Obs=$linha[5];
                $Status=$linha[6];
            }
        }else{
            echo '<script>alert("Usuário não encontrado")</script>';
            $mensagem = "Usuário não encontado";
        }
        
    }
    catch(PDOException $erro)
    {
        echo $erro->getMessage();
    }   
}
?>