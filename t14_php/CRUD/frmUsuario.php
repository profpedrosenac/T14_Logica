
    <?php 
        $mensagem="";
        $ID="";
        $Nome="";
        $Login="";
        $Senha="";
        $Data="";
        $Obs="";
        $Status="";
        $Img="";
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
        <form action="" class="form-control" method="post" enctype="multipart/form-data" onsubmit="return false;" name="frmUsuario" id="frmUsuario">
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
                        <button class="btn btn-primary" formaction="sistema.php?tela=usuario" name="btoPesquisar "onclick="Enviar('Pes')">&#128269;</button>
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
                <div class="col-sm-8">
                    <p>
                        <label for="txtNome">Nome</label>
                    </p>
                    <p>
                        <input type="text" name="txtNome" id="txtNome" class="form-control" value="<?=$Nome?>">
                    </p> 
                </div>
                <div class="col-sm-4">
                    <p>
                        <label for="txtImg">Foto Perfil</label>
                    </p>
                    <p>
                        <input type="file" name="txtImg" id="txtImg" class="form-control" value="<?=$Img?>">
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
                <div class="col-sm-8">
                    <p>
                        <label for="txtObs">Observação</label>
                    </p>
                    <p>
                        <textarea name="txtObs" id="txtObs" rows="5" class="form-control"><?=$Obs?></textarea>
                    </p> 
                </div>
                <div class="col-sm-4">
                    <img src="imagens/<?=$idUsuario?>/<?=$Img?>" alt="" class="w-100">
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12 text-end">
                    <button class="btn btn-primary" formaction="sistema.php?tela=usuario" name="btoCadastrar" onclick="Enviar('Cad')">Cadastrar</button>
                    <button class="btn btn-success" formaction="sistema.php?tela=usuario" name="btoAlterar" onclick="Enviar('Alt')">Alterar</button>
                    <a href="sistema.php?tela=usuario" class="btn btn-dark">Limpar</a>
                    <button class="btn btn-danger" formaction="sistema.php?tela=usuario" name="btoExcluir" onclick="Enviar('Exc')">Excluir</button>
                </div>
            </div>
            <input type="text" name="txtAcao" id="txtAcao" style="display: none;">
        </form>
        <div class="row">
            <div class="col-sm-12">
                <?= $mensagem ?>
            </div>
        </div>
    </div>

    <script>
        const id = document.getElementById("txtID");
        const nome = document.getElementById("txtNome");
        const login = document.getElementById("txtLogin");
        const senha = document.getElementById("txtSenha");
        const status = document.getElementById("txtStatus");
        const obs = document.getElementById("txtObs");
        const img = document.getElementById("txtImg");
        const dataCad = document.getElementById("txtData");
        const acao = document.getElementById("txtAcao");
        const caminho = "sistema.php?tela=usuario";
        const formulario = document.getElementById("frmUsuario");

        function Enviar(tipo)
        {
            console.log(tipo);

            if(tipo == "Pes")
            {
                acao.value='Pesquisar'

                if(id.value=="")
                {
                    alert ("Valor do ID deve ser preenchido")
                    id.focus()
                    return;
                }

                formulario.action=caminho
                formulario.submit()
            }

            if(tipo == "Exc")
            {
                acao.value='Excluir'

                if(id.value=="")
                {
                    alert ("Valor do ID deve ser preenchido")
                    id.focus()
                    return;
                }

                formulario.action=caminho
                formulario.submit()
            }

            if(tipo == "Alt")
            {
                acao.value='Alterar'

                if(id.value=="")
                {
                    alert ("Valor do ID deve ser preenchido")
                    id.focus()
                    return;
                }

                formulario.action=caminho
                formulario.submit()
            }

            if(tipo == "Cad")
            {
                acao.value='Cadastrar'

                if(nome.value=="")
                {
                    alert ("Valor do Nome deve ser preenchido")
                    nome.focus()
                    return;
                }

                formulario.action=caminho
                formulario.submit()
            }
            console.log(acao.value)
        }
    </script>