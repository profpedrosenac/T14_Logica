<div class="container">
    <div class="row">
        <div class="col-sm-12">
            <p>
                <?php
                    print_r($_POST);
                    if($_POST)
                    {
                        $n1 = $_POST['txtN1'];
                        $n2 = $_POST['txtN2'];
                        $total = 0;

                        if(isset($_POST['btoMais']))
                        {
                            $total = $n1+$n2;
                        } 
                        elseif (isset($_POST['btoMenos']))
                        {
                            $total = $n1-$n2;
                        }
                        elseif (isset($_POST['btoVezes']))
                        {
                            $total = $n1*$n2;
                        }
                        elseif (isset($_POST['btoDividir']))
                        {
                            $total = $n1/$n2;
                        }
                        else{
                            echo "Erro";
                        }

                        echo "<h2>$total</h2>";
                        //echo '<h2>$total</h2>';
                    }
                ?>
            </p>
        </div>
    </div>
</div>