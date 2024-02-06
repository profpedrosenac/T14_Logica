<!DOCTYPE html>
<html lang="br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/estilo.css">
</head>
<body>
    
    <div class="container">
        <form action="" method="post" class="form-control">
            <div class="row">
                <div class="col-sm-12">
                    <h1>Formulário simples</h1>
                </div>
                <div class="col-sm-6">
                    <p>
                        <label for="txtNome">Informe seu nome</label>
                    </p>
                    <p>
                        <input type="text" id="txtNome" name="txtNome" class="form-control" required>
                    </p>
                </div>
                <div class="col-sm-6">
                    <p>
                        <label for="txtSobrenome">Informe seu sobrenome</label>
                    </p>
                    <p>
                        <input type="text" id="txtSobrenome" name="txtSobrenome" class="form-control" required>
                    </p>
                </div>
                <div class="col-sm-12">
                    <p>
                        <button class="btn btn-success" formaction="pag02.php">Enviar</button>
                    </p>
                </div>
            </div>
        </form>
        <hr>
        <div class="row">
            <div class="col-sm-12">
                <?php

                    if($_POST)
                    {
                        //  print_r($_POST);
                        $nome = $_POST['txtNome'];

                        echo "Sou nome é ".$nome;
                    }
                ?>
            </div>
        </div>
    </div>



    <script src="js/bootstrap.js"></script>
</body>
</html>