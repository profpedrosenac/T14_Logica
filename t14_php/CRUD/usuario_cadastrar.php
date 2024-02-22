<?php

if(isset($_POST['btoCadastrar']))
{
    include_once('conexao.php');

    try 
    {
        $sql = $conn->prepare('
        insert into usuario
            (nome_usuario,login_usuario,senha_usuario,obs_usuario)
            values(:nome_usuario,:login_usuario,:senha_usuario,:obs_usuario)
        ');

        $sql->execute(array(
            ':nome_usuario'=>$_POST['txtNome'],
            ':login_usuario'=>$_POST['txtLogin'],
            ':senha_usuario'=>$_POST['txtSenha'],
            ':obs_usuario'=>$_POST['txtObs']
        ));

        if($sql->rowCount() > 0)
        {
            $mensagem = '<p>Cadastro realizado com sucesso</p> - '.$sql->rowCount();
            $mensagem = $mensagem.'<p>ID Gerado:'.$conn->lastInsertId().'</p>';
        }
    } 
    catch (PDOException $erro) {
        echo $erro->getMessage();
    }
}



?>