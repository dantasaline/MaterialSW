<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        table,td, th, tr{
            border: 2px solid red;
        }
    </style>
</head>
<body>
    <table>
        <tr>
            <th>Um </th>
            <th>Dois </th>
            <th>Três </th>
        </tr>

        <?php
            for($i=1;$i<=10;$i++){
                echo "<tr>
                    <td>jhjsdahfjhsd</td>
                    <td>jhjsdahfjhsd</td>
                    <td>jhjsdahfjhsd</td>
                </tr>";
            }      
        ?>
    </table>
</body>
</html>