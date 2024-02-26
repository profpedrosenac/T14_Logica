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
            <div class="col-12">
                <h1>Desafio</h1>
            </div>
           <hr>
          
            <form action="Tabela.php" class="form-control" method="post">
                <div class="row">
                    <div class="col-sm-3">
                        <p>
                            <label for="txtVI">Valor Inicial</label>
                        </p>
                        <p>
                            <input type="text" class="form-control" id="txtVI" name="txtVI">
                        </p>
                    </div>
                    <div class="col-sm-3">
                        <p>
                            <label for="txtAporte">Aporte</label>
                        </p>
                        <p>
                            <input type="text" class="form-control" id="txtAporte" name="txtAporte">
                        </p>
                    </div>
                    <div class="col-sm-3">
                        <p>
                            <label for="txtTaxa">Taxa</label>
                        </p>
                        <p>
                            <input type="text" class="form-control" id="txtTaxa" name="txtTaxa">
                        </p>
                    </div>
                    <div class="col-sm-3">
                        <p>
                            <label for="txtTempo">Tempo</label>
                        </p>
                        <p>
                            <input type="text" class="form-control" id="txtTempo" name="txtTempo">
                        </p>
                    </div>

                    <div class="col-sm-12 text-end">
                        <p>
                            <button class="btn btn-success" name='btoOK'>OK</button>
                        </p>
                    </div>
                </div>
            </form>
        </div>
    </div>
    <hr>
    <div class="container">
        <?php include_once('Tabela_op.php');?>
    </div>
</body>

</html>