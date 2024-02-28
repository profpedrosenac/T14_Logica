<!DOCTYPE html>
<html lang="br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário de Usuários</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/estilo.css">
    <script src="js/bootstrap.js"></script>
</head>

<body>

    <div class="container">
        <div class="row">
            <?php include_once("_topo.php"); ?>
        </div>
    </div>
    <div class="container mb-3">
        <div class="row">
            <div class="col-sm-2">
                <?php include_once("_menu.php"); ?>
            </div>
            <div class="col-sm-10">
                <?php
                if(isset($_GET['tela']))
                {
                    $tela = $_GET['tela'];

                    if($tela=='usuario')
                    {
                        include_once("frmUsuario.php"); 
                    }
                    
                }
                else
                {
                    include_once("_home.php"); 
                }
                ?>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="row">
        <?php include_once("_rodape.php"); ?>
        </div>
    </div>
    
</body>

</html>