<?php
if($_POST)
{
if($_POST['txtAcao']=='Excluir')
{
    include_once('conexao.php');

    try 
    {
        $sql = $conn->prepare('
            delete from usuario where id_usuario=:id_usuario
        ');

        $sql->execute(array(
            ':id_usuario'=>$_POST['txtID']
        ));

        if($sql->rowCount() > 0)
        {
            $mensagem = '<p>Cadastro excluido com sucesso</p>';
        }
    } 
    catch (PDOException $erro) {
        echo $erro->getMessage();
    }
}
}


?>