<?php

session_start();

if(isset($_SESSION['idUsuarioLogin']))
{
    $idUsuarioSessao = $_SESSION['idUsuarioLogin'];
    $nomeUsuarioSessao = $_SESSION['nomeUsuarioLogin'];
    $loginUsuarioSessao = $_SESSION['loginUsuarioLogin'];
}
else
{
    header('Location:index.php');
}

?>