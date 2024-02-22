<?php

if(isset($_POST['btoAlterar']))
{
    include_once('conexao.php');
    try 
    {
        $sql = $conn->prepare('
        update usuario set
            nome_usuario=:nome_usuario,
            login_usuario=:login_usuario,
            senha_usuario=:senha_usuario,
            obs_usuario=:obs_usuario,
            status_usuario=:status_usuario
            where id_usuario=:id_usuario
        ');
        $sql->execute(array(
            ':id_usuario'=>$_POST['txtID'],
            ':nome_usuario'=>$_POST['txtNome'],
            ':login_usuario'=>$_POST['txtLogin'],
            ':senha_usuario'=>$_POST['txtSenha'],
            ':obs_usuario'=>$_POST['txtObs'],
            ':status_usuario'=>$_POST['txtStatus']
        ));
        if($sql->rowCount() > 0)
        {
            $mensagem = '<p>Dados alterados com sucesso</p>';
        }
    } 
    catch (PDOException $erro) {
        echo $erro->getMessage();
    }
}



?>