<div class="row">
    <div class="col-sm-12">
        <table class="table table-dark table-hover">
            <thead>
                <tr>
                    <th>Mês</th>
                    <th>Valor</th>
                    <th>Aporte</th>
                    <th>Taxa</th>
                    <th>Total sem juros</th>
                    <th>Juros</th>
                    <th>Total</th>
                </tr>
            </thead>
            <tbody>
                <?php

                if($_POST)
                {      
                    $vi = $_POST['txtVI'];
                    $ap = $_POST['txtAporte'];

                    $taxa = $_POST['txtTaxa'];
                    $taxa = $taxa / 12;
                    $taxa = $taxa / 100;

                    $tempo = $_POST['txtTempo'];
                    $tempo = $tempo * 12;

                    $valorsem = 0;
                    $juros = 0;

                    for($i = 1;$i <= $tempo; $i++)
                    {

                        $valorsem = $vi + $ap;
                        $juros = $valorsem * $taxa;

                        echo
                        '
                        <tr>
                            <td>Mês - '.$i.'</td>
                            <td>R$ '.number_format($vi,2,",",".").'</td>
                            <td>R$ '.number_format($ap,2,",",".").'</td>
                            <td>R$ '.number_format($taxa,2,",",".").'</td>
                            <td>R$ '.number_format($valorsem,2,",",".").'</td>
                            <td>R$ '.number_format($juros,2,",",".").'</td>';
                        
                        $vi = $valorsem + $juros;
                        echo
                        '
                            <td>R$ '.number_format($vi,2,",",".").'</td>
                        </tr>
                        ';
                    }
                }
                ?>
            </tbody>
            <tfoot>
                <tr>
                    <th>Mês</th>
                    <th>Valor</th>
                    <th>Aporte</th>
                    <th>Taxa</th>
                    <th>Total sem juros</th>
                    <th>Juros</th>
                    <th>Total</th>
                </tr>
            </tfoot>
        </table>
    </div>
</div>