<?php
    include 'conecta.php';

    $sql = "SELECT * FROM clientes";

    $consulta = $conexao->query($sql);

    //$registros = $consulta->fetch_assoc_all();
    //var_dump($registros);

    while($dados = $consulta->fetch_assoc()){
        echo $dados['id_cliente'] . "<br>";
        echo $dados['nome_cliente'] . "<br>";
        echo $dados['email_cliente'] . "<br>";
        echo $dados['telefone'] . "<br>";
    }

?>