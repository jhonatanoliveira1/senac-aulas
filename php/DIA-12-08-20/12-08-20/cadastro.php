<?php include("Includes/Header.php") ?>
<div class="Content">
    <?php
            include("class/ClassConect.php");
            include("class/ClassCrud.php");
            $Crud=new ClassCrud();
        ?>
    <div class="Formulario">
        <h1 class="Center">Cadastro</h1>
            <form id="cadastro" method="post" action="Controllers/ControllerCadastro.php"> 
                <div class="FormularioInput">
                    Usuário: <br>
                    <input type="text" id="User" name="User">
                </div>

                <div class="FormularioInput">
                    Senha: <br>
                    <input type="password" id="Senha" name="Senha">
                </div>

                <div class="FormularioInput">
                    E-mail: <br>
                    <input type="text" id="Email" name="Email">
                </div>

                <div class="FormularioInput FormularioInputw100 Center">
                    <input type="submit" value="Cadastrar">
                </div>
            </form>
    </div>
</div>
<?php include("Includes/Footer.php") ?>