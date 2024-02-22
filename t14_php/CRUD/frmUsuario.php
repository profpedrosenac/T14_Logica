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
    <?php 
        $mensagem="";
        include_once('usuario_pesquisar.php');
        include_once('usuario_cadastrar.php');
        include_once('usuario_alterar.php');
        include_once('usuario_excluir.php');
    ?>
    <div class="container">
        <div class="row">
            <div class="col-sm-12">
                <hr>
                <h1>Formulário de Usários</h1>
                <hr>
            </div>
        </div>
        <form action="" class="form-control" method="post">
            <div class="row">
                <div class="col-sm-3">
                    <p>
                        <label for="txtID">ID</label>
                    </p>
                    <p>
                        <input type="text" name="txtID" id="txtID" class="form-control" value="<?=$ID?>">
                    </p>
                </div>
                <div class="col-sm-3">
                    <p>
                        &nbsp;
                    </p>
                    <p>
                        <button class="btn btn-primary" formaction="frmUsuario.php" name="btoPesquisar">&#128269;</button>
                    </p>
                </div>
                <div class="col-sm-3"></div>
                <div class="col-sm-3">                   
                    <p>
                        <label for="txtData">Data</label>
                    </p>
                    <p>
                        <input type="date" name="txtData" id="txtData" class="form-control" value="<?=$Data?>">
                    </p>                   
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <p>
                        <label for="txtNome">Nome</label>
                    </p>
                    <p>
                        <input type="text" name="txtNome" id="txtNome" class="form-control" value="<?=$Nome?>">
                    </p> 
                </div>
            </div>
            <div class="row">
                <div class="col-sm-4">
                    <p>
                        <label for="txtLogin">Login</label>
                    </p>
                    <p>
                        <input type="text" name="txtLogin" id="txtLogin" class="form-control" value="<?=$Login?>">
                    </p>
                </div>
                <div class="col-sm-4">
                    <p>
                        <label for="txtSenha">Senha</label>
                    </p>
                    <p>
                        <input type="password" name="txtSenha" id="txtSenha" class="form-control" value="<?=$Senha?>">
                    </p>
                </div>
                <div class="col-sm-4">                   
                    <p>
                        <label for="txtStatus">Status</label>
                    </p>
                    <p>
                        <select name="txtStatus" id="txtStatus" class="form-control">
                            <option value=""> -- Status -- </option>
                            <option value="ATIVO" <?=($Status=='ATIVO')?'Selected':'';?>>Ativo</option>
                            <option value="INATIVO" <?=($Status=='INATIVO')?'Selected':'';?>>Inativo</option>
                        </select>
                    </p>              
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    <p>
                        <label for="txtObs">Observação</label>
                    </p>
                    <p>
                        <textarea name="txtObs" id="txtObs" rows="5" class="form-control"><?=$Obs?></textarea>
                    </p> 
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12 text-end">
                    <button class="btn btn-primary" formaction="frmUsuario.php" name="btoCadastrar">Cadastrar</button>
                    <button class="btn btn-success" formaction="frmUsuario.php" name="btoAlterar">Alterar</button>
                    <a href="frmUsuario.php" class="btn btn-dark">Limpar</a>
                    <button class="btn btn-danger" formaction="frmUsuario.php" name="btoExcluir">Excluir</button>
                </div>
            </div>
        </form>
        <div class="row">
            <div class="col-sm-12">
                <?= $mensagem ?>
            </div>
        </div>
    </div>
</body>
</html>