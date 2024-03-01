<?php

if(isset($_POST['btoCadastrar']))
{

    include_once('conexao.php');

    $arquivo = $_FILES['txtImg'];

    try 
    {
        $sql = $conn->prepare('
        insert into usuario
            (nome_usuario,login_usuario,senha_usuario,obs_usuario,img_usuario)
            values(:nome_usuario,:login_usuario,:senha_usuario,:obs_usuario,:img_usuario)
        ');

        $sql->execute(array(
            ':nome_usuario'=>$_POST['txtNome'],
            ':login_usuario'=>$_POST['txtLogin'],
            ':senha_usuario'=>$_POST['txtSenha'],
            ':obs_usuario'=>$_POST['txtObs'],
            ':img_usuario'=>$arquivo['name']
        ));


        if($sql->rowCount() > 0)
        {
            $mensagem = '<p>Cadastro realizado com sucesso</p> - '.$sql->rowCount();
            $mensagem = $mensagem.'<p>ID Gerado:'.$conn->lastInsertId().'</p>';

            $pasta = 'imagens/'.$conn->lastInsertId().'/';
            
            if(!file_exists($pasta))
            {
                mkdir($pasta);
            }

            $foto = $pasta.$arquivo['name'];

            move_uploaded_file($arquivo['tmp_name'],$foto);

            header("Location:sistema.php?tela=usuario&IDUsuario=".$conn->lastInsertId());
        }
    } 
    catch (PDOException $erro) {
        echo $erro->getMessage();
    }
}


 
?>