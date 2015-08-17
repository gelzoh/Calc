$(document).ready(function () {
    $("#form1").submit(function (e) {
        if ($("#btnSubmit").disabled == "disabled")
            return false;
        else {
            e.preventDefault();
            calculate();
        }
    });
});

function calculate() {

    if ($("#form1").valid())
    {
        $("#btnSubmit").prop("disabled", true);
        $(".se-pre-con").fadeIn("slow");
        var calculationUrl;
        var Data = $("#req_1").val();
        switch ($("input[name='radio_1']:checked").val()) {
            case "val1":
                calculationUrl = $(location).attr('protocol') + "//"+ $(location).attr('host') + "/api/calculator/GetAllNumbers/" + Data;
                break;
            case "val2":
                calculationUrl = $(location).attr('protocol') + "//" + $(location).attr('host') + "/api/calculator/GetOddNumbers/" + Data;
                break;
            case "val3":
                calculationUrl = $(location).attr('protocol') + "//" + $(location).attr('host') + "/api/calculator/GetEvenNumbers/" + Data;
                break;
            case "val4":
                calculationUrl = $(location).attr('protocol') + "//" + $(location).attr('host') + "/api/calculator/getmultiplenumbers/" + Data;
                break;
            case "val5":
                calculationUrl = $(location).attr('protocol') + "//" + $(location).attr('host') + "/api/calculator/GetFibonacchiNumbers/" + Data;
                break;
        }
        $.ajax({
            type: "GET", //GET or POST or PUT or DELETE verb
            url: calculationUrl, // Location of the service
            contentType: "application/json; charset=utf-8", // content type sent to server
            dataType: "json", //Expected data format from server
            processdata: true, //True or False
            success: function (msg) {//On Successfull service call
                ServiceSucceeded(msg);
            },
            error: ServiceFailed// When Service call fails
        });
    }
};
function ServiceSucceeded(result) {
    $("#txtresult").val(result);
    $("#btnSubmit").prop("disabled", false);
    $(".se-pre-con").fadeOut("slow");
}

function ServiceFailed(xhr) {
    alert("There was an error in the application");
    $("#btnSubmit").prop("disabled", false);
    $(".se-pre-con").fadeOut("slow");
    /*
    if (xhr.responseText) {
        var err = xhr.responseText;
        if (err)
            alert(err);
        else
            alert("Unknown server error.");
    }*/
    return;
};