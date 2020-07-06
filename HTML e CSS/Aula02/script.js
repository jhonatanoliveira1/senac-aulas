$("#nome").blur(function(){
    var nome = document.getElementById("nome").value;
    if ( nome === ""){
        alert("Preencheu tudo?");    
    }
    
});

$("#bt1").click( function(){
   // alert("Clicou no botão!");
   $("#info1").addClass("oculta");
   $("#info2").removeClass("oculta");
});

$("#bt2").click( function(){
    // alert("Clicou no botão!");
    $("#info2").addClass("oculta");
    $("#info3").removeClass("oculta");
 });

 $("#bt3").click( function(){
    // alert("Clicou no botão!");
    $("#info3").addClass("oculta");
    $("#info4").removeClass("oculta");
 });

 $("#bt4").click( function(){
    // alert("Clicou no botão!");
    $("#info4").addClass("oculta");
    $("#info1").removeClass("oculta");
 });