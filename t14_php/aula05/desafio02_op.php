<?php
$ID='';
$nome='';
$data='';
$rua='';
$numero='';
$complemento='';
$cep='';
$bairro='';
$cidade='';
$estado='';
$pais='';
$observação='';
$status='';

if($_POST)
{
    echo '<pre>';
    print_r($_POST);
    echo '</pre>';

    $ID=$_POST['txtID'];
    $nome=$_POST['txtNome'];
    $data=$_POST['txtData'];
    $rua=$_POST['txtLogradouro'];
    $numero=$_POST['txtNumero'];
    $complemento=$_POST['txtComplemento'];
    $cep=$_POST['txtCep'];
    $bairro=$_POST['txtBairro'];
    $cidade=$_POST['txtCidade'];
    $estado=$_POST['txtUF'];
    $pais=$_POST['txtPais'];
    $observação=$_POST['txtObs'];
    $status=$_POST['txtStatus'];
}
?>