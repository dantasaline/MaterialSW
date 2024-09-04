<?php
    require('conecta.php');
    $email = $_POST['email'];
    $senha = $_POST['senha'];

    $consulta = "SELECT * FROM usuarios WHERE email = '$email' AND senha = '$senha'";

    $resultado = $conexao->query($consulta);

    //echo "Numeros de registros ==> ". $resultado;
    //var_dump($resultado);


    $registros = $resultado->num_rows;

    //echo "Numeros de registros ==> ". $registros;

    $resultado_usuario = mysqli_fetch_assoc($resultado);
    
    //var_dump($resultado_usuario);

    if($registros == 1){
        //echo "TE ACHEI ==> " . $resultado_usuario['nome'];       
               
        header('Location: index.php');

    }
    else{
        //echo "NÃO ACHEI";        
        header('Location: ../index.html');
    }



?>