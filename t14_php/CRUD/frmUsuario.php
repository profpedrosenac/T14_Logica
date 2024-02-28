
    <?php 
        $mensagem="";
        $ID="";
        $Nome="";
        $Login="";
        $Senha="";
        $Data="";
        $Obs="";
        $Status="";
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
                        <button class="btn btn-primary" formaction="sistema.php?tela=usuario" name="btoPesquisar">&#128269;</button>
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
                    <button class="btn btn-primary" formaction="sistema.php?tela=usuario" name="btoCadastrar">Cadastrar</button>
                    <button class="btn btn-success" formaction="sistema.php?tela=usuario" name="btoAlterar">Alterar</button>
                    <a href="sistema.php?tela=usuario" class="btn btn-dark">Limpar</a>
                    <button class="btn btn-danger" formaction="sistema.php?tela=usuario" name="btoExcluir">Excluir</button>
                </div>
            </div>
        </form>
        <div class="row">
            <div class="col-sm-12">
                <?= $mensagem ?>
            </div>
        </div>
    </div>
