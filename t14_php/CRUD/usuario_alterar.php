<?php
if($_POST)
{
if($_POST['txtAcao']=='Alterar')
{
    include_once('conexao.php');

    if($_FILES['txtImg']['name']!="")
    {
        $arquivo = $_FILES['txtImg'];

        try 
        {
            $sql = $conn->prepare('
            update usuario set
                nome_usuario=:nome_usuario,
                login_usuario=:login_usuario,
                senha_usuario=:senha_usuario,
                obs_usuario=:obs_usuario,
                status_usuario=:status_usuario,
                img_usuario=:img_usuario
                where id_usuario=:id_usuario
            ');
            $sql->execute(array(
                ':id_usuario'=>$_POST['txtID'],
                ':nome_usuario'=>$_POST['txtNome'],
                ':login_usuario'=>$_POST['txtLogin'],
                ':senha_usuario'=>$_POST['txtSenha'],
                ':obs_usuario'=>$_POST['txtObs'],
                ':status_usuario'=>$_POST['txtStatus'],
                ':img_usuario'=>$arquivo['name']
            ));
            if($sql->rowCount() > 0)
            {
                $mensagem = '<p>Dados alterados com sucesso</p>';

                $pasta = 'imagens/'.$_POST['txtID'].'/';
                
                if(!file_exists($pasta))
                {
                    mkdir($pasta);
                }

                $foto = $pasta.$arquivo['name'];

                move_uploaded_file($arquivo['tmp_name'],$foto);
            }
        }
        catch (PDOException $erro) {
            echo $erro->getMessage();
        }
    }
    else
    {
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
}
}


?>