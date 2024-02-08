<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/estilo.css">
    <script src="js/bootstrap.js"></script>
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <h1>Atividade 01</h1>
            </div>
        </div>
        <form action="" method="post" class="form-control">
            <div class="row">
                <div class="col-sm-6">
                    <p>
                        <label for="txtNome">Nome</label>
                    </p>
                    <p>
                        <input type="text" id="txtNome" name="txtNome" placeholder="Informe seu nome" class="form-control" required>
                    </p>
                </div>
                <div class="col-sm-6">
                    <p>
                        <label for="txtSobrenome">Sobrenome</label>
                    </p>
                    <p>
                        <input type="text" id="txtSobrenome" name="txtSobrenome" placeholder="Informe seu Sobrenome" class="form-control" required>
                    </p>
                </div>
                <div class="col-sm-12">
                    <button id="btoOK" class="btn btn-primary">Enviar</button>
                    <a href="pag01.php" id="btoLimpar" class="btn btn-danger">Limpar</a>
                </div>
            </div>
        </form>
        <hr>
        <div class="row">
            <div class="col-sm-12">
                <?php
                if($_POST)
                {
                    $nome = $_POST['txtNome'];
                    $sobrenome = $_POST['txtSobrenome'];

                    echo 'O nome completo é <b>'.$nome." ".$sobrenome.".</b>";
                }
                ?>
            </div>
        </div>
    </div>
</body>
</html>