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
                        <label for="txtN1">N1</label>
                    </p>
                    <p>
                        <input type="number" id="txtN1" name="txtN1" placeholder="" class="form-control" required>
                    </p>
                </div>
                <div class="col-sm-6">
                    <p>
                        <label for="txtN2">N2</label>
                    </p>
                    <p>
                        <input type="number" id="txtN2" name="txtN2" placeholder="" class="form-control" required>
                    </p>
                </div>
                <div class="col-sm-12">
                    <button id="btoMais" name="btoMais" class="btn btn-primary" formaction="pag02.php">+</button>
                    <button id="btoMenos" name="btoMenos" class="btn btn-success" formaction="pag02.php">-</button>
                    <button id="btoVezes" name="btoVezes" class="btn btn-warning" formaction="pag02.php">x</button>
                    <button id="btoDividir" name="btoDividir" class="btn btn-info" formaction="pag02.php">:</button>
                    <a href="pag02.php" id="btoLimpar" class="btn btn-danger">CE</a>
                </div>
            </div>
        </form>
    </div>
    <?php include_once('pag02_op.php') ?>
</body>
</html>