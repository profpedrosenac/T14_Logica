<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/estilo.css">
    <script src="js/bootstrap.js"></script>
</head>
<body>
    <?php include_once('desafio02_op.php');?>
    <div class="container">
        <div class="row">
            <div class="col-12">
                <h1>Desafio 02</h1>
            </div>
        </div>
        <form action="" method="post" class="form-control">
            <div class="row">
                <!-- ID -->
                <div class="col-sm-3">
                    <p>
                        <label for="txtID">ID</label>
                    </p>
                    <p>
                        <input type="number" name="txtID" id="txtID" class="form-control" value="<?=$ID ?>">
                    </p>
                </div>
                <div class="col-sm-8"></div>
                <!-- nome -->
                <div class="col-sm-12">
                    <p>
                        <label for="txtNome">Nome</label>
                    </p>
                    <p>
                        <input type="text" name="txtNome" id="txtNome" class="form-control" value="<?=$nome ?>">
                    </p>
                </div>
                <!-- Data -->
                <div class="col-sm-3">
                    <p>
                        <label for="txtData">Data Nascimento</label>
                    </p>
                    <p>
                        <input type="date" name="txtData" id="txtData" class="form-control" value="<?=$data ?>">
                    </p>
                </div>
                <!-- CEP -->
                <div class="col-sm-3">
                    <p>
                        <label for="txtCep">Cep</label>
                    </p>
                    <p>
                        <input type="text" name="txtCep" id="txtCep" class="form-control" value="<?=$cep ?>">
                    </p>
                </div>
                <!-- Logradouro -->
                <div class="col-sm-6">
                    <p>
                        <label for="txtLogradouro">Logradouro</label>
                    </p>
                    <p>
                        <input type="text" name="txtLogradouro" id="txtLogradouro" class="form-control" value="<?=$rua ?>">
                    </p>
                </div>

                 <!-- Numero -->
                 <div class="col-sm-2">
                    <p>
                        <label for="txtNumero">Numero</label>
                    </p>
                    <p>
                        <input type="number" name="txtNumero" id="txtNumero" class="form-control" value="<?=$numero ?>">
                    </p>
                </div>
                <!-- Complemento -->
                <div class="col-sm-3">
                    <p>
                        <label for="txtComplemento">Complemento</label>
                    </p>
                    <p>
                        <input type="text" name="txtComplemento" id="txtComplemento" class="form-control" value="<?=$complemento ?>">
                    </p>
                </div>

                <!-- Bairro -->
                <div class="col-sm-3">
                    <p>
                        <label for="txtBairro">Bairro</label>
                    </p>
                    <p>
                        <input type="text" name="txtBairro" id="txtBairro" class="form-control" value="<?=$bairro ?>">
                    </p>
                </div>

                <!-- Cidade -->
                <div class="col-sm-4">
                    <p>
                        <label for="txtCidade">Cidade</label>
                    </p>
                    <p>
                        <input type="text" name="txtCidade" id="txtCidade" class="form-control" value="<?=$cidade ?>">
                    </p>
                </div>

                <!-- UF -->
                <div class="col-sm-4">
                    <p>
                        <label for="txtUF">UF</label>
                    </p>
                    <p>
                        <select name="txtUF" id="txtUF" class="form-control">
                            <option value="">-- UF --</option>
                            <option value="AC" <?=($estado == 'AC')?'selected':''; ?>>Acre</option>
                            <option value="AL"<?=($estado == 'AL')?'selected':''; ?>>Alagoas</option>
                            <option value="AP"<?=($estado == 'AP')?'selected':''; ?>>Amapá</option>
                            <option value="AM"<?=($estado == 'AM')?'selected':''; ?>>Amazonas</option>
                            <option value="BA"<?=($estado == 'BA')?'selected':''; ?>>Bahia</option>
                            <option value="CE"<?=($estado == 'CE')?'selected':''; ?>>Ceará</option>
                            <option value="DF"<?=($estado == 'DF')?'selected':''; ?>>Distrito Federal</option>
                            <option value="ES"<?=($estado == 'ES')?'selected':''; ?>>Espirito Santo</option>
                            <option value="GO"<?=($estado == 'GO')?'selected':''; ?>>Goiás</option>
                            <option value="MA"<?=($estado == 'MA')?'selected':''; ?>>Maranhão</option>
                            <option value="MS"<?=($estado == 'MS')?'selected':''; ?>>Mato Grosso do Sul</option>
                            <option value="MT"<?=($estado == 'MT')?'selected':''; ?>>Mato Grosso</option>
                            <option value="MG"<?=($estado == 'MG')?'selected':''; ?>>Minas Gerais</option>
                            <option value="PA"<?=($estado == 'PA')?'selected':''; ?>>Pará</option>
                            <option value="PB"<?=($estado == 'PB')?'selected':''; ?>>Paraíba</option>
                            <option value="PR"<?=($estado == 'PR')?'selected':''; ?>>Paraná</option>
                            <option value="PE"<?=($estado == 'PE')?'selected':''; ?>>Pernambuco</option>
                            <option value="PI"<?=($estado == 'PI')?'selected':''; ?>>Piauí</option>
                            <option value="RJ"<?=($estado == 'RJ')?'selected':''; ?>>Rio de Janeiro</option>
                            <option value="RN"<?=($estado == 'RN')?'selected':''; ?>>Rio Grande do Norte</option>
                            <option value="RS"<?=($estado == 'RS')?'selected':''; ?>>Rio Grande do Sul</option>
                            <option value="RO"<?=($estado == 'RO')?'selected':''; ?>>Rondônia</option>
                            <option value="RR"<?=($estado == 'RR')?'selected':''; ?>>Roraima</option>
                            <option value="SC"<?=($estado == 'SC')?'selected':''; ?>>Santa Catarina</option>
                            <option value="SP"<?=($estado == 'SP')?'selected':''; ?>>São Paulo</option>
                            <option value="SE"<?=($estado == 'SE')?'selected':''; ?>>Sergipe</option>
                            <option value="TO"<?=($estado == 'TO')?'selected':''; ?>>Tocantins</option>
                        </select>
                    </p>
                </div>
                <!-- Pais -->
                <div class="col-sm-4">
                    <p>
                        <label for="txtPais">Pais</label>
                    </p>
                    <p>
                        <input type="text" name="txtPais" id="txtPais" class="form-control" value="<?=$pais ?>">
                    </p>
                </div>

                <!-- Status -->
                <div class="col-sm-4">
                    <p>
                        <label for="txtStatus">Status</label>
                    </p>
                    <p>
                        <select name="txtStatus" id="txtStatus" class="form-control">
                            <option value="">-- Status --</option>
                            <option value="Ativo" <?=($status == 'Ativo')?'selected':''; ?>>Ativo</option>
                            <option value="Inativo" <?=($status == 'Inativo')?'selected':''; ?>>Inativo</option>
                        </select>
                    </p>
                </div>

                <!-- Observação -->
                <div class="col-sm-12">
                    <p>
                        <label for="txtObs">Obs</label>
                    </p>
                    <p>
                        <textarea name="txtObs" id="txtObs" rows="5" class="form-control"><?=$observação ?></textarea>
                    </p>
                </div>
            </div>

             <!-- Botões -->
             <div class="col-sm-12 text-end">
                <p>
                    <button class="btn btn-success">OK</button>
                    <a href="desafio02.php" class="btn btn-danger">Limpar</a>
                </p>
            </div>
        </div>
        </form>
    </div>
</body>
</html>