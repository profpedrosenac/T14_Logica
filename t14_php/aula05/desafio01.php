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
                <h1>Desafio 01</h1>
            </div>
        </div>
        <form action="desafio01.php" class="form-control" method="post">
            <div class="row">
                <div class="col-sm-3">
                    <p>
                        <label for="txtN1"> N1</label>
                    </p>
                    <p>
                        <input type="number" name="txtN1" id="txtN1" class="form-control">
                    </p>
                </div>
                <div class="col-sm-3">
                    <p>
                        <label for="txtN2"> N2</label>
                    </p>
                    <p>
                        <input type="number" name="txtN2" id="txtN2" class="form-control">
                    </p>
                </div>
                <div class="col-sm-3">
                    <p>
                        <label for="txtN3"> N3</label>
                    </p>
                    <p>
                        <input type="number" name="txtN3" id="txtN3" class="form-control">
                    </p>
                </div>
                <div class="col-sm-3">
                    <p>
                        <label for="txtN4"> N4</label>
                    </p>
                    <p>
                        <input type="number" name="txtN4" id="txtN4" class="form-control">
                    </p>
                </div>
                <div class="col-sm-12 text-end">
                    <button class="btn btn-success">OK</button>
                    <a href="desafio01.php" class="btn btn-danger">Limpar</a>
                </div>
            </div>
        </form>
        <div class="row mt-2">
            <div class="col-sm-12 text-center p-5" style="background-color:#CCC">
                <h1>
                    <?php
                    if($_POST)
                    {
                        sort($_POST);
                        
                        echo $_POST[0];
                        echo " - ";
                        echo $_POST[1];
                        echo " - ";
                        echo $_POST[2];
                        echo " - ";
                        echo $_POST[3];
                    }
                    ?>
                </h1>                
            </div>
        </div>
    </div>
</body>
</html>