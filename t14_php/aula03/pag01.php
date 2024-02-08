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
                <h1>Atividade média escolar</h1>
            </div>
        </div>
        <form action="" method="post" class="form-control">
            <div class="row">
                <div class="col-sm-3">
                    <p>
                        <label for="txtN1">N1</label>
                    </p>
                    <p>
                        <input type="number" name="txtN1" id="txtN1" step="0.5" max="10" min="0" class="form-control">
                    </p>
                </div>
                
                <div class="col-sm-3">
                    <p>
                        <label for="txtN2">N2</label>
                    </p>
                    <p>
                        <input type="number" name="txtN2" id="txtN2" step="0.5" max="10" min="0" class="form-control">
                    </p>
                </div>
                <div class="col-sm-3">
                    <p>
                        <label for="txtN3">N3</label>
                    </p>
                    <p>
                        <input type="number" name="txtN3" id="txtN3" step="0.5" max="10" min="0" class="form-control">
                    </p>
                </div>
                <div class="col-sm-3">
                    <p>
                        <label for="txtN1">N4</label>
                    </p>
                    <p>
                        <input type="number" name="txtN4" id="txtN4" step="0.5" max="10" min="0" class="form-control">
                    </p>
                </div>
                <div class="col-sm-12 text-end">
                    <button class="btn btn-success">OK</button>
                    <a href="pag01.php" class="btn btn-danger">Limpar</a>
                </div>
            </div>
        </form>
        <hr>
        <div class="row">
            <div class="col-sm-12 text-center">
                
                <?php
                include_once("pag01_media.php");
                ?>
                
            </div>
        </div>
    </div>
</body>
</html>