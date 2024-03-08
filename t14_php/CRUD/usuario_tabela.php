<table class="table table-striped table-hover">
    <thead>
        <tr>
            <th>ID</th>
            <th>Nome</th>
            <th>Usuário</th>
            <th>status</th>
            <th>botões</th>
        </tr>
    </thead>
    <tbody>
        <?php

        include_once('conexao.php');

        try
        {
            $sql = $conn->query('select * from usuario');

            foreach($sql as $linha)
            {
                echo
                "
                <tr>
                    <td>$linha[0]</td>
                    <td>$linha[1]</td>
                    <td>$linha[2]</td>
                    <td>$linha[6]</td>
                    <td>
                        <a href='sistema.php?tela=usuario&IDUsuario=$linha[0]' class='btn btn-primary'>&#128269;</a>
                        <a href='#' class='btn btn-danger'>Excluir</a>
                    </td>
                <tr>
                ";
            }
        }
        catch(PDOException $erro)
        {
            echo $erro->getMessage();
        }

        ?>
    </tbody>
    <tfoot>
        <tr>
            <th>ID</th>
            <th>Nome</th>
            <th>Usuário</th>
            <th>status</th>
            <th>botões</th>
        </tr>
    </tfoot>
</table>

