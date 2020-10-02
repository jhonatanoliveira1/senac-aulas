var mm = $("#mm").text();

$("button").click(function (){
    escreve($(this).val());
});

// Operadores
$("#i").click(function (){
    $("#display").val( $("#display").val() + "=" );
});
$("#mul").click(function (){
    mutiplicaValor();
});
$("#sum").click(function (){  
    adicaoValor();
});
$("#sub").click(function (){
    subtracaoValor();
});
$("#divi").click(function (){
    dividirValor();
});
$("#per").click(function (){
    porcentoValor();
});
$("#vir").click(function (){
    $("#display").val( $("#display").val() + "," );
});

//$("CE").click(function (){
    //if 
    //$("#valor1").val("");
    //$("#valor2").val("");
    //$("#display").val("");
//})

$("C").click(function (){
    $("#valor1").val("");
    $("#valor2").val("");
    $("#display").val("");
    $("#mm").val("");

})
// funções

function escreve(valor){
    $("#display").val( $("#display").val() + valor);
}

function dividirValor (valor1, valor2) {
    mm = Number($("#display").val()) / Number(mm);
    $("#mm").text(mm);
    $("display").val(""); 
}

function adicaoValor(valor1, valor2) {
    mm = Number($("#display").val()) + Number(mm);
    $("#mm").text(mm);
    $("#display").val("");
}

function subtracaoValor (valor1, valor2) {
    mm = Number($("#display").val()) - Number(mm);
    $("#mm").text(mm);
    $("display").val("");
}

function mutiplicaValor (valor1, valor2) {
    mm = Number($("#display").val()) * Number(mm);
    $("#mm").text(mm);
    $("display").val("");
}

function porcentoValor (valor1, valor2) {
    mm = Number($("#display").val() * Number(mm)) /100;
    $("#mm").text(mm);
    $("display").val("");
}
