<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/estilo.css">
</head>

<body>

    <div class="container">
        <div class="row">
            <div class="col-sm 12">
                <h1>Trabalhando com JS e PHP</h1>
            </div>
        </div>

        <form action="" onsubmit="return false;" id="frmForm" class="form-control" method="post" enctype="multipart/form-data">
            <div class="row">
                <div class="col-sm-12">
                    <p><label for="txtNome">Informe seu nome</label></p>
                    <p><input type="text" name="txtNome" id="txtNome" class="form-control"></p>
                    <p><input type="file" name="txtImg" id="txtImg" class="form-control"></p>
                    <p>
                        <button class="btn btn-success" onclick="Enviar();" id="btnEnviar"
                            name="btnEnviar">Enviar</button>
                        <button class="btn btn-success" onclick="Enviar2();" id="btnEnviar2"
                            name="btnEnviar2">Enviar 2</button>
                    </p>
                    <p style="display: none;"><input type="text" id="txtAcao" name="txtAcao"></p>
                </div>
            </div>
        </form>

    </div>
    <script src="js/bootstrap.js"></script>
    <script>
        let formulario = document.getElementById("frmForm")
        let nome = document.getElementById("txtNome")
        let acao = document.getElementById("txtAcao")
        
        function Enviar() {
            console.log("Clicou no enviar")
            acao.value="cadastrar"

            if(nome.value == "")
            {
                alert("Erro, nome deve ser preenchido")
                nome.focus()
                return;
            }
            formulario.action="teste.php"
            formulario.submit()
        }
        function Enviar2() {
            console.log("Clicou no enviar")
            acao.value="alterar"

            if(nome.value == "")
            {
                alert("Erro, nome deve ser preenchido")
                nome.focus()
                return;
            }
            formulario.action="teste.php"
            formulario.submit()
        }

    </script>
</body>

</html>