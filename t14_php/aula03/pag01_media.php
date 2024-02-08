<?php

//print_r($_POST);

if($_POST)
{
    $n1 = $_POST['txtN1'];
    $n2 = $_POST['txtN2'];
    $n3 = $_POST['txtN3'];
    $n4 = $_POST['txtN4'];
    $media = 0;
    $status = "";
    $cor = "";
    
    $media=($n1+$n2+$n3+$n4)/4;

    if($media >= 7)
    {
        $status = "APROVADO";
        $cor = "blue";
    }
    elseif($media < 5)
    {
        $status = "REPROVADO";
        $cor = "red";
    }
    else
    {
        $status = "EXAME";
        $cor = "orange";
    }

    echo "<h2 style='background-color:$cor' class='p-5'>$status - $media</h2>";
}

?>