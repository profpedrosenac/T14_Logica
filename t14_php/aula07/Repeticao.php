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
                <h1>While</h1>
            </div>
        </div>
        <form action="repeticao.php" class="form-control" method="post">
            <div class="row">
                <div class="col-sm-12">
                    <p>
                        <label for="txtN1">N1</label>
                    </p>
                    <p>
                        <input type="text" class="form-control" id="txtN1" name="txtN1">
                    </p>
                </div>
                <div class="col-sm-12 text-end">
                    <p>
                        <button class="btn btn-success" name='btoWhile'>While</button>
                        <button class="btn btn-success" name='btoDo'>Do</button>
                        <button class="btn btn-success" name='btoFor'>For</button>
                    </p>
                </div>
            </div>
        </form>
        <hr>
        <form action="" class="form-control">
            <div class="row">
                <div class="col-sm-12 text-center p-5">
                    <h2>
                    <?php

                        print_r($_POST);
                        echo '<hr>';


                        if($_POST)
                        {
                            $i = 0;
                            $fim = $_POST['txtN1'];
                            
                            if(isset($_POST['btoWhile']))
                            {
                                while ($i <= $fim)
                                {
                                    echo $i;
                                    echo " - ";
                                    $i++;
                                } 
                            }
                            if(isset($_POST['btoDo']))
                            {
                                do
                                {
                                    echo $i;
                                    echo " - ";
                                    $i++;
                                } while ($i <= $fim);
                            }
                            if(isset($_POST['btoFor']))
                            {
                               for($x = 0; $x <= $fim; $x++)
                               {
                                    echo $x;
                                    echo " - ";
                               }
                            }
                            
                        }
                    ?>
                    </h2>
                </div>
            </div>
        </form>
        
    </div>
   
</body>
</html>