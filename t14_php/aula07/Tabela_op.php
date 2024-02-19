<div class="row">
    <div class="col-sm-12">
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
                <?php
                $totais=array(0,0,0,0,0);

                if($_POST)
                {

                    
                    for($i = 1; $i <= $_POST['txtN1']; $i++)
                    {
                        $valores=array(
                            rand(500,5000),
                            rand(500,5000),
                            rand(500,5000),
                            rand(500,5000)
                        );

                        $totais[0]=$totais[0]+$valores[0];
                        $totais[1]=$totais[1]+$valores[1];
                        $totais[2]=$totais[2]+$valores[2];
                        $totais[3]=$totais[3]+$valores[3];


                        $totalL = $valores[0]+$valores[1]+$valores[2]+$valores[3];

                        $totais[4]=$totais[4]+$totalL;

                        echo
                        '
                        <tr>
                            <td>Nome-'.$i.'</td>
                            <td>'.$valores[0].'</td>
                            <td>'.$valores[1].'</td>
                            <td>'.$valores[2].'</td>
                            <td>'.$valores[3].'</td>
                            <td>'.$totalL.'</td>
                        </tr>
                        ';
                    }                    
                }
                ?>
            </tbody>
            <tfoot>
                <tr>
                    <td>Total</td>
                    <td><?= $totais[0] ?></td>
                    <td><?= $totais[1] ?></td>
                    <td><?= $totais[2] ?></td>
                    <td><?= $totais[3] ?></td>
                    <td><?= $totais[4] ?></td>
                </tr>
            </tfoot>
        </table>
    </div>
</div>