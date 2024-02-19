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
                <h1>Rand</h1>
            </div>
            <div class="col-12">
                <h1>
                    <?php
                        echo rand(1,100);
                    ?>
                </h1>
            </div>
            <hr>
            <div class="col-12">
                <table class="table table-dark table-hover">
                    <thead>
                        <tr>
                            <th>Nomes</th>
                            <th>Bimestro 01</th>
                            <th>Bimestro 02</th>
                            <th>Bimestro 03</th>
                            <th>Bimestro 04</th>
                            <th>Total</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Joaquim</td>
                            <td>50</td>
                            <td>1000</td>
                            <td>1532</td>
                            <td>5520</td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>Matuzalem</td>
                            <td>50</td>
                            <td>1000</td>
                            <td>1532</td>
                            <td>5520</td>
                            <td></td>
                        </tr>
                    </tbody>
                    <tfoot>
                        <tr>
                            <td>Total</td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                            <td></td>
                        </tr>
                    </tfoot>
                </table>
            </div>
            <form action="tabela.php" class="form-control" method="post">
                <div class="row">
                    <div class="col-sm-12">
                        <p>
                            <label for="txtN1">Informe a qtde de linhas da tabela</label>
                        </p>
                        <p>
                            <input type="text" class="form-control" id="txtN1" name="txtN1">
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
</body>

</html>